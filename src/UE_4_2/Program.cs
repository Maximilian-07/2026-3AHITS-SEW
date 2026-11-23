namespace UE_4_1;

class Program
{
    static public string ReverseString(string str)
    {
        string revstr = "";
        char c = ' ';

        for(int i = str.Length ; i>0 ; i--)
        {
            c = str[i-1];
            revstr = revstr + c;
        }

        return revstr;
    }

    static void Main(string[] args)
    {
        string str = "bretzl";
        string revstr = ReverseString(str);
        Console.WriteLine(str);
        Console.WriteLine(revstr);
    }
}
