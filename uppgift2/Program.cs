using System;

namespace uppgift2
{
    class Program
    {                                                                                                   //Låt användaren mata in en mening.
                                                                                                        // Skriv ut varje ord på en egen rad, i storleksordning (längd på ordet)
        static void Main(string[] args)                                                                 //Skriv ut varje ord på en egen rad, i omvänd ordning (baklänges) 
        {
            Console.WriteLine("Hello World!");
            string sentence = Console.ReadLine();

            char[] separators = new char[] { ' ', '.' };

            string[] subs = string.Split(separators, StringSplitOptions.RemoveEmptyEntries); 

            foreach (var sub in subs)
            {
                Console.Write($"substring: {sub}");
            }
        }
           


        }
    }
}
