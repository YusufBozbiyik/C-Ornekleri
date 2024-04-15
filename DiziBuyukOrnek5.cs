using System;

namespace cDizi5
{
    class Program
    {
        static void Main(string[] args)
        {
                double[,] dizi = new double[3,3];
                int i, j,k, sayimiz;
                sayimiz = 0;
                double fakt;
            

              for (i = 0; i <= 2; i++)
                {
                    for (j = 0; j <= 2; j++)
                    {
                    fakt = 1.0;
               
                    for (k = 1; k <= sayimiz; k++)
                        {
                        
                          fakt = fakt * k;
                        }

                        dizi[i, j] = fakt;
                        Console.Write(sayimiz + "!=" + dizi[i,j]+ "\t");
                        sayimiz = sayimiz + 1;
                    }
                Console.WriteLine();
                }
            

                     
               
               
            }

        }
    }

