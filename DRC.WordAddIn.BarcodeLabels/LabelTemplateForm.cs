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
		private LabelModel _labelModel;

		public LabelTemplateForm(LabelModel labelModel)
		{
			InitializeComponent();
			_labelModel = labelModel;
            PopulateList();
        }

		private void PopulateList()
		{
            TemplateListBox.BeginUpdate();
            foreach (LabelTemplate template in _labelModel.Labels)
            {
                TemplateListBox.Items.Add(template);
            }
            TemplateListBox.EndUpdate();

            TemplateListBox.SelectedItem = _labelModel.CurrentLabel;
		}

        private void SelectTemplate()
        {
            if (TemplateListBox.SelectedItem == null)
                return;

            _labelModel.CurrentLabel = (LabelTemplate) TemplateListBox.SelectedItem;
            this.Close();
        }

		private void TemplateListBox_DoubleClick(object sender, EventArgs e)
		{
            SelectTemplate();
		}

        private void OKButton_Click(object sender, EventArgs e)
        {
            SelectTemplate();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}