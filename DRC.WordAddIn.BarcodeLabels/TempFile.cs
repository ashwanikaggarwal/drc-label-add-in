using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DRC.WordAddIn.BarcodeLabels
{
    class TempFile
    {
        public String FileName { get; set; }

        public TempFile(String fileName)
        {
            this.FileName = fileName;
        }
    }
}
