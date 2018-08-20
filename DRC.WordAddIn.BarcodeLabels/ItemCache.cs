using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRC.WordAddIn.BarcodeLabels
{
	[System.ComponentModel.DesignerCategory("Code")]
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

		public List<Item> GetList()
		{
			return (List<Item>)(_source.DataSource);
		}

		public bool IsEmpty()
		{
			return (_source.Count <= 0);
		}
	}
}
