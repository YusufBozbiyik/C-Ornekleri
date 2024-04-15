using System;

namespace nesne
{
   class Ucgen
    {
        public int a;
        public int b;
        public int c;
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.a = 1;
            ucgen.b = 4;
            ucgen.c = 5;

            Console.WriteLine("Üçgenin a kenar uzunluğu: {0}", ucgen.a);
            Console.WriteLine("Üçgenin b kenar uzunluğu: {0}", ucgen.b);
            Console.WriteLine("Üçgenin c kenar uzunluğu: {0}", ucgen.c);
            Console.ReadLine();
        }
    }
}
