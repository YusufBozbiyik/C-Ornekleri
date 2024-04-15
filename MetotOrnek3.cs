using System;

namespace metot3
{
    //GERİYE DEĞER DÖNDÜREN PARAMETRE ALMAYAN
    class Program
    {
        private static int Hesapla()
        {
            Console.Write("Kısa kenarı girin :");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı girin :");
            int uk = Convert.ToInt32(Console.ReadLine());
            int alan = kk * uk;
            return alan;
        }

        static void Main(string[] args)
        {
            int sonuc = Hesapla();
            Console.WriteLine("Alan = " + sonuc);
            Console.ReadLine();
        }
    }

}
