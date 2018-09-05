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
		private DataModel _dataModel;
		private LabelManager _labelManager;
		private LabelModel _labelModel;

		public DataForm DataForm
		{
			get
			{
				return new DataForm(_dataModel);
			}
		}

		public LabelTemplateForm TemplateForm
		{
			get
			{
				return new LabelTemplateForm(_labelModel);
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
			_dataModel = new DataModel();
			_labelManager = new LabelManager(_app);
			_labelModel = new LabelModel();
		}

		public ControllerResult CreateLabels()
		{
			try
			{
				_labelManager.GenerateLabels();

				Word.Table labelsTable = _labelManager.GetLabelsTable();

				if (labelsTable == null)
				{
					//user chose that no labels should be made
					return ControllerResult.Nothing;
				}

				LabelTemplate template = _labelModel.CurrentLabel;

				if(template != null)
				{
					_labelManager.WriteLabel(labelsTable, template);
				}
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
			if (_dataModel.IsEmpty())
			{
				return ControllerResult.EmptyData;
			} else if(!_labelManager.HasLabels())
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
			_dataModel.WriteToFile(sourcePath);

			Word.MailMerge mailMerge = ActiveDocument.MailMerge;

			mailMerge.OpenDataSource(sourcePath, WdOpenFormat.wdOpenFormatAuto);
			mailMerge.Execute(true);
			mailMerge.DataSource.Close();
			System.IO.File.Delete(sourcePath);
		}
	}
}