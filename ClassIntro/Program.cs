using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hilal";
            int yas = 19;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hilal Nur Tınas";
            kurs1.IzlenmeOrani = 98;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Beril Börekcioğlu";
            kurs2.IzlenmeOrani = 74;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Şerife Koçak";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " % " + kurs.IzlenmeOrani);
            }




            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
