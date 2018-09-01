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

		public void ProcessXML(string xsdPath)
		{
			string dir = @"C:\Users\phill_000\Source\Repos\DRC.WordAddIn.BarcodeLabels\DRC.WordAddIn.BarcodeLabels\Templates";
			string xmlPath = Path.Combine(dir, "Label.xml");

			XmlReaderSettings settings = GetXMLReaderSettings(xsdPath);
			XmlDocument document = GetXMLDocument(xmlPath, settings);
			XmlNode labelNode = document.DocumentElement;

			LabelTemplate template = GetLabelTemplate(labelNode);
			//do something with the template
		}

		private LabelTemplate GetLabelTemplate(XmlNode labelNode)
		{
			LabelTemplate template = new LabelTemplate();

			//set template name
			template.Name = labelNode.Attributes["name"].Value;

			//set default status
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
				};
				settings.ValidationEventHandler += SchemaError;

				return settings;
			}
		}

		private XmlDocument GetXMLDocument(string xmlPath, XmlReaderSettings settings)
		{
			using (XmlReader reader = XmlReader.Create(xmlPath, settings))
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
			System.Windows.Forms.MessageBox.Show("XSD Validation Error: " + args.Message);
		}
	}
}
