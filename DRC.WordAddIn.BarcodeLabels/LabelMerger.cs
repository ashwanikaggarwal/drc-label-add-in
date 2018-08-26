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
		private string[] _fieldCodes;

		private object missing = System.Reflection.Missing.Value;

		public LabelMerger(DataModel model, Word.MailMerge mailMerge)
		{
			_model = model;
			_mailMerge = mailMerge;
			_fieldCodes = new string[] {	@" MERGEFIELD Name ",
											@" MERGEFIELD SerialNumber \b "": "" ",
											"\v",
											@" MERGEBARCODE Barcode CODE128 " };
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
		
		private void InsertIntoCell(Word.Cell cell, string[] fieldCodes)
		{
			cell.Range.Delete();
			Word.Range range = cell.Range;

			range.Collapse(WdCollapseDirection.wdCollapseStart);

			foreach(string fieldCode in fieldCodes)
			{
				if(fieldCode.Equals("\v"))
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

		public void WriteFields()
		{
			Word.Document doc = _mailMerge.Application.ActiveDocument;
			Word.Range tableRange = doc.Tables[1].Range;

			InsertIntoCell(tableRange.Cells[1], _fieldCodes);
			doc.Application.CommandBars.ExecuteMso("MailMergeUpdateLabels");
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
			if (!_model.IsEmpty())
			{
				try
				{
					_mailMerge.DataSource.Close();
				}
				catch { /*silence*/ }

				_mailMerge.OpenDataSource(GetSource(), WdOpenFormat.wdOpenFormatAuto);
				_mailMerge.Execute(true);
			}
			else
			{
				MessageBox.Show("Please add items by clicking \"Manage Data\".");
			}
		}
	}
}
