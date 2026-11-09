
class Konto
{
    public double Kontostand;
    public double Zinssatz;
    public string Kontoinhaber;

    public override string ToString()
    {
        return $"Kontoinhaber: {Kontoinhaber}, Kontostand: {Kontostand}, Zinssatz: {Zinssatz}";
    }

    //Konstruktor
    public Konto(double Ks, double Zs, string name)
    {
        Kontostand = Ks;
        Zinssatz = Zs;
        Kontoinhaber = name;
    }

    //Methode Ein
    public double Ein(double Einzahlung)
    {
        return Kontostand += Einzahlung;
    }

    //Methode Aus
    public double Aus(double Abbuchung)
    {
        return Kontostand -= Abbuchung;
    }
}
