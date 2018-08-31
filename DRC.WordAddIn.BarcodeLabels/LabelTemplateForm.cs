using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
	public partial class LabelTemplateForm : Form
	{
		public LabelTemplateForm()
		{
			InitializeComponent();
		}

		private void PopulateList(string path)
		{
			string[] items = Directory.GetFiles(path, "*.xml", SearchOption.TopDirectoryOnly);
			TemplateListBox.DataSource = items;
		}

		private void SelectDirLabel_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fileDialog = new FolderBrowserDialog
			{
				RootFolder = Environment.SpecialFolder.MyComputer,
				ShowNewFolderButton = false
			};

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				PopulateList(fileDialog.SelectedPath);
			}
		}
	}
}
