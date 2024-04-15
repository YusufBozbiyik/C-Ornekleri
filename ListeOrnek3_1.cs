using System;
using System.Collections.Generic;

namespace list3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            int seslisayac = 0;
            int sessizsayac = 0;

            List<char> sesliler = new List<char> { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };


            Console.Write("Metni Giriniz:");
            cumle = Convert.ToString(Console.ReadLine());

          

          
            //kalem
            for (int x = 0; x < cumle.Length; x++)
            {
        
                for (int i = 0; i < sesliler.Count; i++)
                {
                    if (cumle[x] == sesliler[i])
                    {
                       
                        seslisayac++;
                        break;
                       
                    }
                }
            }
            sessizsayac = cumle.Length - seslisayac;


            Console.WriteLine("Toplam Harf Sayısı :" + cumle.Length);
            Console.WriteLine("Sesli Harf Sayısı :" + seslisayac);


            Console.WriteLine("Sessiz harf Sayısı :" + sessizsayac);
            Console.ReadKey();
        }
    }
}
