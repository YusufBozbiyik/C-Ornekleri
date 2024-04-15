using System;

namespace cDizi3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matris ={
                    {56,23,678,231},
                    {234,21,78,23},
                    {654,33,22,67},
                    {189,35,56,89}
                };
            int i, j, k;
            k = 0;
            double enBuyuk, enKucuk;
            enBuyuk = matris[0, 0];

            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 3; j++)
                {
                    if (matris[i, j] > enBuyuk)
                    {
                        enBuyuk = matris[i, j];
                        k = j;
                    }
                    Console.Write("[" + i + "," + j + "]=" + matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double toplam = 0;
            enKucuk = matris[0, k];
            for (i = 0; i <= 3; i++)
            {
                toplam = toplam + matris[i,k];
                if (matris[i, k] < enKucuk)
                {
                    enKucuk = matris[i, k];
                }
            }
            Console.WriteLine("En buyuk elemanin bulundugu sutundaki en kucuk sayi \t:" + enKucuk);
            Console.WriteLine("En buyuk elemanin bulundugu sutundaki sayıların toplamı :" + toplam);
            Console.ReadLine();
        }
    }
}
