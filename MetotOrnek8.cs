using System;

namespace metot8
{
    class Program
    {
        //Klavyeden girilen sayıdan 0 kadar olan sayıları toplayan programı recursive metot kullanarak yazınız.
        public static void Main(String[] args)
        {
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc=toplam(sayi);
            Console.WriteLine("Toplam="+sonuc);
        }
        public static int toplam(int k)
        {                                                 //sayi=5 
            if (k > 0)                                    //5+toplam(4)
            {                                             //5+4+toplam(3)
                return k + toplam(k - 1);                 //5+4+3+toplam(2)
            }                                             //5+4+3+2+toplam(1)
            else                                          //5+4+3+2+1+toplam(0)
            {                                             //5+4+3+2+1+0
                return 0;
            }
        }
    }
}
