using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Office and Interop
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class LabelCreator
	{
		public const int FIELD_FONT_SIZE = 8;

		private Word.Application _app;

		private Word.Document ActiveDocument
		{
			get
			{
				return _app.ActiveDocument;
			}
		}

		public LabelCreator(Word.Application app)
		{
			_app = app;
		}

		public void GenerateLabels()
		{
			ActiveDocument.MailMerge.MainDocumentType = WdMailMergeMainDocType.wdMailingLabels;
			_app.MailingLabel.LabelOptions();
		}

		public bool HasLabels()
		{
			if(GetLabelsTable(false) != null)
			{
				return true;
			} else
			{
				return false;
			}
		}

		public Word.Table GetLabelsTable(bool resetMailMerge = true)
		{
			foreach (Word.Table table in ActiveDocument.Tables)
			{
				return table;
			}
			
			if(resetMailMerge)
			{
				ActiveDocument.MailMerge.MainDocumentType = WdMailMergeMainDocType.wdNotAMergeDocument;
			}
			return null;
		}

		public void WriteFields(Word.Table table)
		{
			if (table == null)
			{
				return;
			}
			
			ActiveDocument.ActiveWindow.View.TableGridlines = true;

			Word.Font defaultFont = new Word.Font
			{
				Size = 8
			};

			Word.Range cellRange = table.Cell(1, 1).Range;

			LabelTemplate template = new LabelTemplate(defaultFont, true);

			cellRange.Delete();
			template.WriteToRange(cellRange);
			UpdateLabels();
		}

		private void UpdateLabels()
		{
			object wordBasic = _app.GetType().InvokeMember(	"WordBasic",
															System.Reflection.BindingFlags.GetProperty,
															null, _app, null);
			//witchcraft?
			wordBasic.GetType().InvokeMember(	"MailMergePropagateLabel",
												System.Reflection.BindingFlags.InvokeMethod,
												null, wordBasic, null);
		}
	}
}
