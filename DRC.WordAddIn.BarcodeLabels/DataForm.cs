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
		private ItemCache _items;

        public DataForm(ItemCache items)
        {
			_items = items;
            InitializeComponent();
			ItemGrid.DataSource = _items.GetSource();
            ItemGrid.AllowUserToResizeRows = false;
            ItemGrid.AllowUserToResizeColumns = false;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
			string dataPath = Globals.ThisAddIn.GetDataFile();
			if(String.IsNullOrWhiteSpace(dataPath))
			{
				return;
			}

			_items.ImportCSVData(new CSVData(dataPath), 0, 2, 9);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ItemGrid.SelectedRows)
            {
                if(row.Selected)
                {
					_items.RemoveAt(row.Index);
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

			Item newItem = new Item(name, serialNum, barcode);

			_items.Insert(0, newItem);
			ValueControlTable.Refresh();
		}

		private void AddBlanksButton_Click(object sender, EventArgs e)
		{
			int amount = Convert.ToInt32(BlanksUpDown.Value);
			for(int i = 0; i < amount; i++)
			{
				Item blankItem = new Item("", "", "", false);
				_items.Insert(0, blankItem);
			}
			BlanksUpDown.Value = 1;
		}

		private void ValueControlTable_Paint(object sender, PaintEventArgs e)
        {
			
        }

		private void ItemGrid_Paint(object sender, PaintEventArgs e)
		{
			foreach (DataGridViewRow row in ItemGrid.Rows)
			{
				row.DefaultCellStyle.BackColor = _items.Get(row.Index).ColorCode;
			}
		}

		private void ItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
