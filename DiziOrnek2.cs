using System;

namespace dizi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random uret = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = uret.Next(-5, +5);
                Console.WriteLine(sayilar[i]);
            }

            int c = 0;     //sayı adedi
            for (int j = 0; j < 10; j++)
            {
                c = 0;
                for (int s = 0; s < 10; s++)
                {
                    if (sayilar[j] == sayilar[s])
                        c++;
                }
                Console.WriteLine(sayilar[j] + "sayısı sayilar dizisinde " + c + " kez kullanılmıştır");
            }
            Console.ReadLine();
        }
    }
}
