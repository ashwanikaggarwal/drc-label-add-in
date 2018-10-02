using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Office and Interop
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;

namespace DRC.WordAddIn.BarcodeLabels
{
	public enum ControllerResult
	{
		Success, Nothing, Failure, SilentFailure, EmptyData, NoLabels, NoTemplate
	}

	public class DocumentController
	{
		private Word.Application _app;
		private DataModel _dataModel;
        private LabelModel _labelModel;
        private LabelWriter _labelWriter;

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
            _labelModel = new LabelModel();
            _labelWriter = new LabelWriter(_app);

            try
            {
                _labelModel.LoadFromDirectory(Properties.Settings.Default.LabelDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }

        public ControllerResult CreateLabels()
        {
            try
            {
                _labelWriter.GenerateLabels();
                return WriteLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.ToString()}");
                return ControllerResult.Failure;
            }
        }

        private ControllerResult WriteLabels()
        {
            Word.Table labelsTable = _labelWriter.GetLabelsTable();

            if (labelsTable == null)
            {
                //user chose that no labels should be made
                return ControllerResult.Nothing;
            }

            LabelTemplate template = _labelModel.CurrentLabel;

            if (template == null)
            {
                return ControllerResult.NoTemplate;
            }

            _labelWriter.WriteLabel(labelsTable, template);
            return ControllerResult.Success;
        }

        public ControllerResult FinishLabels()
		{
            if(_dataModel.IsEmpty())
            {
                return ControllerResult.EmptyData;
            } else if (!_labelWriter.HasLabels)
            {
                return ControllerResult.NoLabels;
            }

            return MailMergeExecute();
		}

        private ControllerResult MailMergeExecute()
        {
            try
            {
                string fileName = @"\datasource.csv";
                string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName;

                System.IO.File.Create(sourcePath).Close();
                _dataModel.WriteToFile(sourcePath);

                Word.MailMerge mailMerge = ActiveDocument.MailMerge;

                mailMerge.OpenDataSource(sourcePath, Word.WdOpenFormat.wdOpenFormatAuto);
                mailMerge.Execute(true);
                mailMerge.DataSource.Close();
                System.IO.File.Delete(sourcePath);

                return ControllerResult.Success;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"{ex.ToString()}");
                return ControllerResult.Failure;
            }
        }

        public ControllerResult OpenTemplateForm()
        {
            try
            {
                LabelTemplateForm tForm = new LabelTemplateForm(_labelModel);
                tForm.ShowDialog();

                return WriteLabels();
            } catch
            {
                return ControllerResult.SilentFailure;
            }
        }

        public ControllerResult OpenDataForm()
        {
            try
            {
                DataForm dForm = new DataForm(_dataModel);
                dForm.ShowDialog();
            }
            catch
            {
                return ControllerResult.SilentFailure;
            }

            return ControllerResult.Success;
        }

        public ControllerResult ToggleFields()
        {
            try
            {
                ActiveDocument.Fields.ToggleShowCodes();
            }
            catch
            {
                return ControllerResult.SilentFailure;
            }
            return ControllerResult.Success;
        }

        public ControllerResult DisplayStatus()
        {
            try
            {
                string status = "";
                status += "Mail Merge State: " + ActiveDocument.MailMerge.State.ToString() + "\n";
                status += "Data Source: " + ActiveDocument.MailMerge.DataSource.Type.ToString() + "\n";
                MessageBox.Show(status);
            }
            catch
            {
                return ControllerResult.SilentFailure;
            }
            return ControllerResult.Success;
        }
	}
}