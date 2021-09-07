using System;

namespace uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {

             bool x = true;
            while (x == true)  //crash 
                
            {
                Console.WriteLine("skriv Avsluta för att avsluta");
                string close = Console.ReadLine();

                if ( close == "Avlsuta" && close == "avsluta" && close == "AVSLUTA" )
                {
                    x = false;
                }
                
                else
                {
                    x = true;
                }

            }
        }
    }
}
