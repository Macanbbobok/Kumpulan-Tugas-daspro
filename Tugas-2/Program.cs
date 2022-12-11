/*Created by SAID ARRASYID - 2207111402
*/
using System;

namespace das_pro
{
    class Program
    { static Random random = new Random();
    //Deklarasi variabel

    static int kodeA;
    static int kodeB;
    static int kodeC;
    static int hasiltambah;
    static int hasilkurang;
    static int hasilbagi;
    static int level = 1;
    static int kesempatan = 3;
    static int jumlahKode = 3;


    static string tebakanA;
    static string tebakanB;
    static string tebakanC;

    static bool bgameBegin = true ;
    static bool END = false;



    // METHOD
    static void Main (string[] args)
    { 
    intro();
    while (bgameBegin)
    {
    PlayGame();
    
    if (END == true){
    break;
    }
    }
    }
    static void intro(){
            // intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui..");
        }
        
        static void PlayGame() {
          //Operasi aritmatika dengan angka random  
            kodeA = random.Next(1, level);
            kodeB = random.Next(1, level);
            kodeC = random.Next(1, level);
        
            hasiltambah = kodeA + kodeB + kodeC;
            hasilkurang = kodeA - kodeB - kodeC;
            hasilbagi = kodeA / kodeB / kodeC;
            //Hasil dari operasi aritmatika dan juga sebagai clue untuk user
            Console.WriteLine("- level " + level);
            Console.WriteLine("- Password terdiri dari " + jumlahKode + " angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + hasiltambah);
            Console.WriteLine("- Jika dikurangkan hasilnya " + hasilkurang);
            Console.WriteLine("- Jika dibagikan hasilnya " + hasilbagi);

            //input by user
            Console.WriteLine("Masukkan Kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.WriteLine("Masukkan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.WriteLine("Masukkan Kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda " + tebakanA + " " + tebakanB + " " + tebakanC + "?");

            if (tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()) {
                Console.WriteLine("Anda benar!");

                // level
                level = level + 1;

                if(level > 5){
                    Console.WriteLine("GG");
                    END = true;
                }

            } else {
                Console.WriteLine("Anda salah!");

                // kesempatan
                 kesempatan = kesempatan - 1;
                 Console.WriteLine("salahh");

                if(kesempatan < 1){
                    Console.WriteLine("Game over");
                    END= true;
                }
            }
        }







    }

}

