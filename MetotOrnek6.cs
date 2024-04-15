using System;

namespace metot6
{
    class Program
    {
        static int faktoriyel(int sayi)
        {
            if (sayi == 1)
                return 1;
            else
                return sayi * faktoriyel(sayi - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("sayıyı gir");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Faktoriyel:{0}", faktoriyel(sayi));
            Console.ReadKey();
        }
    }
}
