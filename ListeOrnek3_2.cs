using System;
using System.Collections.Generic;

namespace list3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            int seslisayac = 0;
            int sessizsayac = 0;

            List<char> sesliler = new List<char> { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> sesli = new List<char>();
            List<char> metin = new List<char>();

            Console.Write("Metni Giriniz:");
            cumle = Convert.ToString(Console.ReadLine());


            for (int i = 0; i < cumle.Length; i++)
            {
                metin.Add(cumle[i]);
            }





            for (int x = 0; x < cumle.Length; x++)
            {

                for (int i = 0; i < sesliler.Count; i++)
                {
                    if (cumle[x] == sesliler[i])
                    {
                        metin.Remove(cumle[x]);
                        seslisayac++;
                        sesli.Add(sesliler[i]);

                    }
                }
            }
            sessizsayac = metin.Count;


            Console.Write("\nSesli Harfler :");
            foreach (char goster in sesli)
            {
                Console.Write(goster + " ");
            }
            Console.WriteLine("\nSesli Harf Sayısı :" + seslisayac.ToString());

            Console.Write("\nSessiz Harfler :");
            foreach (char goster in metin)
            {
                Console.Write(goster + " ");
            }
            Console.WriteLine("\nsessiz harfler:" + sessizsayac.ToString());
            Console.ReadKey();
        }
    }
    
}
