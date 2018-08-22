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
		private DataSet _data;
		private Recordset _rs;
		private Connection _conn;
		private OleDbDataAdapter _adapter;

		public DataModel()
		{
			_data = new DataSet("data");
			_data.Tables.Add(CreateItemsTable());

			_rs = new Recordset();
			_conn = new Connection();
			_adapter = new OleDbDataAdapter();
		}

		private DataTable CreateItemsTable()
		{
			DataTable table = new DataTable("items");
			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("SerialNumber", typeof(string));
			table.Columns.Add("Barcode", typeof(string));
			return table;
		}

		public void LoadImport(string fileName)
		{
			DataTable items = _data.Tables["items"];
			string strDir = System.IO.Path.GetDirectoryName(fileName);
			string strFile = System.IO.Path.GetFileName(fileName);

			OleDbConnection conn = new OleDbConnection
			{
				ConnectionString = $"Provider=Microsoft.Jet.OleDb.4.0; Data Source = {strDir}; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";"
			};
			conn.Open();

			OleDbCommand cmdSelectAll = new OleDbCommand($"SELECT * FROM [{strFile}]");

			string selection;
			using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdSelectAll.CommandText, conn))
			using (DataTable importTable = new DataTable("ImportTable"))
			{
				adapter.Fill(importTable);
				selection = GetFields(importTable);
			}

			string itemCols = $"{items.Columns[0].ColumnName}, {items.Columns[1].ColumnName}, {items.Columns[2].ColumnName}";
			
			//table name for "insert into" is the problem here
			OleDbCommand cmdInsertInto = new OleDbCommand($"INSERT INTO [{items.TableName}] ({itemCols}) SELECT {selection} FROM [{strFile}]", conn);

			using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdInsertInto.CommandText, conn))
			{
				//FIND A WAY TO FILL THE ITEMS TABLE
			}
			conn.Close();
		}

		private string GetFields(DataTable table)
		{
			string selection = "*";
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