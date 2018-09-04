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
	class LabelModel
	{
		public List<LabelTemplate> Labels { get; set; }

		public string SchemaPath { get; set; }
		private XmlReaderSettings _settings; //phase this out

		public LabelTemplate DefaultLabel
		{
			get
			{
				foreach (LabelTemplate label in Labels)
					if (label.Default) //check if label is default
						return label;
				return Labels[0] ?? null;
			}
		}

		public LabelModel(string schemaPath)
		{
			Labels = new List<LabelTemplate>();
			SchemaPath = schemaPath;

			_settings = GetReaderSettings();
		}
		
		public void ProcessDirectory(string dir)
		{
			string[] xmlFiles = Directory.GetFiles(dir, "*.xml", SearchOption.TopDirectoryOnly);

			foreach (string xmlPath in xmlFiles)
			{
				List<LabelTemplate> templates = ProcessXML(xmlPath);
				Labels.AddRange(templates);
			}
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

			document.Load(xmlPath);

			try
			{
				document.Validate(null);
			} catch (XmlSchemaValidationException)
			{
				System.Windows.Forms.MessageBox.Show($"The label file \"{Path.GetFileName(xmlPath)}\" is invalid and will be ignored.");
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

			using (FileStream stream = File.Open(SchemaPath, FileMode.Open, FileAccess.Read))
			{
				XmlSchema schema = XmlSchema.Read(stream, SchemaError);
				settings.Schemas.Add(schema);
			}
			return settings;
		}

		private void SchemaError(object sender, ValidationEventArgs args)
		{
			System.Windows.Forms.MessageBox.Show($"SCHEMA READ ERROR\nSENDER: {sender.ToString()}\nMESSAGE: {args.Message}");
			//try to remove
		}

		private void XMLDocumentError(object sender, ValidationEventArgs args)
		{
			System.Windows.Forms.MessageBox.Show($"XML DOCUMENT INVALID\nSENDER: {sender.ToString()}\nMESSAGE: {args.Message}");
		}
	}
}
