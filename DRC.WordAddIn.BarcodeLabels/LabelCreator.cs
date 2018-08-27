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

		private Word.Document _doc;
		private string[] _fieldCodes;
		private object missing = System.Reflection.Missing.Value;

		public LabelCreator(Word.Document doc)
		{
			_doc = doc;
			_fieldCodes = new string[] {    @" MERGEFIELD Name ",
											@" MERGEFIELD SerialNumber \b "": "" ",
											"\v",
											@" MERGEBARCODE Barcode CODE128 " };
		}

		public void GenerateLabels()
		{
			_doc.MailMerge.MainDocumentType = WdMailMergeMainDocType.wdMailingLabels;
			_doc.Application.MailingLabel.LabelOptions();
			_doc.Tables[1].set_Style("Table Grid");
		}

		public void WriteFields()
		{
			Word.Range tableRange = _doc.Tables[1].Range;

			InsertIntoCell(tableRange.Cells[1], _fieldCodes);
			PropagrateLabel();
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

		private void PropagrateLabel()
		{
			object wordBasic = _doc.Application.GetType().InvokeMember("WordBasic",
																		System.Reflection.BindingFlags.GetProperty,
																		null, _doc.Application, null);

			wordBasic.GetType().InvokeMember("MailMergePropagateLabel",
												System.Reflection.BindingFlags.InvokeMethod,
												null, wordBasic, null);
		}
	}
}
