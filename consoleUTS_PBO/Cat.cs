using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleUTS_PBO
{
    class Cat : Barang
    {
        public string warna { get; set; }
        public Cat(string namaBarang, double jumlahBarang, double hargaBarang, string warnaBarang)
        {
            nama = namaBarang;
            jumlah = jumlahBarang;
            harga = hargaBarang;
            warna = warnaBarang;
        }
    }
}
