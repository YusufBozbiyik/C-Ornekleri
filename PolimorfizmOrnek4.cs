using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizim_örnek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Sepet sepet = new Sepet();
            Ekmek ekmek = new Ekmek("Uno", 10, "Kepekli", 100);
            sepet.Ekle(ekmek);
            Console.WriteLine(sepet.ToplamTutar().ToString());

            Console.ReadLine();
        }
        

        public class Urun
        {
            public string Urunadi { get; set; }
            public double Fiyat { get; set; }
            public virtual double KDVuygula()
            {
                return Fiyat * 1.88;
            }

            public Urun()
            { }
            public Urun(string ad, double fiyat)
            {
                Urunadi = ad;
                Fiyat = fiyat;
            }
        }

        public class Tekstil : Urun
        {
            public string KumasTuru { get; set; }
            public int Beden { get; set; }
            public string UreticiFirma { get; set; }

            public Tekstil(string ad, double fiyat, string kumasTuru, int beden)
            {
                Urunadi = ad;
                Fiyat = fiyat;
                KumasTuru = kumasTuru;
                Beden = beden;
            }
        }

        public class CepTelefonu : Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }

            public CepTelefonu(string ad, double fiyat, string marka)
            {
                Urunadi = ad;
                Fiyat = fiyat;
                Marka = marka;
            }
        }
        public class Ekmek : Urun
        {
            public string EkmekTuru { get; set; }
            public int Gramaj { get; set; }

            public Ekmek(string urunAdi, double fiyat, string ekmekTuru, int gramaj)
            {
                Urunadi = urunAdi;
                Fiyat = fiyat;
                EkmekTuru = ekmekTuru;
                Gramaj = gramaj;
            }
            public override double KDVuygula()
            {
                return Fiyat * 1.01;
            }
        }

        public class Sepet
        {
            private List<Urun> urunler = new List<Urun>();
            public double ToplamTutar()
            {
                double toplamFiyat = 0;
                foreach (Urun item in urunler)
                {
                    toplamFiyat += item.KDVuygula();
                }
                return toplamFiyat;
            }
            public void Ekle(Urun yeniUrun)
            {
                urunler.Add(yeniUrun);
            }
        }

        

    } 
    
}
