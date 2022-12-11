/*SAID ARRASYID _ 2207111402
Kelas = Teknik informatika
*/
using System;
namespace Tiket_bioskop
{
class uts
{
  static void Main(string[] args) 
  {
    string Nama;//Deklarasikan variable
    double harga;
    Console.WriteLine("Nama : "); Nama = Console.ReadLine();//tempat Input user
    Console.WriteLine("Tahun kelahiran : "); double Tahun = Convert.ToDouble(Console.ReadLine());
    if (2022-Tahun < 10 || 2022-Tahun > 60) //kondisi
    {
        harga = 10000.00;
    } else 
    {
        harga = 25000.00;
    }


    Console.WriteLine("|*******************************|");// output dari pilihan user
    Console.WriteLine("{0,-8} {1,15} {2,8}", "|", "-- Studio 1 --","|"); 
    Console.WriteLine("{0,-8} {1,24}", "|Nama:", Nama+"|");
    Console.WriteLine("{0,-8} {1,4} {2,19}", "|Harga:", "Rp",harga+".00|");
    Console.WriteLine("|-------------------------------|");
}
}
}