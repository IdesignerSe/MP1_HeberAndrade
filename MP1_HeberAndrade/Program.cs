using System;

namespace MP1_HeberAndrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($">.........................................<\n");
            Console.WriteLine($"       Welcomen to IDESIGNER.SE\n");

            Console.WriteLine($">.........................................<\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"              INVENTORY        \n");
            Console.WriteLine($">.........................................<\n");

            Console.WriteLine($"What product are you looking for? :\n\nPRESS Key ENTER\n\nOR 'q' TO QUIT.\n");
            Console.ResetColor();

            Console.Write($" Write the name of the product looking for: ? : ");
            productName = Console.ReadLine();

            while (true)
            {

                string insert = Console.ReadLine();

                if (insert == "q")
                {
                    Console.WriteLine("\n\nBye, Thanks for your visit!\n\n");
                    break;
                }

                if (insert != "q")
                {

                }
            }
        }
    }
}