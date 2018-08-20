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
    public partial class DataForm : Form
    {
		private DataCache _data;
		private DataModel _model;

        public DataForm(DataCache items)
        {
			_data = items;
            InitializeComponent();
			//ItemGrid.DataSource = _data.GetSource();
			_model = new DataModel();
            ItemGrid.AllowUserToResizeRows = false;
            ItemGrid.AllowUserToResizeColumns = false;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
        }

		private void ProcessImport(string dataPath)
		{
			_model.ImportData(dataPath, null);

			ImportControlForm importCF = new ImportControlForm(_model.GetDataTable());
			DialogResult result = importCF.ShowDialog();

			if (result == DialogResult.OK)
			{
				_model.ImportData(dataPath, importCF.Headers);
			}
		}

		private void ImportButton_Click(object sender, EventArgs e)
		{
			string dataPath = null;

			try
			{
				OpenFileDialog fileDialog = new OpenFileDialog
				{
					Filter = "CSV files (*.csv)|*.csv",
					ValidateNames = true
				};

				if (fileDialog.ShowDialog() == DialogResult.OK)
					dataPath = fileDialog.FileName;
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			if (String.IsNullOrWhiteSpace(dataPath))
				return;

			ProcessImport(dataPath);
			ItemGrid.DataSource = _model.GetDataTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ItemGrid.SelectedRows)
            {
                if(row.Selected)
                {
					_data.RemoveAt(row.Index);
                }
            }
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string name = NameTextBox.Text;
			string serialNum = SerialNumTextBox.Text;
			string barcode = BarcodeTextBox.Text;

			if(	String.IsNullOrWhiteSpace(name) &&
				String.IsNullOrWhiteSpace(serialNum) &&
				String.IsNullOrWhiteSpace(barcode))
			{
				MessageBox.Show("At least one field must have content.");
				return;
			}

			//add to recordset
		}

		private void AddBlanksButton_Click(object sender, EventArgs e)
		{
			int amount = Convert.ToInt32(BlanksUpDown.Value);
			for(int i = 0; i < amount; i++)
			{
				//add blanks to recordset
			}
			BlanksUpDown.Value = 1;
		}

		private void ValueControlTable_Paint(object sender, PaintEventArgs e)
        {
        }

		private void ItemGrid_Paint(object sender, PaintEventArgs e)
		{
		}

		private void ItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
