using System;

namespace metot2
{
    //GERİYE DEĞER DÖNDÜRMEYEN PARAMETRE ALAN
    class Program
    {
        private static void Hesapla(int kisa, int uzun)
        {

            int alan = kisa * uzun;
            Console.WriteLine("Alan = {0}", alan);
        }

        static void Main(string[] args)
        {
            Console.Write("Kısa kenarı girin :");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı girin :");
            int uk = Convert.ToInt32(Console.ReadLine());
            Hesapla(kk, uk);
            Console.ReadLine();
        }
    }

}
