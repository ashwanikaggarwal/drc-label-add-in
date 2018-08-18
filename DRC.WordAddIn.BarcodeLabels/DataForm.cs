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
        private BindingSource itemSource;

        public DataForm()
        {
            InitializeComponent();
            ItemGrid.AllowUserToResizeRows = false;
            ItemGrid.AllowUserToResizeColumns = false;
            ReloadBind();
        }

        public void ReloadBind()
        {
            BindingList<Item> bindingItems = new BindingList<Item>(Globals.ThisAddIn.ItemsList);
            itemSource = new BindingSource(bindingItems, null);
            ItemGrid.DataSource = itemSource;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.ImportData();
            ReloadBind();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ItemGrid.SelectedRows)
            {
                if(row.Selected)
                {
                    int index = row.Index;
                    Globals.ThisAddIn.ItemsList.RemoveAt(index);
                }
            }
			ReloadBind();
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

			Globals.ThisAddIn.ItemsList.Insert(0, newItem);
			ReloadBind();
			ValueControlTable.Refresh();
		}

		private void AddBlanksButton_Click(object sender, EventArgs e)
		{
			int amount = Convert.ToInt32(BlanksUpDown.Value);
			for(int i = 0; i < amount; i++)
			{
				Item blankItem = new Item("", "", "", false);
				Globals.ThisAddIn.ItemsList.Insert(0, blankItem);
			}
			ReloadBind();
			BlanksUpDown.Value = 1;
		}

		private void ValueControlTable_Paint(object sender, PaintEventArgs e)
        {
			
        }

		private void ItemGrid_Paint(object sender, PaintEventArgs e)
		{
			foreach (DataGridViewRow row in ItemGrid.Rows)
			{
				row.DefaultCellStyle.BackColor = Globals.ThisAddIn.ItemsList[row.Index].ColorCode;
			}
		}

		private void ItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
