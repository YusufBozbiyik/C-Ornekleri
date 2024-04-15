using System;
using System.Collections.Generic;

namespace list2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            Console.WriteLine("Tüm Sayılar");
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(i);
                Console.Write(sayilar[i]+" ");
            }
            Console.WriteLine("\n\nSeçilen Rastgele Sayılar");
            for (int x = 1; x <= 6; x++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, sayilar.Count);
                Console.Write(sayilar[index] + " "); ;
                sayilar.RemoveAt(index);
            }
            Console.WriteLine("\n\nKalan Sayılar");
            foreach (int goster in sayilar)
            {
                Console.Write(goster+" ");
            }
            Console.ReadLine();
        }
    }
}
