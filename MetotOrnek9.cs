using System;

namespace metot9
{
    class Program
    {

        static int usAl(int taban, int us)
        {
            //3^4 = 3 * 3^3 bilgisi ve 3^0 = 1 bilgisinden faydanalarak
            //Benzer şekilde yapılabilir
            if (us == 0)
                return 1;
            return taban * usAl(taban, us - 1);
        }
    
   static void Main(string[] args)
    {
        int t, u;
        Console.Write("Taban :");
        t = Convert.ToInt32(Console.ReadLine());
        Console.Write("Üs :");
        u = Convert.ToInt32(Console.ReadLine());
        int sonuc=usAl(t,u);
        Console.WriteLine(sonuc);
        Console.ReadLine();
    }
}
}
