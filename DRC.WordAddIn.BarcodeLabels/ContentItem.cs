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
		RangeText, Field, LineBreak
	}

	public class ContentItem
	{
		public ContentType Type { get; set; }
		public string Text { get; set; }
		public Word.Font Font { get; set; }

		public ContentItem()
		{
			Font = new Word.Font();
		}

		public ContentItem(ContentType type, string text, Word.Font font)
		{
			Type = type;
			Text = text;
			Font = font;
		}

		public override string ToString()
		{
			return $"{Type.ToString()}: {Text}; Font Size {Font.Size}";
		}
	}
}
