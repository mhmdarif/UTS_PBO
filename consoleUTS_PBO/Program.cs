using System;
using System.Collections.Generic;

namespace consoleUTS_PBO
{
    class Program
    {
        static void Main(string[] args)
        {
            //menginisialisasi barang yang dijual
            //dengan meng-instance objek dari class

            // Cat
            Cat avianMerah = new Cat("Avian", 100, 5000, "merah");
            Cat avianBiru = new Cat("Avian", 100, 6000, "hijau");
            Cat decolith = new Cat("Decolith", 100, 4000, "Biru");

            List<Cat> listCat = new List<Cat>();
            listCat.Add(avianMerah);
            listCat.Add(avianBiru);
            listCat.Add(decolith);
         
            //Semen
            Semen holcim = new Semen("Holcim", 100, 120000);
            Semen tigaRoda = new Semen("Tiga Roda", 100, 130000);

            
            List<Semen> listSemen = new List<Semen>();
            listSemen.Add(holcim);
            listSemen.Add(tigaRoda);

            //########################   HOME PAGE   #############################
            Console.WriteLine("selamat datang di aplikasi ini");
            Console.WriteLine("apakah anda pembeli? (Y/N)");
            string konfirmasi = Console.ReadLine().ToUpper();

            try
            {
                if (konfirmasi == "Y")
                {
                    Console.WriteLine("daftar barang yang dijual di toko banguan AAA ");

                    Console.WriteLine("Cat : ");
                    foreach (Cat cat in listCat)
                    {
                        Console.WriteLine("\t Cat {0} \t warna {1} \t harga Rp {2} per satuan ",cat.nama, cat.warna, cat.harga);
                    }

                    Console.WriteLine("Semen : ");
                    foreach (Semen semen in listSemen)
                    {
                        Console.WriteLine("\t Semen {0}   \t harga Rp {1} per sak", semen.nama, semen.harga);
                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("f");
            }

            Console.ReadLine();
        }

    }
}
