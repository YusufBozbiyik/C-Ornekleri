using System;

namespace cDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] satis = new int[,]
            {
                {700,600,650},
                {900,800,700},
                {300,400,350},
                {500,450,470},
                {600,500,480}
            };
            int i, j;

            string [] marka ={"Ford " ,"Fiat ","Opel " ,"Honda ", "BMW "};
            string[] ay = { "Ocak ", "Şubat ", "Mart" };

           
            int markaSatis;
            int aylikSatis ;
            int toplamSatis ;

            for (int k = 0; k < 3; k++)
            { 
                Console.Write("\t"+ay[k]);

            }
            Console.WriteLine();

            for (i = 0; i < 5; i++)
            {

                Console.Write(marka[i]+"\t");

                for (j = 0; j < 3; j++)
                {
                    
                    Console.Write(satis[i, j] + "\t");
                }
                Console.WriteLine();

            }


            //Her marka için 3 aylık satış toplamlarını
            Console.WriteLine("\n MARKALARIN TOPLAM SATIŞLARI");
            for (i = 0; i < 5; i++)
            {
                markaSatis = 0;
                for (j = 0; j < 3; j++)
                    markaSatis = markaSatis + satis[i,j];
                Console.WriteLine(marka[i] + " \ttoplam satisi: " + markaSatis);
            }

            //Aylık Satışlar
            Console.WriteLine("\nAYLIK SATIŞLAR");
            toplamSatis = 0;
            for (j = 0; j < 3; j++)
            {
                aylikSatis = 0;
                for (i = 0; i < 5; i++)
                {

                    toplamSatis = toplamSatis + satis[i,j];
                    aylikSatis = aylikSatis + satis[i,j];
                }
                Console.WriteLine(ay[j]+ " ayında 5 markanın toplam satis miktari:\t"+aylikSatis);
               
            }

            //Toplam Satışlar
            Console.WriteLine("\nTOPLAM SATIŞ");
            Console.WriteLine("5 marka icin toplam satis miktari :\t\t" + toplamSatis);

            //"MARKALARIN EN ÇOK SATIŞ YAPTIĞI AY"
            Console.WriteLine("\nMARKALARIN EN ÇOK SATIŞ YAPTIĞI AY");
            string bAy; 
            int enbuyuk=0;
            for (i = 0; i < 5; i++)
            {
                enbuyuk=satis[i, 0];
                bAy = "";
                for (j = 0; j < 3; j++)
                {
                    if (satis[i, j] >= enbuyuk)

                    {
                        enbuyuk = satis[i, j];
                        bAy = ay[j];
                    }
                      
                }

                Console.WriteLine(marka[i] + "Markasının En çok Sattığı\tAy: " + bAy+ "\tSatış Adedi:" + enbuyuk);
            }
            //Her ay için en çok satışın gerçekleştirildiği marka hangisidir 
            Console.WriteLine("\nHER AY EN ÇOK SATIŞIN GERÇEKLEŞTİRİLDİĞİ MARKA");
            string bMarka;
            int enBuyukMarka = 0;
            for (j = 0; j < 3; j++)
            {
                enBuyukMarka = satis[0,j];
                bMarka = "";
                for (i = 0; i < 5; i++)
                {

                    if (satis[i, j] >= enBuyukMarka)

                    {
                        enBuyukMarka = satis[i, j];
                        bMarka = marka[i];
                    }
                }
                Console.WriteLine(ay[j] + " Ayının En çok Sattığı\tMarka: " + bMarka + "\tSatış Adedi:" + enBuyukMarka);
            }


        }
    }
}

