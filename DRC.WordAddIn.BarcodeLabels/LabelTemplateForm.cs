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
		}

		private void PopulateList(string path)
		{
			string[] items = Directory.GetFiles(path, "*.xml", SearchOption.TopDirectoryOnly);
			TemplateListBox.DataSource = items;
		}

		private void ProcessXML()
		{
			string dir = @"C:\Users\phill_000\Source\Repos\DRC.WordAddIn.BarcodeLabels\DRC.WordAddIn.BarcodeLabels\Templates";
			string xmlPath = Path.Combine(dir, "Label.xml");
			string xsdPath = Path.Combine(dir, "Label.xsd");

			XmlReaderSettings settings = GetXMLReaderSettings(xsdPath);
			XmlDocument document = GetXMLDocument(xmlPath, settings);
			XmlNode labelNode = document.DocumentElement;

			LabelTemplate template = GetLabelTemplate(labelNode);

			MessageBox.Show(template.ToString());
		}

		private LabelTemplate GetLabelTemplate(XmlNode labelNode)
		{
			Microsoft.Office.Interop.Word.Font font = new Microsoft.Office.Interop.Word.Font
			{
				Size = 8
			}; //refactor LabelTemplate to not require a default font

			LabelTemplate template = new LabelTemplate(font, false);

			foreach (XmlNode itemNode in labelNode.ChildNodes)
			{
				ContentItem item = GetContentItem(itemNode);
				template.AddContent(item);
			}

			return template;
		}

		private ContentItem GetContentItem(XmlNode itemNode)
		{
			ContentItem item = new ContentItem();

			//set item type
			string strType = itemNode.Attributes["type"].Value;
			Enum.TryParse(strType, true, out ContentType type);
			item.Type = type;

			//set item text
			string strText = itemNode["text"].InnerText;
			item.Text = strText;

			//set item font size
			string strFontSize = itemNode["font"].Attributes["size"].Value;
			Int32.TryParse(strFontSize, out int fontSize);
			item.Font.Size = fontSize;

			return item;
		}

		private XmlReaderSettings GetXMLReaderSettings(string xsdPath)
		{
			using (FileStream xsdStream = File.OpenRead(xsdPath))
			{
				XmlSchema schema = XmlSchema.Read(xsdStream, SchemaError);

				XmlReaderSettings settings = new XmlReaderSettings
				{
					ValidationType = ValidationType.Schema,
				};
				settings.ValidationEventHandler += SchemaError;

				return settings;
			}
		}

		private XmlDocument GetXMLDocument(string xmlPath, XmlReaderSettings settings)
		{
			using(XmlReader reader = XmlReader.Create(xmlPath, settings))
			{
				XmlDocument document = new XmlDocument
				{
					//PreserveWhitespace = true
				};

				document.Load(reader);
				return document;
			}
		}

		private void SchemaError(object sender, ValidationEventArgs args)
		{
			MessageBox.Show("XSD Validation Error: " + args.Message);
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
				string dir = fileDialog.SelectedPath;
				PopulateList(dir);
			}
		}

		private void ReadLabelButton_Click(object sender, EventArgs e)
		{
			try
			{
				ProcessXML();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}