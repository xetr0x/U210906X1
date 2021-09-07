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
                string close = Console.ReadLine();                                    

                if ( close == "Avlsuta" || close == "avsluta" || close == "AVSLUTA" ) //If the person writes "avsluta" the program closes. 
                {
                    x = false;
                    Console.WriteLine($" Skriv ut din mening just nu är: {words}."); 
                }
                words = $"{words} {close}";  
                    

            }
        }
    }
}
