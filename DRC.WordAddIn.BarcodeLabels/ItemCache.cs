using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
	public class ItemCache
	{
		private BindingSource _source;

		public ItemCache()
		{
			_source = new BindingSource
			{
				DataSource = new List<Item>()
			};
		}

		public void Add(Item item)
		{
			_source.Add(item);
		}

		public void AddRange(List<Item> items)
		{
			foreach(Item item in items)
			{
				Add(item);
			}
		}

		public void Insert(int index, Item item)
		{
			_source.Insert(index, item);
		}

		public void InsertRange(int index, List<Item> items)
		{
			foreach(Item item in items)
			{
				Insert(index, item);
				index++;
			}
		}

		public Item Get(int index)
		{
			return (Item)(_source[index]);
		}

		public void RemoveAt(int index)
		{
			_source.RemoveAt(index);
		}

		public object GetSource()
		{
			return _source;
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
