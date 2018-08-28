using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Office and Interop
using Word = Microsoft.Office.Interop.Word;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class LabelTemplate
	{
		public List<ContentItem> Contents { get; private set; }

		public Word.Font DefaultFont { get; private set; } = new Word.Font
		{
			Size = 8
		};

		public LabelTemplate(bool useDefaults = true)
		{
			Contents = new List<ContentItem>();

			if (useDefaults)
			{
				SetupDefaultContents();
			}
		}

		public LabelTemplate(Word.Font defaultFont, bool useDefaults = true) : this(useDefaults)
		{
			DefaultFont = defaultFont;
		}

		public void WriteToRange(Word.Range fullRange)
		{
			fullRange.Font = DefaultFont;

			Word.Range rangeCursor = fullRange;
			rangeCursor.Collapse(Word.WdCollapseDirection.wdCollapseStart);

			foreach(ContentItem item in Contents)
				switch(item.Type)
				{
					case ContentType.Field:
						Word.Field field = fullRange.Fields.Add(rangeCursor);
						field.Code.Text = item.Text;
						field.Code.Font = item.Font;

						rangeCursor = field.Result;
						rangeCursor.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
						break;

					case ContentType.RangeText:
						rangeCursor.Text = item.Text;
						rangeCursor.Font = item.Font;

						rangeCursor.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
						break;
				}
		}

		public void AddContent(ContentItem content)
		{
			Contents.Add(content);
		}

		public void AddContent(ContentType type, string text)
		{
			AddContent(new ContentItem(type, text, DefaultFont));
		}

		public void AddContent(ContentType type, string text, Word.Font font)
		{
			AddContent(new ContentItem(type, text, font));
		}

		private void SetupDefaultContents()
		{
			Contents.Clear();

			AddContent(	ContentType.Field,
						@" MERGEFIELD Name ");

			AddContent(	ContentType.Field,
						@" MERGEFIELD SerialNumber \b "": "" ");

			AddContent(	ContentType.RangeText,
						"\vbeep\v");

			AddContent(	ContentType.Field,
						@" MERGEBARCODE Barcode CODE128 ");
		}
	}
}
