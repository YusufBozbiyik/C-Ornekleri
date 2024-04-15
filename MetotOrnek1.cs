using System;

namespace metot
{
    //GERİYE DEĞER DÖNDÜRMEYEN PARAMETRESİZ
    class Program
    {
        //static ögesi nesne tanımlanmadan metoda erişim sağlar.
       static void Hesapla()
        {
            Console.Write("Kısa kenarı girin :");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı girin :");
            int uk = Convert.ToInt32(Console.ReadLine());
            int alan = kk * uk; 
            Console.WriteLine("Alan = {0}", alan);
        }

        

        static void Main(string[] args)
        {
            Hesapla();
            Console.ReadLine();
        }
    }
}
