using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
    public partial class AddInRibbon
    {
		private ItemCache _items;

        private void AddInRibbon_Load(object sender, RibbonUIEventArgs e)
        {
			_items = new ItemCache();
        }

        private void CreateLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.OpenLabels("datasource.csv");
        }

        private void ViewLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
            DataForm viewForm = new DataForm(_items);
            viewForm.Show();
        }

        private void StatusButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.DisplayStatus();
        }
    }
}
