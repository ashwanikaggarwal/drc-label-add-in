using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class DataModel
	{
		private readonly string _setMain		= Properties.Settings.Default.DataModel_MainSet;
		private readonly string _tableMain		= Properties.Settings.Default.DataModel_MainTable;

		private readonly string _colName		= Properties.Settings.Default.ColumnID_Name;
		private readonly string _colSerialNum	= Properties.Settings.Default.ColumnID_SerialNumber;
		private readonly string _colBarcode		= Properties.Settings.Default.ColumnID_Barcode;

		private DataSet _data;
		private DataTable _items;

		public DataModel()
		{
			_data = new DataSet(_setMain);
			_items = CreateItemsTable();
			_data.Tables.Add(_items);
		}

		private DataTable CreateItemsTable()
		{
			DataTable table = new DataTable(_tableMain);
			table.Columns.Add(_colName, typeof(string));
			table.Columns.Add(_colSerialNum, typeof(string));
			table.Columns.Add(_colBarcode, typeof(string));
			return table;
		}

		public bool IsEmpty()
		{
			return _items == null || _items.Rows.Count <= 0;
		}

		public void Add(string name, string serialNum, string barcode, int index)
		{
			DataRow row = _items.NewRow();
			row[_colName] = name;
			row[_colSerialNum] = serialNum;
			row[_colBarcode] = barcode;
			_items.Rows.InsertAt(row, index);
		}

		public void Add(string name, string serialNum, string barcode)
		{
			Add(name, serialNum, barcode, _items.Rows.Count);
		}

		public void RemoveAt(int index)
		{
			_items.Rows.RemoveAt(index);
		}

		public void WriteToFile(string path)
		{
			List<string> lines = new List<string>();
			List<string> columns = new List<string>();

			foreach(DataColumn column in _items.Columns)
			{
				columns.Add(column.ColumnName);
			}
			lines.Add(string.Join(",", columns));
			
			foreach(DataRow row in _items.Rows)
			{
				lines.Add(string.Join(",", row.ItemArray));
			}
			System.IO.File.WriteAllLines(path, lines);
		}

		public void LoadImport(string fileName)
		{
			string strDir = System.IO.Path.GetDirectoryName(fileName);
			string strFile = System.IO.Path.GetFileName(fileName);

			OleDbConnection conn = new OleDbConnection
			{
				ConnectionString = String.Format(Properties.Settings.Default.DBConnLocal, strDir)
			};
			conn.Open();

			OleDbCommand cmdSelectAll = new OleDbCommand($"SELECT TOP 10 * FROM [{strFile}]");

			string selection = null;
			using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdSelectAll.CommandText, conn))
			using (DataTable importTable = new DataTable("ImportTable"))
			{
				adapter.Fill(importTable);
				selection = GetFields(importTable);
			}

			if(selection == null)
			{
				//user closed out of import control form
				//do not complete import process
				conn.Close();
				return;
			}
			
			OleDbCommand cmdSelect = new OleDbCommand($"SELECT {selection} FROM [{strFile}]");

			using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdSelect.CommandText, conn))
			using (DataTable selectionTable = new DataTable("SelectionTable"))
			{
				adapter.Fill(selectionTable);
				_data.Tables[_tableMain].Merge(EnforceTable(selectionTable));
			}
			conn.Close();
		}

		private DataTable EnforceTable(DataTable table)
		{
			try
			{
				//provide unique column names to avoid conflicts
				table.Columns[0].ColumnName = System.Guid.NewGuid().ToString("N");
				table.Columns[1].ColumnName = System.Guid.NewGuid().ToString("N");
				table.Columns[2].ColumnName = System.Guid.NewGuid().ToString("N");
				//force column naming conventions to match the items table
				table.Columns[0].ColumnName = _colName;
				table.Columns[1].ColumnName = _colSerialNum;
				table.Columns[2].ColumnName = _colBarcode;
			} catch { /*do nothing*/ }
			return table;
		}

		private string GetFields(DataTable table)
		{
			string selection = null;
			using (ImportControlForm importCF = new ImportControlForm(table))
			{
				var result = importCF.ShowDialog();
				if (result == System.Windows.Forms.DialogResult.OK)
				{
					selection = $"{importCF.NameField}, {importCF.SerialNumField}, {importCF.BarcodeField}";
				}
			}
			return selection;
		}

		public DataTable GetItemsTable()
		{
			return _data.Tables[_tableMain];
		}
	}
}