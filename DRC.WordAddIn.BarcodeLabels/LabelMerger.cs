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
		public const int FIELD_FONT_SIZE = 8;

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
			Word.Document doc = _mailMerge.Application.ActiveDocument;
			Word.Cell cell = doc.Tables[1].Range.Cells[1];

			InsertIntoCell(cell, false);
		}

		//work in progress
		private void InsertIntoCell(Word.Cell cell, bool insertNextField, bool temp)
		{
			char pBreak = '\u00B6';

			string[] fieldCodes = { @"NEXT",
									@"MERGEFIELD Name",
									@"MERGEFIELD SerialNumber \b "": """,
									$"MERGEBARCODE Barcode CODE128 \\b {pBreak}" };

			cell.Range.Delete();
			Word.Range range = cell.Range;

			range.Collapse(WdCollapseDirection.wdCollapseStart);

			foreach(string fieldCode in fieldCodes)
			{
				if(!insertNextField)
				{
					insertNextField = true;
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

		private void InsertIntoCell(Word.Cell cell, bool insertNextField)
		{
			Word.Range range = cell.Range;

			//purge existing paragraphs in range
			foreach (Paragraph p in range.Paragraphs)
			{
				p.Range.Delete();
			}

			InsertFields(range);

			if(insertNextField)
			{
				//insert "next record" field at start
				range.Collapse(WdCollapseDirection.wdCollapseStart);
				Word.Field nextField = range.Fields.Add(range, missing, missing, missing);
				nextField.Code.Text = @"NEXT";
			}

			//enforce single spacing in each paragraph
			foreach (Paragraph p in cell.Range.Paragraphs)
			{
				p.SpaceBefore = 0f;
				p.SpaceAfter = 0f;
				p.Space1();
			}

			cell.Range.Font.Size = FIELD_FONT_SIZE;
			cell.Range.Fields.Update();
		}

		private void InsertFields(Word.Range range)
		{
			//create top paragraph
			Word.Paragraph paragraph1 = range.Paragraphs.Add();
			range.Collapse(WdCollapseDirection.wdCollapseStart);

			//create name field
			Word.Field nameField = range.Fields.Add(range, missing, missing, missing);
			nameField.Code.Text = @"MERGEFIELD Name";
			range = nameField.Result;
			range.Collapse(WdCollapseDirection.wdCollapseEnd);

			//create serial number field
			Word.Field serialNumField = range.Fields.Add(range, missing, missing, missing);
			serialNumField.Code.Text = @"MERGEFIELD SerialNumber \b "": """;

			//set up range for next paragraph
			range = serialNumField.Result;
			range.Collapse(WdCollapseDirection.wdCollapseEnd);
			range.InsertParagraphAfter();

			//create next paragraph
			Word.Paragraph paragraph2 = range.Paragraphs.Add();
			range = paragraph2.Range;

			//create barcode field
			Word.Field barcodeField = paragraph2.Range.Fields.Add(range, missing, missing, missing);
			barcodeField.Code.Text = @"MERGEBARCODE Barcode CODE128";
		}

		public void UpdateLabels()
		{
			if(!_model.IsEmpty())
			{
				try
				{
					_mailMerge.DataSource.Close();
				}
				catch { /*silence*/ }
				
				_mailMerge.OpenDataSource(GetSource(), WdOpenFormat.wdOpenFormatAuto);
				UpdateFields();
			} else
			{
				MessageBox.Show("Please add items by clicking \"Manage Data\".");
			}
		}

		private void UpdateFields()
		{
			Word.Document doc = _mailMerge.Application.ActiveDocument;
			Word.Range tableRange = doc.Tables[1].Range;

			InsertIntoCell(tableRange.Cells[1], false);

			foreach (Word.Cell cell in tableRange.Cells)
			{
				foreach (Word.Field field in cell.Range.Fields)
				{
					if (field.Code.Text.Contains("NEXT"))
					{
						InsertIntoCell(cell, true);
						break;
					}
				}
			}
		}

		private string GetSource()
		{
			string fileName = @"\datasource.csv";
			string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;

			File.Create(sourcePath).Close();
			_model.WriteToFile(sourcePath);

			return sourcePath;
		}

		public void Execute()
		{
			_mailMerge.Execute(true);
		}
	}
}
