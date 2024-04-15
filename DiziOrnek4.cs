using System;

namespace dizi4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] harf = { 'ö', 'ç', 'ş', 'ı', 'ğ', 'ü'};
            string metin;
            int sayac=0;
            Console.Write("Metni Giriniz:");
            metin = Console.ReadLine();

            for (int i = 0; i < metin.Length; i++) //çağdaş 6
            {
                for (int j = 0; j < harf.Length; j++)  //6
                {
                    if (metin[i] == harf[j])
                    {
                        sayac++;
                        break;
                    }
                   
                }
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
        }
    }
}
