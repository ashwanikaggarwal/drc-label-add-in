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
		private DataModel _model;
		private LabelMerger _merger;

        private void AddInRibbon_Load(object sender, RibbonUIEventArgs e)
        {
			_model = new DataModel();
			ExecuteButton.Enabled = false;
		}

		private void DataButton_Click(object sender, RibbonControlEventArgs e)
		{
			DataForm viewForm = new DataForm(_model);
			viewForm.Show();
		}

        private void CreateLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
			try
			{
				_merger = new LabelMerger(_model, Globals.ThisAddIn.Application.ActiveDocument.MailMerge);
				_merger.GenerateLabels();
				_merger.WriteFields();

				ExecuteButton.Enabled = true;
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ExecuteButton_Click(object sender, RibbonControlEventArgs e)
		{
			_merger.Execute();
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
