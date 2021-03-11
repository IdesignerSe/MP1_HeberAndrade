using System;

namespace MP1_HeberAndrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName;
            productName = "produkt";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($">.........................................<\n");
            Console.WriteLine($"       Welcomen to IDESIGNER.SE\n");

            Console.WriteLine($">.........................................<\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"              INVENTORY        \n");
            Console.WriteLine($">.........................................<\n");
            Console.ResetColor();

            Console.WriteLine($"Wich product are you looking for?\n\nPRESS Key to ENTER\n\nOR 'q' TO QUIT.\n");
            Console.ResetColor();

            Console.Write($"Write the name product: ");
            productName = Console.ReadLine();
            var product = productName;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nYou wrote : " + " * " + product);
            Console.ResetColor();

            Console.WriteLine($"\n\nENTER TO SEE OUR INVENTORY\n\nOR 'q' TO QUIT.\n");


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