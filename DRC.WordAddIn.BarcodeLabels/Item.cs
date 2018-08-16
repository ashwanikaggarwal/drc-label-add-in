using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRC.WordAddIn.BarcodeLabels
{
    class Item
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Barcode { get; set; }

        public Item(string name, string serialNumber, string barcode)
        {
            Name = name;
            SerialNumber = serialNumber;
            Barcode = barcode;
        }
    }
}
