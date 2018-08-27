using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
    public partial class AddInRibbon
    {
		private DocumentController _controller;

        private void AddInRibbon_Load(object sender, RibbonUIEventArgs e)
        {
			_controller = new DocumentController(Globals.ThisAddIn.Application);
		}

		private void HandleResult(string result)
		{
			if (!result.Equals("OK"))
			{
				MessageBox.Show(result);
			}
		}

		private void DataButton_Click(object sender, RibbonControlEventArgs e)
		{
			_controller.DataForm.Show();
		}

        private void CreateLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
			HandleResult(_controller.CreateLabels());
		}

		private void ExecuteButton_Click(object sender, RibbonControlEventArgs e)
		{
			HandleResult(_controller.FinishLabels());
		}

		private void StatusButton_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.DisplayStatus();
		}

		private void ToggleButton_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.Application.ActiveDocument.Fields.ToggleShowCodes();
		}
	}
}
