using System;
using System.Collections.Generic;

namespace list10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tekSayilar = new List<int>();
            List<int> ciftSayilar = new List<int>();
            int ortalama = 0, toplam = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int sayi = rnd.Next(1, 100);
                Console.Write(sayi + "   ");
                toplam += sayi;
                if (sayi % 2 == 0)
                {
                    ciftSayilar.Add(sayi);
                }
                else
                {
                    tekSayilar.Add(sayi);
                }

            }
            Console.WriteLine();
            Console.WriteLine("======================================================");
            ortalama = toplam / 10;

            Console.WriteLine("\nÇİFT SAYILAR");
            foreach (int sayi in ciftSayilar)
            {
                Console.Write(sayi + "    ");
            }

            Console.WriteLine("\n\nTEK SAYILAR");
            foreach (int sayi in tekSayilar)
            {
                Console.Write(sayi + "    ");
            }

            Console.WriteLine("\n\nSayıların Ortalaması : {0}", ortalama);
            Console.WriteLine("Tek Sayıların Adeti : {0}", tekSayilar.Count);
            Console.WriteLine("Çift Sayıların Adeti : {0}", ciftSayilar.Count);
            Console.ReadKey();
        }
    }
}
