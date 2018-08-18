using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRC.WordAddIn.BarcodeLabels
{
    public class Item
    {
        [System.ComponentModel.DisplayName("Item Name")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Serial Number")]
        public string SerialNumber { get; set; }

        [System.ComponentModel.DisplayName("Barcode")]
        public string Barcode { get; set; }

		[System.ComponentModel.Browsable(false)]
		public Color ColorCode { get; set; } = Color.Empty;

        public Item(string name, string serialNumber, string barcode)
        {
            Name = name;
            SerialNumber = serialNumber;
            Barcode = barcode;
        }

		public Item(string name, string serialNumber, string barcode, bool colorSetting)
		{
			Name = name;
			SerialNumber = serialNumber;
			Barcode = barcode;
			//colorSetting true is for imported items, false for blanks
			ColorCode = colorSetting ? Color.LightGreen : Color.LightYellow;
		}
	}
}
