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
		public List<ContentItem> Contents { get; set; }

		public string Name { get; set; }

		public bool Default { get; set; } = false;

		public LabelTemplate()
		{
			Contents = new List<ContentItem>();
		}

		public void WriteToRange(Word.Range fullRange)
		{
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

					case ContentType.LineBreak:
						rangeCursor.InsertBreak(Word.WdBreakType.wdLineBreak);

						rangeCursor.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
						break;
				}
		}

		public void AddContent(ContentItem content)
		{
			Contents.Add(content);
		}

		public void AddContent(ContentType type, string text, Word.Font font)
		{
			AddContent(new ContentItem(type, text, font));
		}

		public override string ToString()
		{
            return Name;
		}
	}
}
