using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleUTS_PBO
{
    class Semen : Barang
    {
        public Semen(string namaBarang, double jumlahBarang, double hargaBarang)
        {
            nama = namaBarang;
            jumlah = jumlahBarang;
            harga = hargaBarang;
        }
    }
}
