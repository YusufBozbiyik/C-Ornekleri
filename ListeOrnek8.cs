using System;
using System.Collections.Generic;

namespace list8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            List<int> poz = new List<int>();
            List<int> neg = new List<int>();
            int sayi, pSayi=0, nSayi=0;
            do {
                Console.Write("Sayı Giriniz :");
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            } while (sayi!=0);

            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i] > 0)
                {
                    pSayi++;
                    poz.Add(sayilar[i]);
                }
                else if(sayilar[i] < 0)
                { 
                    nSayi++;
                    neg.Add(sayilar[i]);
                 }
            }

            Console.WriteLine("\n\nGirilen sayılar");

            for (int i = 0; i < sayilar.Count - 1; i++)
            {
                Console.Write(sayilar[i]+" ");
            }

            Console.WriteLine("\n\nPozitif Sayılar");
            foreach (int goster in poz)
            {
                Console.Write(goster+" ");
            }

            Console.WriteLine("\n\nNegatif Sayılar");
            foreach (int goster in neg)
            {
                Console.Write(goster + " ");
            }

            Console.WriteLine("\n\nPozitif sayısı:\t" + pSayi);
            Console.WriteLine("\nNegatif sayısı:\t" + nSayi);
            Console.ReadLine();
        }
    }
}
