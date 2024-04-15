using System;

namespace nesne6
{
    public class Ucgen
    {
        int a;
        int b;
        int c;
        public int A
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı bilgi");
                else
                    a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı bilgi");
                else
                    b = value;
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı bilgi");
                else
                    c = value;
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
           //Console.WriteLine("A kenar uzunluğu: {0}", ucgen.A);
            Console.WriteLine("B kenar uzunluğu: {0}", ucgen.B);
            Console.WriteLine("C kenar uzunluğu: {0}", ucgen.C);
        }
    }

}
