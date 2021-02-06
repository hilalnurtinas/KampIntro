using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300};
            sayilar1 = sayilar2;   //sayilar1in ref numarası eşittir sayılar2nin referans numarası
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999

            //int, decimal, float, double, boolean(true/false) = değer tip
            //array, class, interface = referans tip      
            // stack (degertip)(sayi1=10/sayi2=30)   // heap
            



        }
    }
}
