﻿using System;

namespace ResponsiPemrograman2871
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(19112871, "dhanar", 5000000);
            Karyawan karyawan2 = new Karyawan(12345678, "krisnadhy", 3000000);

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n  Asyiiiiiiiiik naik gaji 10% kuyyy!!");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if(gaji < 0)
                this.gajiBulanan = 0;
            if(gaji > 0)
                this.gajiBulanan = gaji;
            
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1* gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }
    }
}