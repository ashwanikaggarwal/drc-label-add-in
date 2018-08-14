using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void CreateLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.OpenLabels();
        }

        private void ViewLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
            DataForm viewForm = new DataForm();
            viewForm.Show();
        }
    }
}
