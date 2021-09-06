using System;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. låt användaren mata in en mening
            //2. skriv ut antal ord
            //3. skriv ut varje ord på egen rad med antal tecken i ordet, 

            Console.WriteLine("skriv en mening: "); //skriv mening
             string sentence = Console.ReadLine();

            int wordcount = 0;
            //loopa genom strängen
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                //räknar alla mellanslag i strängen
                if (sentence[i] == ' ' && char.IsLetter(sentence[i + 1]) && (i > 0))
                {
                    wordcount++;
                }
            }
            //lägg till 1 för att räkna sista ordet
            wordcount++;

            Console.WriteLine($"antalet ord i meningen är:{wordcount}");

            string[] sub = sentence.Split(' ');     // splittar upp meningen i ord med hjälp av spaces.
            foreach (var word in sub)               // för varje space emellan så skriver den ut tecken
            {
                Console.WriteLine($"{word} ({word.Length})"); // skriver ut ordet och anta tecken i den.
            }

        }
    }
}
