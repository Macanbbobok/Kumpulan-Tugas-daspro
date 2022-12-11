/*SAID ARRASYID _ 2207111402
Kelas = Teknik informatika B */
using System;
using System.Text.RegularExpressions;

namespace Enkripsi
{
    class Program
    {
           public static void Main(string[] args) {
            string text,enkripsi =" ";
            string alfabet = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            Regex rgx = new Regex("[^A-Za-z ]"); 
            do
            {
             Console.Write("Teks :"); text = Console.ReadLine(); 
            } while (string.IsNullOrEmpty(text)|| rgx.IsMatch(text));
                foreach (char t in text)
                {
                char temp = ' ';
                
                for (int i = 0; i < alfabet.Length; i++)
                {
                  char c = alfabet[i];
                  if (t.Equals(c) )
                  {
                    temp =alfabet[i+3];
                     break;}
                    else if (t.Equals(' '))
                    {
                       temp = ' ' ;
                       break;
                    }
          
                }
                  
                enkripsi = enkripsi + temp;
                
             }
            
            Console.WriteLine("Hasil Enkripsi : " + enkripsi);


        }
    }
}
