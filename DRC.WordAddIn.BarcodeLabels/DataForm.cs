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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.ImportData();
            ReloadBind();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell cell in ItemGrid.SelectedCells)
            {
                if(cell.Selected)
                {
                    int index = cell.RowIndex;
                    Globals.ThisAddIn.ItemsList.RemoveAt(index);
                    ItemGrid.Rows.RemoveAt(index);
                    ReloadBind();
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
