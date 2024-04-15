using System;

namespace dizi3
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] sayı = new int[5];
            int t = 0, c = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ".sayıyı gir: ");
                int a = Convert.ToInt32(Console.ReadLine());
                sayı[i] = a;
                if (sayı[i] % 2 == 0)
                    c++;
                else
                    t++;
            }
            foreach (int goster in sayı)
                Console.WriteLine(goster);
            Console.WriteLine("");
            Console.WriteLine("tek sayıların sayısı:" + t + " çift sayıların sayısı:" + c);
            Console.ReadLine();
       
        }
    }
}
