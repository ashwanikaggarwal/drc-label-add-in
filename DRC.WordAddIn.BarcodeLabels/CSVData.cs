using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace DRC.WordAddIn.BarcodeLabels
{
    public class CSVData
    {
        public string FileName { get; }
        public List<string[]> Data { get; private set; }
        public String[] Headers { get; private set; }

        public CSVData(string fileName)
        {
            FileName = fileName;
            ParseData();
        }

        private void ParseData()
        {
            TextFieldParser parser = new TextFieldParser(FileName);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            List<String[]> rows = new List<String[]>();

            while (!parser.EndOfData)
            {
                rows.Add(parser.ReadFields());
            }
            parser.Close();

            Headers = rows[0];
            rows.RemoveAt(0);
            Data = rows;
        }
    }
}
