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
        private void AddInRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void CreateLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.OpenLabels("datasource.csv");
        }

        private void ViewLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
            DataForm viewForm = new DataForm();
            viewForm.Show();
        }

        private void ImportDataButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ImportData();
        }

        private void StatusButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.DisplayStatus();
        }
    }
}
