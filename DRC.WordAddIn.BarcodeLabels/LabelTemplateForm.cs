using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Schema;
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
			DirTextBox.Text = Properties.Settings.Default.LabelDirectory;
		}

		private void PopulateList(string dir)
		{
			try
			{
				string xsdPath = Path.Combine(dir, "Label.xsd");
				LabelModel model = new LabelModel(xsdPath);

				model.ProcessDirectory(dir);

				foreach(LabelTemplate template in model.Labels)
				{
					TemplateListBox.Items.Add(template.Name);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
			}
		}

		private void SelectDirLabel_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderDialog = new FolderBrowserDialog
			{
				RootFolder = Environment.SpecialFolder.MyComputer,
				ShowNewFolderButton = false
			};

			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				DirTextBox.Text = folderDialog.SelectedPath;
			}
		}

		private void ReadLabelButton_Click(object sender, EventArgs e)
		{
			string dir = DirTextBox.Text;

			if(Directory.Exists(dir))
			{
				PopulateList(dir);
			} else
			{
				MessageBox.Show("The selected folder does not exist or was mistyped.");
			}
		}

		private void TemplateListBox_DoubleClick(object sender, EventArgs e)
		{
			ListBox box = (ListBox)sender;
			if (box.SelectedItem == null)
				return;

			MessageBox.Show(box.SelectedItem.ToString());
		}
	}
}