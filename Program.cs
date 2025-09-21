using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hariJawa
{
    internal class Program
    {
        public static int[] jumlahHariMasehi = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static string[] namaHariJawa = { "Pahing", "Pon", "Wage", "Kliwon", "Legi" };

        static void Main(string[] args)
        {

            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("HARI");
            Console.WriteLine("-------");
            Console.WriteLine("tgl. 17 agustus 1945");
            Console.WriteLine("jatuh pada hari '" + hariJawa() + "'");

            Console.ReadKey();
        }


        public static string hariJawa()
        {

            string sHari = "";

            // step 1 ===
            // 1 abad terdapat 5 hari menyendiri
            // Tentukan hari menyendiri hingga tahun 1900. Nah, 1900 tahun = 1600
            // tahun + 300 tahun=> 3 abag
            // Jadi dalam 100 tahun ada 4 hari pasaran menyendiri
            // hari pasaran menyendirinya dalam 200 tahun?
            // 200 tahun terdapat 2 X 4 = 8 
            // 8 hari pasaran menyendiri dibagi 5 maka sisanya adalah 
            // 3 hari pasaran menyendiri
            // +1 karena kabisat
            int iSisaHariByTahun = (((4*4) % 5)+1) + (12 % 5);
            Console.WriteLine("iSisaHariByTahun: " + iSisaHariByTahun);

            // step 2 ===
            // kasus menentukan hari di tgl 17 agt 1945
            // Tentukan hari menyendiri mulai dari awal tahun 1901 hingga akhir tahun 1944
            //  Kita mengetahui bahwa 44 tahun itu mempunyai (44 bagi 4) 11 tahun kabisat 
            //dan 33 tahun biasa. 
            // setiap tahun kabisat mempunyai 2 hari menyendiri 
            // tahun biasa   mempunyai 1 hari menyendiri
            int iSisaHariByYearRange = ((11 * 1) + (33 * 0)) % 5;
            Console.WriteLine("iSisaHariByYearRange: " + iSisaHariByYearRange);

            // step 3 ===
            // Tentukan banyaknya hari menyendiri mulai dari 1 Januari 1945
            // hingga 17 Agustus 1945. 
            // 
            int iJlhHari = 0;

            for (int i = 1; i <= (8 - 1); i++)
            {
                iJlhHari += jumlahHariMasehi[i];
            }
            iJlhHari = iJlhHari + 17;
            //Console.WriteLine("iJlhHari: " + iJlhHari);

            int iSisaHariByDateRange = iJlhHari % 5;

            Console.WriteLine("iSisaHariByDateRange: " + iSisaHariByDateRange);

            int iSumSisa = (iSisaHariByTahun + iSisaHariByYearRange + iSisaHariByDateRange) % 5;
            Console.WriteLine("");
            Console.WriteLine("iSumSisa: " + iSumSisa);

            sHari = namaHariJawa[iSumSisa];

            return sHari;
        }





    }
}
