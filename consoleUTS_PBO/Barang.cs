using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleUTS_PBO
{
    class Barang
    {
        public string nama { get; set; }
        public int jumlah { get; set; }
        public double harga { get; set; }

        public Barang(string namaBarang, int jumlahBarang, double hargaBarang)
        {
            nama = namaBarang;
            jumlah = jumlahBarang;
            harga = hargaBarang;
        }
    }
}
