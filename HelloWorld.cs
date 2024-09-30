using System; //'System' is a namespace + this is to say that we'll be using classes from that namespace

namespace NiePierwszeWyjscieZMroku //container for classes and sub-namespaces
{
    class Program //every line of code in C# must be inside a class!
    {
        static void Main(string[] args) 
        /*
         'Main' is a must-have method - anything within its curly brackets will be run
         */

        {
            Console.WriteLine("Witaj, swiecie, po raz kolejny. Emocje jak na grzybach.")
        }
        
        /* NOTE: You could also do the above by running 'System.Console.WriteLine("yourString")'
    }
}
