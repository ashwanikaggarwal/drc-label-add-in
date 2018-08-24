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
		private DataModel _model;
		private LabelMerger _merger;

		private void SetupMerger()
		{
			if(_merger == null)
			{
				try
				{
					Microsoft.Office.Interop.Word.Application app = Globals.ThisAddIn.Application;
					_merger = new LabelMerger(_model, app, app.ActiveDocument);
				} catch(Exception e)
				{
					MessageBox.Show(e.Message);
				}
			}
		}

        private void AddInRibbon_Load(object sender, RibbonUIEventArgs e)
        {
			_model = new DataModel();
		}

		private void DataButton_Click(object sender, RibbonControlEventArgs e)
		{
			DataForm viewForm = new DataForm(_model);
			viewForm.Show();
		}

        private void CreateLabelsButton_Click(object sender, RibbonControlEventArgs e)
        {
			SetupMerger();
			_merger.GenerateLabels();
        }
		
		private void UpdateButton_Click(object sender, RibbonControlEventArgs e)
		{
			SetupMerger();
			try
			{
				_merger.UpdateLabels();
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void StatusButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.DisplayStatus();
        }
    }
}
