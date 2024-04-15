using System;

namespace dizi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];

            for(int i=0; i<sayilar.Length; i++)
            {
                Console.Write("{0}. sayıyı giriniz:",i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n Girilen Sayılar");
            foreach(int goster in sayilar)
            {
                Console.WriteLine(goster);
            }
        }
    }
}
