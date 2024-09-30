/* Variable types in C#: 
- int (integers),
- double (floating point numbers, e.g. 19.99),
- char (single characters, ''),
- string (text, ""),
- bool (booleans) */

internal class Program
{
    private static void Main(string[] args)
    {
        //string variable
        string name = "moi";
        Console.WriteLine(name);

        //Assigning new value to existing variable overwrites the previous value:
        int myNum = 15;
        myNum = 20;
        Console.WriteLine(myNum); //prints '20'
    }
}