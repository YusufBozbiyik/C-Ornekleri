using System;
using System.Collections.Generic;

namespace list9
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, ortalama = 0;
            List<int> asalSayilar = new List<int>();
            List<int> asalOlmayanSayilar = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}.Sayıyı Girin :",i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                int sayac = 0;
              if(sayi==0 || sayi==1)
                    asalOlmayanSayilar.Add(sayi);
             else { 
                for (int j = 2; j < sayi; j++)
                    {
                        if (sayi % j == 0)
                        {
                            sayac++;
                            break;
                        }
                    }
            
                if (sayac == 0)
                    asalSayilar.Add(sayi);
                else
                    asalOlmayanSayilar.Add(sayi);
                }
            }

            ortalama = toplam / 5;
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("ASAL SAYILAR");
            foreach (int sayi in asalSayilar)

            {
                Console.Write(sayi + "    ");
            }
            Console.WriteLine();
            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            Console.WriteLine("===========================");
            
            foreach (int sayi in asalOlmayanSayilar)
            {
                Console.Write(sayi + "    ");
            }

            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("SAYILARIN ORTALAMASI : {0}", ortalama);

            Console.ReadKey();
        }
    }
}
