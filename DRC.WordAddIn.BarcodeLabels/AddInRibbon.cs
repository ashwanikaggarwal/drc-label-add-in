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
		private LabelMerger _merger;

        private void AddInRibbon_Load(object sender, RibbonUIEventArgs e)
        {
			_items = new ItemCache();
			UpdateButton.Enabled = false;
        }

        private void CreateLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
			_merger = new LabelMerger(_items);
			_merger.GenerateLabels();
			if(!_items.IsEmpty())
			{
				UpdateButton.Enabled = true;
			}
        }

        private void DataButton_Click(object sender, RibbonControlEventArgs e)
        {
            DataForm viewForm = new DataForm(_items);
            viewForm.Show();
        }

		private void UpdateButton_Click(object sender, RibbonControlEventArgs e)
		{
			_merger.UpdateLabels();
		}

        private void StatusButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.DisplayStatus();
        }
    }
}
