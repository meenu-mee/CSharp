using System;

namespace SearchStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye")); //true
            Console.WriteLine(songLyrics.Contains("greetings")); //false
            Console.WriteLine(songLyrics.StartsWith("You")); //true
            Console.WriteLine(songLyrics.EndsWith("hello")); //true
            
        }
    }
}
