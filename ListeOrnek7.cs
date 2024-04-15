using System;
using System.Collections.Generic;

namespace list7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci dizi uzunluğu :");
            int fDizi = Convert.ToInt32(Console.ReadLine());
            List<int> f = new List<int>();
            int[] dizi = new int[fDizi];
            dizi[0] = 1; //ilk eleman
            dizi[1] = 1; //ikinci eleman
            for (int i = 2; i < dizi.Length; i++)
            {
            dizi[i] = dizi[i - 1] + dizi[i - 2];
                if (dizi[i] % 2 == 0)
                    f.Add(dizi[i]);
              }
            Console.WriteLine("Fibonacci Dizisi");
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write(dizi[i]+" ");
                    }

            Console.WriteLine("\n\nÇift Sayılar");
                 foreach (int goster in f)
                {
                    Console.WriteLine(goster);
                }

        }
    }
}
