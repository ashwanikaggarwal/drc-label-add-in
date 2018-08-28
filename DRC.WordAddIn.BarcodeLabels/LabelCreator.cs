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
		private string[] _fieldCodes;
		private object missing = System.Reflection.Missing.Value;

		public Word.Document ActiveDocument
		{
			get
			{
				return _app.ActiveDocument;
			}
		}

		public LabelCreator(Word.Application app)
		{
			_app = app;
			_fieldCodes = new string[] {    @" MERGEFIELD Name ",
											@" MERGEFIELD SerialNumber \b "": "" ",
											"\v",
											@" MERGEBARCODE Barcode CODE128 " };
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

			table.set_Style("Table Grid"); //remove after testing

			InsertIntoCell(table.Range.Cells[1], _fieldCodes);
			UpdateLabels();
		}

		private void InsertIntoCell(Word.Cell cell, string[] fieldCodes)
		{
			cell.Range.Delete();
			Word.Range range = cell.Range;

			range.Collapse(WdCollapseDirection.wdCollapseStart);

			foreach (string fieldCode in fieldCodes)
			{
				if (fieldCode.Equals("\v"))
				{
					range.Text = fieldCode;
					range.Move(WdUnits.wdCharacter, 1);
					continue;
				}

				Word.Field field = cell.Range.Fields.Add(range, missing, missing, missing);
				field.Code.Text = fieldCode;

				range = field.Result;
				range.Collapse(WdCollapseDirection.wdCollapseEnd);
			}

			cell.Range.Font.Size = FIELD_FONT_SIZE;
			cell.Range.Fields.Update();
		}

		private void UpdateLabels()
		{
			object wordBasic = _app.GetType().InvokeMember("WordBasic",
																		System.Reflection.BindingFlags.GetProperty,
																		null, _app, null);
			//witchcraft?
			wordBasic.GetType().InvokeMember(	"MailMergePropagateLabel",
												System.Reflection.BindingFlags.InvokeMethod,
												null, wordBasic, null);
		}
	}
}
