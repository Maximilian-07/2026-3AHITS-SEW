// ------------------------------
// OOP
// ------------------------------

namespace OOP;

class Schule
{
    public string name; // member Variable
    public int anzahlSchueler;
    public int anzahlLehrer;
    
    public int AnzahlPersonen()
    {
        return anzahlSchueler + anzahlLehrer;
    }

    //ToString() Methode
    public override string ToString()
    {
        return $"Schule: {name}, Schüler: {anzahlSchueler}, Lehrer: {anzahlLehrer}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Schule htl = new Schule(); // Objekt erstellen (instanzieren)
        htl.name = "HTL Braunau"; // member Variable setzen
        htl.anzahlSchueler = 800;
        htl.anzahlLehrer =100;

        //Aufruf der Methode AnzahlPersonen() für Objekt htl
        Console.WriteLine($"An der {htl.name} gibt es {htl.AnzahlPersonen()} Personen.");


        // HLW
        Schule hlw = new Schule();
        hlw.name = "HLW Braunau";
        hlw.anzahlSchueler = 600;
        hlw.anzahlLehrer = 80;

        Console.WriteLine($"An der {hlw.name} gibt es {hlw.AnzahlPersonen()} Personen.");


        //----------------------------------------------

        int n = 42;
        Console.WriteLine(n);
        Console.WriteLine(htl); // automatischer Aufruf von ToString()
        Console.WriteLine(htl.ToString());
    }
}
