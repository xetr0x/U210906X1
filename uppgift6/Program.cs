using System;

namespace uppgift6
{
    class program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vilket tal mellan 1 och 21 tänker jag på? ");
            Random rndnr = new Random();      //beskriver att rnd ska ge en ny random siffra varje gång.
            int number = rndnr.Next(1, 22);  //väljer en random siffra mellan 1 och 21
            while (true)
            {
                int anwser = Convert.ToInt32(Console.ReadLine()); //Man skriver in numret och den convertar den från string till int

                if (anwser == number )
                {
                    Console.WriteLine($"bra gissat, du svarade rätt, talet är {number}");
                    break;  //Hela loopen "breakas" och därmed avslutas om kravet i if satsen uppnås
                }
                else
                {
                    Console.WriteLine("försök igen! "); //meddelar att svaret var fel
                }

            }
        }

    }
}
