using System;

namespace cDizi4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matris ={
                {56,23,678,231},
                {234,21,78,26},
                {654,33,32,67},
                {189,35,56,89}
            };
            int i, j, k;
            k = 0;
            int temp = 0;
            int[] tekSayilar = new int[16];
            // tek sayılar
            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 3; j++)
                {
                    if (matris[i, j] %2!=0)
                    {
                        tekSayilar[k] = matris[i, j];
                        k++;
                    }
                    Console.Write("[" + i + "," + j + "]=" + matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Tek sayilardan olusan dizi:");
            for (i = 0; i < k-1; i++)
            {
                Console.Write(tekSayilar[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //diziyi sıralayalım
            for (i = 0; i < tekSayilar.Length; i++)
            {
                for (j = 0; j < tekSayilar.Length; j++)
                {
                    if (tekSayilar[i] > tekSayilar[j])
                    {
                        temp = tekSayilar[i];
                        tekSayilar[i] = tekSayilar[j];
                        tekSayilar[j] = temp;
                    }
                }
            }
            Console.WriteLine("Tek sayilardan olusan dizinin siralanmis hali:");
            for (i = k - 1; i >= 0; i--)
            {
                Console.WriteLine(tekSayilar[i] + "\t");
            }
        }
    }
}
