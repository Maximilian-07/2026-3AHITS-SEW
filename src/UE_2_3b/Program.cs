// ------------------------------
// UE_2_3b
// ------------------------------

namespace UE_2_3b;

class Program
{
    static void Main(string[] args)
    {
        Konto XXX1 = new Konto(0, 0, "");
        XXX1.Kontoinhaber = "Emilia Green";
        XXX1.Kontostand = 6000;
        XXX1.Zinssatz = 1.2;

        Konto XXX2 = new Konto(8900, 1.3, "Alicia Oakheart");

        Console.WriteLine(XXX1.ToString()); //ToString Aufruf
        Console.WriteLine(XXX2.ToString()); //ToString Aufruf
        
    }
  
}
