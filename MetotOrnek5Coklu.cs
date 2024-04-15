using System;

namespace metot5
{
    class Program
    {
        //İki sayıdan en büyük olanını parametresiz geriye değer döndüren metotla bulunuz.

        private static int Hesapla()
        {

            int enBuyuk;
            Console.Write("İlk sayıyı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
                enBuyuk = sayi1;
            else
                enBuyuk = sayi2;
            return enBuyuk;
        }
        //girilen sayının faktöriyelini  geriye değer döndüren parametreli metotla bulunuz.
        private static int faktoriyelHesapla(int sayi)
        {
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            return faktoriyel;
        }
        //girilen sayının tek mi çift mi olduğunu geriye değer döndürmeyen parametreli metotla bulunuz.

        //girilen sayının asal olup olmadığını geriye değer döndürmeyen parametreli metotla bulunuz.
        private static void asalHesapla(int sayi)
        {
            if (sayi == 0 || sayi == 1)
                Console.WriteLine("Sayı asal değildir.");
            else
            {
                int sayac = 0;
                for (int j = 2; j < sayi; j++)
                {
                    if (sayi % j == 0)
                    {
                        sayac++;
                        break;
                    }
                }

                if (sayac == 0)
                    Console.WriteLine("Sayı asaldır");
                else
                    Console.WriteLine("Sayı asal değildir.");
            }
        }
        //girilen sayının mükemmel sayı olup olmadığını parametresiz geriye değer döndürmeyen metotlar yapınız.
        private static void mukemmelSayiHesapla()
        {
            int toplam = 0;
          Console.Write("Mükemmel sayı komtrolü için girilecek sayı :");
          int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < sayi; i++)
            {
                if(sayi%i==0)
                {
                    toplam += i;
                }
            }
            if (sayi == toplam)
                Console.WriteLine("{0} sayısı mükemmel sayıdır.", sayi);
            else
                Console.WriteLine("{0} sayısı mükemmel sayı DEĞİLDİR.", sayi);

        }

        //girilen sayının tek mi çift mi olduğunu  geriye değer döndüren parametreli metotla bulunuz.
        private static string tekCiftHesapla(int sayi)
        {
            if (sayi % 2 == 0)
                return "cift";
            else
                return "tek";

        }
        static void Main(string[] args)
        {
            Console.WriteLine("En Büyük Sayı Hesaplama");
           int sonuc = Hesapla();
           Console.WriteLine("En büyük Sayı = " + sonuc);

            Console.WriteLine("---------------------------------");

            Console.Write("Faktoriyeli hesaplanacak sayı :");
            int f = Convert.ToInt32(Console.ReadLine());
            int sonuc2 = faktoriyelHesapla(f);
            Console.WriteLine("Sayının Faktoriyeli :"+sonuc2);

            Console.WriteLine("---------------------------------");

            Console.Write("Asal kontrolü yapılacak sayı :");
            int a = Convert.ToInt32(Console.ReadLine());
            asalHesapla(a);

            Console.WriteLine("---------------------------------");
            mukemmelSayiHesapla();


            Console.WriteLine("---------------------");

            Console.Write("Tek - Çift kontrolü yapılacak sayı :");
            int s = Convert.ToInt32(Console.ReadLine());
            string tSonuc = tekCiftHesapla(s);
            Console.WriteLine("{0} sayısı {1} sayıdır.", s, tSonuc);

            Console.ReadLine();
        }
    }
}
