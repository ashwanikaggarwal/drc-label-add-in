using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
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

        public Item(string name, string serialNumber, string barcode)
        {
            Name = name;
            SerialNumber = serialNumber;
            Barcode = barcode;
        }
    }
}
