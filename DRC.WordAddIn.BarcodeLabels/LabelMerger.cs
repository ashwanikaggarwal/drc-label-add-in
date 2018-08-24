using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class LabelMerger
	{
		private DataModel _model;
		private Word.MailMerge _mailMerge;

		private object missing = System.Reflection.Missing.Value;

		public LabelMerger(DataModel model, Word.MailMerge mailMerge)
		{
			_model = model;
			_mailMerge = mailMerge;
		}

		public void GenerateLabels()
		{
			try
			{
				_mailMerge.MainDocumentType = WdMailMergeMainDocType.wdMailingLabels;
				_mailMerge.Application.MailingLabel.LabelOptions();
				_mailMerge.Application.ActiveDocument.Tables[1].set_Style("Table Grid");
			} catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void AddFields()
		{
			string[] fieldText = {  @"MERGEFIELD Name",
									@"MERGEFIELD SerialNumber",
									@"MERGEBARCODE Barcode CODE128 \t" };

			Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

			Word.Range range = doc.Tables[1].Range.Cells[1].Range;
			range.Collapse(WdCollapseDirection.wdCollapseStart);

			InsertFields(range);
			doc.Fields.ToggleShowCodes();
		}

		private void InsertFields(Word.Range range)
		{
			Word.Document doc = range.Document;

			Word.Field field = doc.Fields.Add(range, missing, missing, missing);
			field.Code.Text = @"MERGEBARCODE Barcode CODE128 \t";
		}

		//doesn't work
		private void InsertFields(Word.Range range, string[] fieldText)
		{
			Word.Document doc = range.Document;

			for (int i = 1; i <= 3; i++)
			{
				doc.Fields.Add(range, missing, missing, missing);
				doc.Fields[i].Code.Text = fieldText[i - 1];

				range.EndOf(WdUnits.wdParagraph, WdMovementType.wdMove);

				Word.Paragraph paragraph = range.Paragraphs.Add();
				paragraph.Space1();
				paragraph.SpaceAfter = 0f;

				range = range.Next(WdUnits.wdParagraph, missing);
				range.Collapse(WdCollapseDirection.wdCollapseEnd);
			}

			doc.Paragraphs.Last.Range.Delete();
		}

		private string GetSource()
		{
			string fileName = @"\datasource.csv";
			string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;

			File.Create(sourcePath).Close();
			_model.WriteToFile(sourcePath);

			return sourcePath;
		}

		public void UpdateLabels()
		{
			try
			{
				if(!_model.IsEmpty())
				{
					_mailMerge.OpenDataSource(GetSource(), WdOpenFormat.wdOpenFormatAuto);
				} else
				{
					MessageBox.Show("Please add items by clicking \"Manage Data\".");
				}
			} catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void Execute()
		{
			_mailMerge.Execute(true);
		}
	}
}
