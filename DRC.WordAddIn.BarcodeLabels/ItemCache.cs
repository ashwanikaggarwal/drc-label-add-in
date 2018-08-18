using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class ItemCache : BindingSource
	{
		[Browsable(false)]
		public new List<Item> List { get; set; }

		public ItemCache() : base()
		{
			this.DataSource = new List<Item>();
		}

		public Item GetItem(int index)
		{
			return (Item)(this[index]);
		}

		public void ImportCSVData(CSVData csvData, int nameCol, int serialNumCol, int barcodeCol)
		{
			foreach(string[] row in csvData.Data)
			{
				Item item = new Item(row[nameCol], row[serialNumCol], row[barcodeCol], true);
				Add(item);
			}
		}
	}
}
