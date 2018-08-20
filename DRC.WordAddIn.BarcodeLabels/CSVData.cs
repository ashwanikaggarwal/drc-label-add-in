using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DRC.WordAddIn.BarcodeLabels
{
    public class CSVData
    {
        public string			FileName	{ get; private set; }
        public List<string[]>	Data		{ get; private set; }
        public String[]			Headers		{ get; private set; }

		public CSVData(string fileName)
		{
			FileName = fileName;
			ReadData();
		}

		public CSVData(string fileName, List<Item> items)
		{
			FileName = fileName;
			Data = new List<string[]>(items.Count);
			Headers = new string[] { "Name", "SerialNumber", "Barcode" };
			AddItems(items);
		}

		private void ReadData()
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

		private void AddItems(List<Item> items)
		{
			foreach(Item item in items)
			{
				Data.Add(new string[]{ item.Name, item.SerialNumber, item.Value });
			}
		}

		public List<Item> GetItems(int nameCol, int serialNumCol, int barcodeCol)
		{
			List<Item> items = new List<Item>(Data.Count);
			foreach(string[] row in Data)
			{
				items.Add(new Item(	row[nameCol],
									row[serialNumCol],
									row[barcodeCol],
									true));
			}
			return items;
		}

		public void AppendToFile(string fileName)
		{
			try
			{
				using(StreamWriter writer = new StreamWriter(fileName))
				{
					writer.WriteLine(String.Format("{0},{1},{2}", Headers));

					foreach (string[] row in Data)
					{
						writer.WriteLine(String.Format("{0},{1},{2}", row));
					}
					writer.Close();
				}
			} catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
    }
}
