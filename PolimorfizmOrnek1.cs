using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizizm_örnek_1
{
    class Program
    {
        static void Main(String[] args)
        {
            // Polimorfizim = "birçok biçime sahip olmak" anlamına gelen yunanca sözcük
            // Nesneler birden fazla türle tanımlanabilir Örn. Bir Köpek aynı zamanda: Köpek, Hayvan, Organizma olabilir

            Araba araba = new Araba();
            Bisiklet bisiklet = new Bisiklet();
            Bot bot = new Bot();

            Arac[] araclar = {araba,bisiklet, bot};

            foreach(Arac arac in araclar)
            {
                arac.Go();
            }




            Console.ReadKey();
        }

        class Arac
        {
            public virtual void Go()
            {

            }
        }

        class Araba : Arac
        {
                public override void Go()
            {
                Console.WriteLine("Araba hareket ediyor");
            }
        }

        class Bisiklet : Arac
        {
            public override void Go()
            {
                Console.WriteLine("Bisiklet hareket ediyor");
            }
        }

        class Bot : Arac
        {
            public override void Go()
            {
                Console.WriteLine("Bot hareket ediyor");
            }
        }

    }
}
