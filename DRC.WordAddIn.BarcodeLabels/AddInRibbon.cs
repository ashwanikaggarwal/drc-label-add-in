﻿using Microsoft.Office.Tools.Ribbon;
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

		private void HandleResult(ControllerResult result)
		{
			switch(result)
			{
				case ControllerResult.Success:
					//everything is fine
					break;

				case ControllerResult.Nothing:
					//no error happened, the user just wanted nothing to happen
					break;

				case ControllerResult.Failure:
					MessageBox.Show("The add-in has run into an unexpected error.");
					break;

				case ControllerResult.SilentFailure:
					//keep the error invisible, maybe report it
					break;
					
				case ControllerResult.EmptyData:
					MessageBox.Show("Please add data by selecting \"Manage Data\".");
					break;

				case ControllerResult.NoLabels:
					MessageBox.Show("Please choose a label style by selecting \"Create Labels\".");
					break;
					
				default:
					MessageBox.Show($"\"{result.ToString()}\" is an unimplemented result case.");
					break;
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

		private void TemplateButton_Click(object sender, RibbonControlEventArgs e)
		{
			_controller.TemplateForm.Show();
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
