using System;
using System.Collections.Generic;

namespace list5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> tKar = new List<char> {'ö','ç','ş','ı','ğ','ü','i'};

            List<char> tKar2 = new List<char>();
            Console.WriteLine("Metni giriniz");  
            string cumle = Console.ReadLine();
            int sonuc = 0;


            for (int i = 0; i < cumle.Length; i++)    
            {
                char c = cumle[i];
                int d = c;

                if (c == 'ö')
                {
                    sonuc = 214;
                    tKar2.Add(cumle[i]);
                }

                else if (c == 'ç')
                {
                    sonuc = 199;
                    tKar2.Add(cumle[i]);
                }

                else if (c == 'ş')
                {
                    sonuc = 350;
                    tKar2.Add(cumle[i]);
                }

                else if (c == 'ı')
                {
                    sonuc = 73;
                    tKar2.Add(cumle[i]);
                }

                else if (c == 'ğ')
                {
                    sonuc = 286;
                    tKar2.Add(cumle[i]);
                }
                else if (c == 'ü')
                {
                    sonuc = 220;
                    tKar2.Add(cumle[i]);
                }
                else if (c == 'i')
                {
                    sonuc = 304;
                    tKar2.Add(cumle[i]);
                }
                else if (c != ' ')
                    sonuc = d - 32;
                else
                    sonuc = d;

                Console.Write((char)sonuc); 
            
            }
            Console.WriteLine();
            foreach (char goster in tKar2)
            {
                Console.WriteLine(goster);
            }
            Console.ReadLine(); 
        }
    }
}
