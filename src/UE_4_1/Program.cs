namespace UE_4_1;

class Program
{
    static void Main(string[] args)
    {
        string s = "Some String";
        string s2 = "Some other String";

        Console.WriteLine(".Length:");
        Console.WriteLine(" ");
        Console.WriteLine(s.Length);
        Console.WriteLine("-----");
        Console.WriteLine("[]:");
        Console.WriteLine(" ");
        char c = s[5];
        Console.WriteLine(c);
        Console.WriteLine("-----");
        Console.WriteLine(".CompareTo:");
        Console.WriteLine(" ");
        Console.WriteLine(s.CompareTo(s2));
        Console.WriteLine(s2.CompareTo(s));
        Console.WriteLine(s.CompareTo("Some String"));
        Console.WriteLine("-----");
        Console.WriteLine(".Substring:");
        Console.WriteLine(" ");
        Console.WriteLine(s.Substring(0, 4));
        Console.WriteLine(s.Substring(5));
        Console.WriteLine("-----");
        Console.WriteLine("Contains:");
        Console.WriteLine(" ");
        Console.WriteLine(s.Contains("String"));
        Console.WriteLine(s.Contains("other"));
        Console.WriteLine("-----");
        Console.WriteLine(".IndexOf:");
        Console.WriteLine(" ");
        Console.WriteLine(s.IndexOf("o"));
        Console.WriteLine(s.IndexOf("String"));
        Console.WriteLine(s.IndexOf("x"));
        Console.WriteLine("-----");
        Console.WriteLine(".LastIndexOf:");
        Console.WriteLine(" ");
        Console.WriteLine(s.LastIndexOf("S"));
        Console.WriteLine("-----");
        Console.WriteLine(".StartsWith:");
        Console.WriteLine(" ");
        Console.WriteLine(s.StartsWith("Some"));
        Console.WriteLine(s.StartsWith("String"));
        Console.WriteLine("-----");
        Console.WriteLine("EndsWith:");
        Console.WriteLine(" ");
        Console.WriteLine(s.EndsWith("String"));
        Console.WriteLine(s.EndsWith("Some"));
        Console.WriteLine("-----");
        Console.WriteLine(".ToLower:");
        Console.WriteLine(" ");
        Console.WriteLine(s.ToLower());
        Console.WriteLine("-----");
        Console.WriteLine(".ToLower:");
        Console.WriteLine(" ");
        Console.WriteLine(s.ToUpper());
        Console.WriteLine("-----");
        Console.WriteLine(".Insert:");
        Console.WriteLine(" ");
        string res = s.Insert(6, " ");
        Console.WriteLine(res);
        Console.WriteLine("-----");
        Console.WriteLine(".PadLeft:");
        Console.WriteLine(" ");
        string padl = "Something";
        Console.WriteLine(padl.PadLeft(10));
        Console.WriteLine(padl.PadLeft(10, '*'));
        Console.WriteLine("-----");
        Console.WriteLine(".PadRight:");
        Console.WriteLine(" ");
        string padr = "SomethingElse";
        Console.WriteLine(padr.PadRight(10));
        Console.WriteLine(padr.PadRight(10, '*'));
        Console.WriteLine("-----");
        Console.WriteLine(".Trim:");
        Console.WriteLine(" ");
        string s3 = "     Third String     ";
        Console.WriteLine(s3.Trim());
        Console.WriteLine("-----");
        Console.WriteLine(".TrimStart:");
        Console.WriteLine(" ");
        string s4 = "     Fourth String     ";
        Console.WriteLine(s4.TrimStart());
        Console.WriteLine("-----");
        Console.WriteLine(".TrimEnd:");
        Console.WriteLine(" ");
        string s5 = "     Fith String     ";
        Console.WriteLine(s5.TrimEnd());

    }
}
