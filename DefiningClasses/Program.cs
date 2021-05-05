using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Bear gogi = new Bear();
            gogi.Age = 28;
            gogi.DaySinceEaten = 5;
            gogi.Name = "Gogi";


            Bear dimitrichkoBear = new Bear();
            dimitrichkoBear.Age = 28;
            dimitrichkoBear.DaySinceEaten = 2 ;
            dimitrichkoBear.Name = "Dimitrichko";

            Bear pouhbear = new Bear();
            pouhbear.Age = 25;
            pouhbear.DaySinceEaten = 5;
            pouhbear.Name = "Mecho Puh";


            Bear[] bearZoo = new Bear[3] { gogi, dimitrichkoBear, pouhbear };

            foreach (Bear bear in bearZoo)
            {
                if (bear.DaySinceEaten>=3)
                {
                    bear.Eat();
                }
            }




            Shirt calvinKlein = new Shirt();
            calvinKlein.Size = "XXXXL";
            calvinKlein.Quantity = 55;
            calvinKlein.Price = 3;

            calvinKlein.Wash();
            Console.WriteLine($"Shirt CK: Size -> {calvinKlein.Size} Quantity -> { calvinKlein.Quantity}  Price {calvinKlein.Price}");
        }
    }
}
