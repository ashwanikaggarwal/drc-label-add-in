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
		public List<LabelTemplate> Labels { get; private set; }

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

		public LabelModel()
		{
			Labels = new List<LabelTemplate>();
		}

		public void ProcessDirectory(string dir, string xsdPath)
		{
			string[] xmlFiles = Directory.GetFiles(dir, "*.xml", SearchOption.TopDirectoryOnly);

			XmlReaderSettings settings = GetXMLReaderSettings(xsdPath);

			foreach (string xmlPath in xmlFiles)
			{
				List<LabelTemplate> templates = ProcessXML(xmlPath, settings);
				Labels.AddRange(templates);
			}
		}

		public List<LabelTemplate> ProcessXML(string xmlPath, XmlReaderSettings settings)
		{
			List<LabelTemplate> templates = new List<LabelTemplate>();
			XmlDocument document = GetXMLDocument(xmlPath, settings);

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

		private XmlReaderSettings GetXMLReaderSettings(string xsdPath)
		{
			using (FileStream xsdStream = File.OpenRead(xsdPath))
			{
				XmlSchema schema = XmlSchema.Read(xsdStream, SchemaError);

				XmlReaderSettings settings = new XmlReaderSettings
				{
					ValidationType = ValidationType.Schema,
					ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings
				};
				settings.Schemas.Add(schema);
				settings.ValidationEventHandler += SchemaError;
				return settings;
			}
		}

		private XmlDocument GetXMLDocument(string xmlPath, XmlReaderSettings settings)
		{
			try
			{
				using (XmlReader reader = XmlReader.Create(xmlPath, settings))
				{
					XmlDocument document = new XmlDocument();
					document.Load(reader);
					document.Validate(SchemaError);
					return document;
				}
			} catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
				return null;
			}
		}

		private void SchemaError(object sender, ValidationEventArgs args)
		{
			System.Windows.Forms.MessageBox.Show($"SENDER: {sender.ToString()}\nMESSAGE: {args.Message}");
		}
	}
}
