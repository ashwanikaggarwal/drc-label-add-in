//Office and Interop
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class LabelWriter
	{
		private Word.Application _app;

        public bool HasLabels
        {
            get
            {
                return (GetLabelsTable(false) != null);
            }
        }

        public Word.Document ActiveDocument
		{
			get
			{
				return _app.ActiveDocument;
			}
		}

		public LabelWriter(Word.Application app)
		{
			_app = app;
		}

		public void GenerateLabels()
		{
			ActiveDocument.MailMerge.MainDocumentType = WdMailMergeMainDocType.wdMailingLabels;
			_app.MailingLabel.LabelOptions();
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

		public void WriteLabel(Word.Table table, LabelTemplate template)
		{
			if (table == null)
			{
				return;
			}
			
			ActiveDocument.ActiveWindow.View.TableGridlines = true;

			Word.Range cellRange = table.Cell(1, 1).Range;

			cellRange.Delete();
			template.WriteToRange(cellRange);
			UpdateLabels();
		}

		public void UpdateLabels()
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
