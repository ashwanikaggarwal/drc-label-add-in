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
				//InsertFields();
			} catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void InsertFields()
		{
			Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

			for(int i = 0; i < 3; i++)
			{
				Word.Paragraph paragraph = doc.Paragraphs.Add();
				paragraph.Range.Fields.Add(paragraph.Range, missing, missing, missing);
				paragraph.Space1();
				paragraph.SpaceAfter = 0f;
				paragraph.Range.InsertParagraphAfter();
			}

			doc.Fields[1].Code.Text = @"MERGEFIELD Name";
			doc.Fields[2].Code.Text = @"MERGEFIELD SerialNumber";
			doc.Fields[3].Code.Text = @"MERGEBARCODE Barcode CODE128 \t";

			Globals.ThisAddIn.Application.ActiveDocument.Fields.ToggleShowCodes();
		}

		public void InsertFields(bool temp)
		{
			Word.Document doc = _mailMerge.Application.ActiveDocument;
			Word.Range range = doc.Tables[1].Range.Cells[1].Range;

			range.Collapse(WdCollapseDirection.wdCollapseStart);
			doc.Fields.Add(range, missing, missing, missing);
			range.Next(WdUnits.wdWord, 1);

			range.Collapse(WdCollapseDirection.wdCollapseEnd);
			doc.Fields.Add(range, missing, missing, missing);
			range.Next(WdUnits.wdWord, 1);

			range.Collapse(WdCollapseDirection.wdCollapseEnd);
			doc.Fields.Add(range, missing, missing, missing);

			doc.Tables[1].Range.Fields[1].Code.Text = @"MERGEFIELD Name";
			doc.Tables[1].Range.Fields[2].Code.Text = @"MERGEFIELD SerialNumber";
			doc.Tables[1].Range.Fields[3].Code.Text = @"MERGEBARCODE Barcode CODE128 \t";

			_mailMerge.Application.ActiveDocument.Fields.ToggleShowCodes();
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
				_mailMerge.OpenDataSource(GetSource(), WdOpenFormat.wdOpenFormatAuto);
			} catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
	}
}
