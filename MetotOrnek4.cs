using System;

namespace metot4
{
    //GERİYE DEĞER DÖNDÜREN PARAMETRE ALAN
    class Program
    {
        private static int Hesapla(int kisa, int uzun)
        {
            int alan = kisa * uzun;
            return alan;
        }

        static void Main(string[] args)
        {
            Console.Write("Kısa kenarı girin :");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı girin :");
            int uk = Convert.ToInt32(Console.ReadLine());
            int sonuc = Hesapla(kk, uk);
            Console.WriteLine("Alan = " + sonuc);
            Console.ReadLine();
        }
    }
}
