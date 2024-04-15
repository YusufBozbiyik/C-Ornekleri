using System;
using System.Collections.Generic;

namespace list6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni giriniz");  
            string cumle = Console.ReadLine();  
            for (int i = 0; i < cumle.Length; i++)   
            {
                char c = cumle[i]; 
                int d = c;        
                int sonuc = d - 32;
                Console.Write((char)sonuc); 
            }
            Console.ReadKey(); 

        }
    }
}
