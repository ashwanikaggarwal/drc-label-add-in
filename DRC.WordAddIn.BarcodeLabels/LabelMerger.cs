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
		private ItemCache _items;
		private Word.Application _app;
		private Word.Document _doc;

		private object missing = System.Reflection.Missing.Value;

		public LabelMerger(ItemCache items)
		{
			_items = items;
			_app = Globals.ThisAddIn.Application;
			_doc = Globals.ThisAddIn.Application.ActiveDocument;
		}

		public void GenerateLabels()
		{
			try
			{
				_doc.MailMerge.MainDocumentType = WdMailMergeMainDocType.wdMailingLabels;
				_app.MailingLabel.LabelOptions();
			} catch (Exception e)
			{
				MessageBox.Show(e.StackTrace);
			}
		}

		private string GetSource()
		{
			string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\datasource.csv";
			File.Create(sourcePath).Close();
			CSVData dataSource = new CSVData(sourcePath, _items.GetList());
			dataSource.AppendToFile(sourcePath);
			return sourcePath;
		}

		public void UpdateLabels()
		{
			try
			{
				GetSource();
				_doc.MailMerge.OpenDataSource(	GetSource(),
												missing, missing, missing, missing,
												missing, missing, missing, missing);
				//_doc.Fields.ToggleShowCodes();
			} catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
	}
}
