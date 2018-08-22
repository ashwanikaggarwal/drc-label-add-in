﻿using ADODB;
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
		private DataTable _items;

		private Recordset _rs;
		private Connection _conn;
		private OleDbDataAdapter _adapter;

		public DataModel()
		{
			_data = new DataSet("data");
			_items = new DataTable("items");
			_data.Tables.Add(_items);

			_rs = new Recordset();
			_conn = new Connection();
			_adapter = new OleDbDataAdapter();
		}

		public void LoadImport(string strFileName)
		{
			_conn.Open(	"Provider=Microsoft.Jet.OleDb.4.0; Data Source = " +
						System.IO.Path.GetDirectoryName(strFileName) +
						"; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";",
						"",
						"",
						0);

			string queryAll = "SELECT * FROM [" + System.IO.Path.GetFileName(strFileName) + "]";

			_rs.Open(	queryAll,
						_conn,
						CursorTypeEnum.adOpenForwardOnly,
						LockTypeEnum.adLockReadOnly,
						-1);

			DataTable fullTable = new DataTable();
			_adapter.Fill(fullTable, _rs);
			string strFields = GetFields(fullTable);

			string queryFields = "SELECT " + strFields + " FROM [" + System.IO.Path.GetFileName(strFileName) + "]";

			_rs.Close();
			_rs.Open(	queryFields,
						_conn,
						CursorTypeEnum.adOpenForwardOnly,
						LockTypeEnum.adLockReadOnly,
						-1);

			_adapter.Fill(_items, _rs);
			_conn.Close();
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
			return _items;
		}
	}
}