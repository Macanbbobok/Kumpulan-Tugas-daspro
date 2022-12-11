//SAID ARRASYID _ 2207111402
using System;

namespace Konversi_MataUang
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Rate USD ke Rp:");double HargaUSD = Convert.ToDouble(Console.ReadLine());//Input nilai rupiah
            Console.WriteLine("Jumlah USD:");double JumlahUang = Convert.ToDouble(Console.ReadLine());
            double Hasil = HargaUSD * JumlahUang;
            Console.WriteLine("Hasil Konversi:"+Hasil);
            Console.ReadLine();
        }
    }
}
