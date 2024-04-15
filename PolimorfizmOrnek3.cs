using System;

class Calisan
{
    private string _calisanAd;
    private double _calisanMaas;

    public string CalisanAd
    {
        get { return _calisanAd; }
        set { _calisanAd = value; }
    }

    public double CalisanMaas
    {
        get { return _calisanMaas; }
        set { _calisanMaas = value; }
    }

    public virtual void ZamYap(double zamMiktar)
    {
        _calisanMaas += zamMiktar;
    }
}
class Yonetici : Calisan
{
    private double _departmanKar;

    public double DepartmanKar
    {
        get { return _departmanKar; }
        set { _departmanKar = value; }
    }

    public override void ZamYap(double zamMiktar)
    {
        if (DepartmanKar > 50000)
        {
            zamMiktar += 2000;
        }
        base.ZamYap(zamMiktar);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Yonetici yonetici = new Yonetici();
        yonetici.CalisanAd = "Fatih Alkan";
        yonetici.CalisanMaas = 8500;
        yonetici.DepartmanKar = 53000;

        Console.WriteLine("Yönetici Adı: {0} Maaşı: {1}, Departman Karı: {2}", yonetici.CalisanAd.ToString(), yonetici.CalisanMaas.ToString(), yonetici.DepartmanKar.ToString());

        yonetici.ZamYap(1500);

        Console.WriteLine("Zamlı Maaş: {0}", yonetici.CalisanMaas);

        Console.Read();
    }
}
