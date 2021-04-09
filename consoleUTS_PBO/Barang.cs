using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleUTS_PBO
{
    public abstract class Barang
    {

        public string nama { get; set; } //dapat digunakan utunk nama atau merk barang
        public double jumlah { get; set; }
        public double harga { get; set; }

    }
}
