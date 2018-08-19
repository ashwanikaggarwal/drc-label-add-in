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
		public int NameIndex		{ get; set; }
		public int SerialNumIndex	{ get; set; }
		public int BarcodeIndex		{ get; set; }

		private string[] _headers;

		public ImportControlForm(string[] headers)
		{
			InitializeComponent();
			_headers = headers;
		}

		private void ImportControlForm_Load(object sender, EventArgs e)
		{
			//comboboxes sharing a common datasource will update simultaneously
			NameCBox.DataSource			= new List<string>(_headers);
			SerialNumCBox.DataSource	= new List<string>(_headers);
			BarcodeCBox.DataSource		= new List<string>(_headers);
			AutoSelectDefaults();
		}

		private void AutoSelectDefaults()
		{
			int nameIndex = Array.IndexOf(_headers, "Name");
			int serialNumIndex = Array.IndexOf(_headers, "SerialNumber");
			int barcodeIndex = Array.IndexOf(_headers, "Barcode");
			//if appropriate index not found, set default to 0
			NameCBox.SelectedIndex		= (nameIndex		>= 0)	? nameIndex			: 0;
			SerialNumCBox.SelectedIndex = (serialNumIndex	>= 0)	? serialNumIndex	: 0;
			BarcodeCBox.SelectedIndex	= (barcodeIndex		>= 0)	? barcodeIndex		: 0;
		}

		private void AcceptButton_Click(object sender, EventArgs e)
		{
			NameIndex = NameCBox.SelectedIndex;
			SerialNumIndex = SerialNumCBox.SelectedIndex;
			BarcodeIndex = BarcodeCBox.SelectedIndex;

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
