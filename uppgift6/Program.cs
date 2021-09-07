using System;

namespace uppgift6
{
    class program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vilket tal mellan 1 och 21 tänker jag på? ");
            Random rnd = new Random();
            int number = rnd.Next(1, 21);
            bool x = true;
            while (x == true)
            {
                int anwser = Convert.ToInt32(Console.ReadLine()); 

                if (anwser == number )
                {
                    Console.WriteLine($"bra gissat, du svarade rätt, talet är {number}");
                    x = false;
                }
                else
                {
                    Console.WriteLine("försök igen! "); 
                }

            }
        }

    }
}
