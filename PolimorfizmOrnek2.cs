using System.Runtime.CompilerServices;

void HayvanSesiCikar(Hayvan hayvan)
{
    hayvan.SesCikar();
}

Hayvan hayvan = new Hayvan();
Köpek köpek = new Köpek();
Kedi kedi = new Kedi();
Kuş kuş = new Kuş();

HayvanSesiCikar(hayvan);
HayvanSesiCikar(köpek);
HayvanSesiCikar(kedi);
HayvanSesiCikar(kuş);

class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Genel Hayvan Sesi : ");
    }
}

class Köpek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav Hav");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav ");    
    }
}

class Kuş : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Cik Cik");
    }
}
