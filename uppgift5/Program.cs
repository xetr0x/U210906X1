using System;

namespace uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {

             bool x = true;
            while (x == true)  
                
            {
                Console.WriteLine("skriv Avsluta för att avsluta");
                string close = Console.ReadLine();                                    

                if ( close == "Avlsuta" || close == "avsluta" || close == "AVSLUTA" ) //If the person writes "avsluta" the program closes. 
                {
                    x = false;
                }
                
                else
                {
                    x = true;
                    return new[] { close };
                }

            }
        }
    }
}
