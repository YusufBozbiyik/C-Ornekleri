using System;

namespace metot7
{
    class Program
    {
        //fibonacci(0)=1
        //fibonacci(1)=1
        //fibonacci(2)=2
        //fibonacci(3)=3
        //fibonacci(4)=5
        static int fibonacci(int sayi)
        {
            if (sayi<2)
                return 1;
            else
                return fibonacci(sayi - 1) + fibonacci(sayi - 2);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("değeri girin : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.WriteLine("\n" + fibonacci(i));
            Console.ReadKey();
        }
    }
}

