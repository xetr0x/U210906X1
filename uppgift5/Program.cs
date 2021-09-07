using System;

namespace uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = " ";
             bool x = true;
            while (x == true)  
                
            {
                Console.WriteLine("skriv Avsluta för att avsluta");
                string close = Console.ReadLine();                              //personen matar in ordet eller avsluta.        

                if ( close == "Avlsuta" || close == "avsluta" || close == "AVSLUTA" ) //If the person writes "avsluta" the program closes. 
                {
                    x = false;                                                          // om if satsen går igenom, slutar x vara true och med det avslutar loopen. 
                    Console.WriteLine($" Skriv ut din mening just nu är: {words}."); // skriver ut meningen med alla inmatade ord. 
                }
                words = $"{words} {close}";         //håller koll på alla ord. 
                    

            }
        }
    }
}
