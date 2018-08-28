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
	public enum ControllerResult
	{
		Success, Nothing, Failure, SilentFailure, EmptyData, NoLabels
	}

	public class DocumentController
	{
		private Word.Application _app;
		private DataModel _model;
		private LabelCreator _labelCreator;

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
			_labelCreator = new LabelCreator(_app);
		}

		public ControllerResult CreateLabels()
		{
			try
			{
				_labelCreator.GenerateLabels();

				Word.Table labelsTable = _labelCreator.GetLabelsTable();

				if (labelsTable == null)
				{
					//user chose that no labels should be made
					return ControllerResult.Nothing;
				}

				_labelCreator.WriteFields(labelsTable);
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.ToString()}");
				return ControllerResult.Failure;
			}
			return ControllerResult.Success;
		}

		public ControllerResult FinishLabels()
		{
			if (_model.IsEmpty())
			{
				return ControllerResult.EmptyData;
			} else if(!_labelCreator.HasLabels())
			{
				return ControllerResult.NoLabels;
			}

			try
			{
				string fileName = @"\datasource.csv";
				string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;

				MailMergeExecute(sourcePath);
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.ToString()}");
				return ControllerResult.Failure;
			}
			return ControllerResult.Success;
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