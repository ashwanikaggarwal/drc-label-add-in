using ADODB;
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
		public const string SET_MAIN = "data";
		public const string TABLE_MAIN = "items";

		public const string COL_NAME = "Name";
		public const string COL_SERIALNUM = "SerialNumber";
		public const string COL_BARCODE = "Barcode";

		private DataSet _data;
		private Recordset _rs;
		private Connection _conn;
		private OleDbDataAdapter _adapter;

		public DataModel()
		{
			_data = new DataSet(SET_MAIN);
			_data.Tables.Add(CreateItemsTable());

			_rs = new Recordset();
			_conn = new Connection();
			_adapter = new OleDbDataAdapter();
		}

		private DataTable CreateItemsTable()
		{
			DataTable table = new DataTable(TABLE_MAIN);
			table.Columns.Add(COL_NAME, typeof(string));
			table.Columns.Add(COL_SERIALNUM, typeof(string));
			table.Columns.Add(COL_BARCODE, typeof(string));
			return table;
		}

		public void LoadImport(string fileName)
		{
			string strDir = System.IO.Path.GetDirectoryName(fileName);
			string strFile = System.IO.Path.GetFileName(fileName);

			OleDbConnection conn = new OleDbConnection
			{
				ConnectionString = $"Provider=Microsoft.Jet.OleDb.4.0; Data Source = {strDir}; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";"
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
				_data.Tables[TABLE_MAIN].Merge(EnforceTable(selectionTable));
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
				table.Columns[0].ColumnName = COL_NAME;
				table.Columns[1].ColumnName = COL_SERIALNUM;
				table.Columns[2].ColumnName = COL_BARCODE;
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
					selection = importCF.NameField		+ ", " +
								importCF.SerialNumField + ", " +
								importCF.BarcodeField;
				}
			}
			return selection;
		}

		public DataTable GetItemsTable()
		{
			return _data.Tables["items"];
		}
	}
}