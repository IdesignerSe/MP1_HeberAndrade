using System;
using System.Collections.Generic;

namespace MP1_HeberAndrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemName;
            itemName = "item";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($">.............................................................<\n");
            Console.WriteLine($"       Welcomen to IDESIGNER.SE\n");

            Console.WriteLine($">.............................................................<\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"              INVENTORY        \n");
            Console.WriteLine($">..............................................................<\n");

            Console.ResetColor();
            Console.WriteLine($"Wich item are you looking for?\n\nPRESS Key to ENTER\n\nOR 'q' TO QUIT.\n");
            Console.ResetColor();

            Console.Write($"Write the name Item: ");
            itemName = Console.ReadLine();
            var item = itemName;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nYou asked for : " + " * * * " + itemName);
            Console.ResetColor();

            List<Asset> assets = new List<Asset>();

            //            2020.MacBook Pro(13 - inch, M1, 2020)...
            //2019.MacBook Pro(16 - inch, 2019)...
            //2018.MacBook Pro(15 - inch, 2018)...
            //2017.MacBook Pro(15 - inch, 2017)...
            //2016.MacBook Pro(15 - inch, 2016)...
            //2015.MacBook Pro(Retina, 15 - inch, Mid 2015)...
            //2014.MacBook Pro(Retina, 15 - inch, Mid 2014)...

            //Brand / ModelName / Date Purchase /Ini Cost /Exp. Date / Exp. Cost


            Asset asset1 = new Asset("MacBook", "Pro 2020 16 inch ", 20200101, 13000, 20230101, 4000);
            assets.Add(asset1);
            assets.Add(new Asset("MacBook", "Pro 2019 16 inch ", 20190101, 13000, 20221201, 4000));

            assets.AddRange(new List<Asset>
                        {
                            new Asset("MacBook", "Pro 2018 15 inch ", 20180101, 13000, 20211201, 8000),
                            new Asset("MacBook", "Pro 2017 15 inch ", 20170101, 10000, 20201201, 4000),

                            new Asset("Lenovo", "Pro 2018 15 inch ", 20180101, 13000, 20211201, 8000),
                            new Asset("Lenovo", "Pro 2018 15 inch ", 20180101, 13000, 20211201, 8000),
                            new Asset("Asus", "Pro 2018 15 inch ", 20180101, 13000, 20211201, 8000),
                            new Asset("Del", "Pro 2018 15 inch ", 20180101, 13000, 20211201, 8000),
                            new Asset("Acer", "Pro 2018 15 inch ", 20180101, 13000, 20211201, 8000),
                            new Asset("Acer", "Pro 2017 15 inch ", 20170101, 10000, 20201201, 4000)
                        });

            Asset asset2 = new Asset("iphone", "11 Pro ", 20200101, 13000, 20230101, 4000);
            assets.Add(asset1);
            assets.Add(new Asset("Samsung", "Galaxy S21 Ultra", 20190101, 13000, 20221201, 4000));

            assets.AddRange(new List<Asset>
                        {
                            new Asset("Samsung", "Note 20 Ultra 5G", 20190101, 13000, 20221201, 4000),
                            new Asset("Nokia", "225 4G", 20180101, 13000, 20211201, 8000),
                            new Asset("OnePlus", "8T Cyberpunk 2077", 20170101, 10000, 20201201, 4000),
                            new Asset("iPhone", "SE", 20160101, 13000, 20191201, 8000),
                            new Asset("Nokia", "215 4G", 20150101, 13000, 20181201, 8000)

                        });


            Console.WriteLine($"\n\nOur actual Inventory is : \n");
            Console.WriteLine($">......................................................................<\n");
            Console.ForegroundColor = ConsoleColor.Red;


            //Brand / ModelName / Date Purchase /Ini Cost /Exp. Date / Exp. Cost


            Console.WriteLine("Brand".PadRight(10)
                + "Model".PadRight(20)
                + "Date".ToString().PadRight(10)
                + "Cost".PadRight(9)
                + "Exp.Date".PadRight(10)
                + "Exp.Cost\n".PadRight(15));

            foreach (Asset asset in assets)
            {
                //Asset is the object of the list
                //car or asset is a temporal interna variable
                // in instruction to put in asset in assets
                //assets is the list ittself

                Console.WriteLine(asset.Brand.PadRight(10)
                    + asset.ModelName.PadRight(20)
                    + asset.PurchaseDate.ToString().PadRight(10)
                    + asset.InicialCost.ToString().PadRight(10)
                    + asset.ExpiredDate.ToString().PadRight(10)
                    + asset.ExpiredCost);

            }
            Console.ResetColor();

            Console.WriteLine($"\n\n\nENTER 'q' TO QUIT.\n");


            while (true)
            {

                string insert = Console.ReadLine();

                if (insert == "q")
                {
                    Console.WriteLine("\nBye, Thanks for your visit!\n");
                    break;
                }

                if (insert != "q")
                {
                }
            }

        }

        //Clases
        class Asset
        {
            public Asset(string brand, string modelName, int purchaseDate, int inicialCost, int expiredDate, int expiredCost)
            {
                Brand = brand;
                ModelName = modelName;
                PurchaseDate = purchaseDate;
                InicialCost = inicialCost;
                ExpiredDate = expiredDate;
                ExpiredCost = expiredCost;
            }

            public string Brand { get; set; }
            public string ModelName { get; set; }
            public int PurchaseDate { get; set; }
            public int InicialCost { get; set; }
            public int ExpiredDate { get; set; }
            public int ExpiredCost { get; set; }

        }

        class Phone
        {
            public Phone(string brand, string modelName, int purchaseDate, int inicialCost, int expiredDate, int expiredCost)
            {
                Brand = brand;
                ModelName = modelName;
                PurchaseDate = purchaseDate;
                InicialCost = inicialCost;
                ExpiredDate = expiredDate;
                ExpiredCost = expiredCost;
            }

            public string Brand { get; set; }
            public string ModelName { get; set; }
            public int PurchaseDate { get; set; }
            public int InicialCost { get; set; }
            public int ExpiredDate { get; set; }
            public int ExpiredCost { get; set; }

        }

    }
}