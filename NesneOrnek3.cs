using System;

namespace nesne3
{
    class Ucgen
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 1;
            ucgen.B = 4;
            ucgen.C = 5;

            Console.WriteLine("Üçgenin a kenar uzunluğu: {0}", ucgen.A);
            Console.WriteLine("Üçgenin b kenar uzunluğu: {0}", ucgen.B);
            Console.WriteLine("Üçgenin c kenar uzunluğu: {0}", ucgen.C);
            Console.ReadLine();
        }
    }
}
