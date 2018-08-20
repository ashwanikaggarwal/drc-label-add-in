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
		private Recordset _rs;
		private Connection _conn;
		private OleDbDataAdapter _adapter;

		public DataModel()
		{
			_rs = new Recordset();
			_conn = new Connection();
			_adapter = new OleDbDataAdapter();
		}

		public void ImportData(string strFileName, string[] fields)
		{
			/*ADODB.Connection oConn = new ADODB.Connection();
			oConn.Open(	"Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + System.IO.Path.GetDirectoryName(strFileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";",
						"",
						"",
						0);*/
			
			string strQuery;
			if (fields == null)
			{
				strQuery = "SELECT * FROM [" + System.IO.Path.GetFileName(strFileName) + "]";
			} else
			{
				strQuery = "SELECT * FROM [" + System.IO.Path.GetFileName(strFileName) + "]";
			}

			string strConnection = "Provider=Microsoft.Jet.OleDb.4.0; Data Source = " +
									System.IO.Path.GetDirectoryName(strFileName) +
									"; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";";

			_rs.Open(	strQuery,
						strConnection,
						ADODB.CursorTypeEnum.adOpenForwardOnly,
						ADODB.LockTypeEnum.adLockReadOnly,
						1);
		}

		public DataTable GetDataTable()
		{
			DataTable table = new DataTable();
			_adapter.Fill(table, _rs);
			return table;
		}
	}
}