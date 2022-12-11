//SAID ARRASYID - 2207111402
using System;

namespace Name_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nama;
            string Konsentrasi;
           

           Console.WriteLine("Nama :"); Nama = Console.ReadLine();
           Console.WriteLine("Nim :"); int Nim = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Konsentrasi"); Konsentrasi =(Console.ReadLine());

           Console.WriteLine("|***************************|");
           Console.WriteLine("|NAMA  :{0,20}|",Nama);
           Console.WriteLine("| {0,26}|"       ,Nim);
           Console.WriteLine("|---------------------------|");
           Console.WriteLine("|{0,27}|"        ,Konsentrasi);
           Console.WriteLine("|***************************|");
           




        
}
    }
}
