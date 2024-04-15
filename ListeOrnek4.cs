using System;

namespace list4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char c = 'a';
            int d = c;
            Console.WriteLine("harf :{0} sayısal değeri:{1}",c,d);
                int sonuc = d - 32;
            c = (char)sonuc;
            Console.WriteLine("harf :{0} sayısal değeri:{1}", c, sonuc);          
            Console.ReadLine(); 
            

        }
    }
}
