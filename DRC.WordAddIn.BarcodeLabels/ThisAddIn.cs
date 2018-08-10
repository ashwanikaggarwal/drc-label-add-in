using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void OpenLabels(String labelsName)
        {
            Word.Document activeDocument = this.Application.ActiveDocument;       

            try {
                String tempPath = System.IO.Path.GetTempFileName();
                //System.IO.File.Create(tempPath);
                activeDocument.MailMerge.CreateDataSource(tempPath,
                                                           missing, missing, missing, missing, 
                                                           missing, missing, missing, missing);
                System.IO.File.Delete(tempPath);
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            

            try {
                this.Application.MailingLabel.LabelOptions();
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
