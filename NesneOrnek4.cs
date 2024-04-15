using System;

namespace nesne5
{
    public class Ucgen
    {
        int a, b, c;
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public int Cevre
        {
            get
            {
                return a + b + c;
            }
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 3;
            ucgen.B = 4;
            ucgen.C = 5;
          //ucgen.Cevre = 12;
            Console.WriteLine("Üçgenin çevresi: {0}", ucgen.Cevre);
        }
    }
}
