using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
	public partial class ImportControlForm : Form
	{
		//user-selected indices of the headers array
		public string	NameField		{ get; private set; }
		public string	SerialNumField	{ get; private set; }
		public string	BarcodeField	{ get; private set; }
		public string[] Headers			{ get; private set; }

		public ImportControlForm(DataTable table)
		{
			InitializeComponent();
			List<string> headers = new List<string>();

			foreach(DataColumn column in table.Columns)
			{
				headers.Add(column.ColumnName);
			}
			Headers = headers.ToArray();

			//providing unique lists prevents every combobox from updating together
			NameCBox.DataSource			= new List<string>(Headers);
			SerialNumCBox.DataSource	= new List<string>(Headers);
			BarcodeCBox.DataSource		= new List<string>(Headers);

			AutoSelectDefaults();
		}

		private void ImportControlForm_Load(object sender, EventArgs e)
		{
		}

		private void AutoSelectDefaults()
		{
			int nameIndex				= Array.IndexOf(Headers, "Name"			);
			int serialNumIndex			= Array.IndexOf(Headers, "SerialNumber"	);
			int barcodeIndex			= Array.IndexOf(Headers, "Barcode"		);
			//if appropriate index not found, set default to 0
			NameCBox.SelectedIndex		= (nameIndex		>= 0)	? nameIndex			: 0;
			SerialNumCBox.SelectedIndex = (serialNumIndex	>= 0)	? serialNumIndex	: 0;
			BarcodeCBox.SelectedIndex	= (barcodeIndex		>= 0)	? barcodeIndex		: 0;
		}

		private void AcceptButton_Click(object sender, EventArgs e)
		{
			NameField		= NameCBox.SelectedText;
			SerialNumField	= SerialNumCBox.SelectedText;
			BarcodeField	= BarcodeCBox.SelectedText;

			Headers = new string[] { NameField, SerialNumField, BarcodeField };

			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
