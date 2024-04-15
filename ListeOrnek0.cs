using System;
using System.Collections;

namespace aList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Bilişim"); // Metinsel
            liste.Add(100); // Tam sayı
            liste.Add('m'); // Karakter 
            liste.Add(3.14); // Ondalık sayı
            liste.Add(true); // Mantıksal

            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
            Console.ReadLine();
        }
    }
}
