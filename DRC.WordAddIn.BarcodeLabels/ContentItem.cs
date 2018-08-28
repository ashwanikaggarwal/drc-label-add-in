using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Office and Interop
using Word = Microsoft.Office.Interop.Word;

namespace DRC.WordAddIn.BarcodeLabels
{
	public enum ContentType
	{
		Field, RangeText
	}

	public class ContentItem
	{
		public ContentType Type { get; private set; }
		public string Text { get; private set; }
		public Word.Font Font { get; private set; }

		public ContentItem(ContentType type, string text, Word.Font font)
		{
			Type = type;
			Text = text;
			Font = font;
		}
	}
}
