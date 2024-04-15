using System;
using System.Collections.Generic;

namespace list1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> gunler = new List<string>(); //List tanımlama

            //listeye eleman ekleme
            gunler.Add("pazartesi");
            gunler.Add("salı");
            gunler.Add("cumartesi");

            //listeyi ters çevirme
            gunler.Reverse();

            //listeden eleman silme
            gunler.Remove("salı");

            gunler.RemoveAt(0);

            // temizleme
            gunler.Clear();

            //listenin eleman sayısını öğrenme
            Console.WriteLine("eleman sayısı:{0}", gunler.Count);
            foreach (string eleman in gunler)
            {

                Console.WriteLine(eleman);
            }
        }
    }
}
