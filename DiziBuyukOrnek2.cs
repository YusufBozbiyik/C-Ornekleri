using System;

namespace cDizi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[3];
            int[,] notlar = new int[3, 4];


            int i, j;
            for (i = 0; i < 3; i++)
            {
                Console.Write(i + 1 + ". isim:");
                isimler[i] = Console.ReadLine();

                for (j = 0; j < 4; j++)
                {

                    Console.Write(j + 1 + ". sınav:");
                    notlar[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

            }

            for (i = 1; i <=4; i++)
            {
                Console.Write("\t"+i+". Not");
            }

            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {

                Console.Write(isimler[i] + "\t");

                for (j = 0; j < 4; j++)
                {

                    Console.Write(notlar[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
