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
		private DataModel _model;

        public DataForm(DataModel model)
        {
            InitializeComponent();
			_model = model;
            ItemGrid.AllowUserToResizeRows = false;
            ItemGrid.AllowUserToResizeColumns = false;
			ItemGrid.DataSource = _model.GetItemsTable();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
        }

		private void ProcessImport(string dataPath)
		{
			_model.LoadImport(dataPath);
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
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ItemGrid.SelectedRows)
            {
                if(row.Selected)
                {
					_model.RemoveAt(row.Index);
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

			_model.Add(name, serialNum, barcode);
			ItemGrid.FirstDisplayedScrollingRowIndex = ItemGrid.RowCount - 1;
		}

		private void AddBlanksButton_Click(object sender, EventArgs e)
		{
			int amount = Convert.ToInt32(BlanksUpDown.Value);
			for(int i = 0; i < amount; i++)
			{
				_model.Add("", "", "", 0);
			}
			ItemGrid.FirstDisplayedScrollingRowIndex = 0;
			BlanksUpDown.Value = 1;
		}

		private void DataForm_Close(object sender, FormClosedEventArgs e)
		{
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
