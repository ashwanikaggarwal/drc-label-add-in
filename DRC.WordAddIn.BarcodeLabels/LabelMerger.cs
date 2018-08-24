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
		private Word.Application _app;
		private Word.Document _doc;

		private object missing = System.Reflection.Missing.Value;

		public LabelMerger(DataModel model, Word.Application app, Word.Document doc)
		{
			_model = model;
			_app = app;
			_doc = doc;
		}

		public void GenerateLabels()
		{
			try
			{
				_doc.MailMerge.MainDocumentType = WdMailMergeMainDocType.wdMailingLabels;
				_app.MailingLabel.LabelOptions();
			} catch (Exception e)
			{
				MessageBox.Show(e.Message);
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

		public void UpdateLabels()
		{
			try
			{
				_doc.MailMerge.OpenDataSource(GetSource(), WdOpenFormat.wdOpenFormatAuto);
				//_doc.Fields.ToggleShowCodes();
			} catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
	}
}
