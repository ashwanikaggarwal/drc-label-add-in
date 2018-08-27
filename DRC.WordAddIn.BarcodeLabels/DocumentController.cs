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
	public class DocumentController
	{
		private Word.Application _app;
		private DataModel _model;

		public DataForm DataForm
		{
			get
			{
				return new DataForm(_model);
			}
		}

		public Word.Document ActiveDocument
		{
			get
			{
				return _app.ActiveDocument;
			}
		}

		public DocumentController(Word.Application app)
		{
			_app = app;
			_model = new DataModel();
		}

		public string CreateLabels()
		{
			try
			{
				LabelCreator labelCreator = new LabelCreator(ActiveDocument);
				labelCreator.GenerateLabels();
				labelCreator.WriteFields();
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
			return "OK";
		}

		public string FinishLabels()
		{
			if (!_model.IsEmpty())
			{
				try
				{
					string fileName = @"\datasource.csv";
					string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;

					MailMergeExecute(sourcePath);
				}
				catch (Exception ex)
				{
					return ex.Message;
				}
			} else
			{
				return "Please add items by clicking \"Manage Data\".";
			}
			return "OK";
		}

		private void MailMergeExecute(string sourcePath)
		{
			System.IO.File.Create(sourcePath).Close();
			_model.WriteToFile(sourcePath);

			Word.MailMerge mailMerge = ActiveDocument.MailMerge;

			mailMerge.OpenDataSource(sourcePath, WdOpenFormat.wdOpenFormatAuto);
			mailMerge.Execute(true);
			mailMerge.DataSource.Close();
			System.IO.File.Delete(sourcePath);
		}
	}
}