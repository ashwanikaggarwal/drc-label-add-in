using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class XMLLabelParser
	{
		public string SchemaPath { get; set; }

		private XmlReaderSettings _settings;

		public XMLLabelParser()
		{
			string labelDir = Properties.Settings.Default.LabelDirectory;
			SchemaPath = Path.Combine(labelDir, "Label.xsd");
			_settings = GetReaderSettings();
		}
		
		public List<LabelTemplate> ProcessDirectory(string dir)
		{
			List<LabelTemplate> templates = new List<LabelTemplate>();

			string[] xmlFiles = Directory.GetFiles(dir, "*.xml", SearchOption.TopDirectoryOnly);

			foreach (string xmlPath in xmlFiles)
			{
				templates.AddRange(ProcessXML(xmlPath));
			}
			return templates;
		}

		public List<LabelTemplate> ProcessXML(string xmlPath)
		{
			List<LabelTemplate> templates = new List<LabelTemplate>();
			XmlDocument document = GetXMLDocument(xmlPath);

			if (document == null)
			{
				return templates;
			}

			XmlNode rootNode = document.DocumentElement;

			foreach (XmlNode labelNode in rootNode.ChildNodes)
			{
				LabelTemplate label = GetLabelTemplate(labelNode);
				templates.Add(label);
			}

			return templates;
		}

		private XmlDocument GetXMLDocument(string xmlPath)
		{
			XmlDocument document = new XmlDocument
			{
				Schemas = _settings.Schemas
			};

			if (document.Schemas.Count < 1)
			{
				return null; //document cannot be validated without a schema
			}

			document.Load(xmlPath);

			try
			{
				document.Validate(null);
			} catch (XmlSchemaValidationException)
			{
				string validationErrorMessage = $"The label file \"{Path.GetFileName(xmlPath)}\"" +
												$"is invalid and will be ignored.";
				System.Windows.Forms.MessageBox.Show(validationErrorMessage);
				return null; //invalid document
			}

			return document;
		}

		private LabelTemplate GetLabelTemplate(XmlNode labelNode)
		{
			LabelTemplate template = new LabelTemplate
			{
				Name = labelNode.Attributes["name"].Value
			};

			string strDefault = labelNode.Attributes["default"].Value;
			if (strDefault != null)
			{
				Boolean.TryParse(strDefault, out bool isDefault);
				template.Default = isDefault;
			}

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

		private XmlReaderSettings GetReaderSettings()
		{
			XmlReaderSettings settings = new XmlReaderSettings
			{
				ValidationType = ValidationType.Schema,
				ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings
			};

			try
			{
				using (FileStream schemaStream = File.Open(SchemaPath, FileMode.Open, FileAccess.Read))
				{
					XmlSchema schema = XmlSchema.Read(schemaStream, null);
					settings.Schemas.Add(schema);
				}
			} catch (XmlException)
			{
				string schemaErrorMessage = $"The file that validates labels \"{Path.GetFileName(SchemaPath)}\" is broken." +
											$"\n" +
											$"You may need to reinstall the add-in or download a working schema file.";
				System.Windows.Forms.MessageBox.Show(schemaErrorMessage);
			}
			return settings;
		}
	}
}
