using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.Egitmen = "Ramazan";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 15;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Ramazan";
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 25;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Ramazan";
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 65;

            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Ramazan";
            kurs4.KursAdi = "C++";
            kurs4.IzlenmeOrani = 75;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " +kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " " + kurs.Egitmen);
            }

            Console.Read();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }


}
