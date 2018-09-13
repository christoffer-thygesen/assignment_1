using System;
using System.Collections.Generic;
using System.Linq;

//Christoffer Thygesen
namespace CarGame
{
    class Program
    {
        private static void Main(string[] args)
        {
            String porsche = "Porsche";
            List<Car> carMag = new List<Car>
            {
                new Car(porsche+" 911", 230, new Tuple<int, double>(300, 225.5), 5900, 2994, 6.0, 6),
                new Car(porsche+" 912", 222, new Tuple<int, double>(290, 236.2), 6000, 3400, 5.0, 8),
                new Car(porsche+" 913", 259, new Tuple<int, double>(310, 254.4), 5800, 2800, 7.4, 4),
                new Car(porsche+" 914", 141, new Tuple<int, double>(320, 262.6), 5800, 2750, 6.0, 6),
                new Car(porsche+" 915", 173, new Tuple<int, double>(315, 215.8), 6100, 3290, 8.0, 9),
                new Car(porsche+" 916", 290, new Tuple<int, double>(285, 226.3), 5740, 3109, 7.9, 4),
                new Car(porsche+" 917", 283, new Tuple<int, double>(295, 252.2), 5800, 2987, 7.4, 10),
                new Car(porsche+" 918", 388, new Tuple<int, double>(300, 261.1), 6050, 2960, 5.9, 4),
                new Car(porsche+" 919", 832, new Tuple<int, double>(300, 273.6), 6200, 3340, 6.9, 6),
                new Car(porsche+" 920", 130, new Tuple<int, double>(310, 315.6), 5790, 3180, 7.2, 8),
                new Car(porsche+" 921", 230, new Tuple<int, double>(320, 261.5), 5840, 3200, 6.3, 4),
                new Car(porsche+" 922", 254, new Tuple<int, double>(290, 225.8), 5990, 2999, 6.0, 6)
            };

            bool isValid = false;

            BeginGame(isValid);

            Hand player = new Hand(carMag);

            //CPU player with rest of cards
            List<Car> cardsLeft = carMag.Except(player.CardsHolding).ToList();
            Hand player2 = new Hand(cardsLeft);

            Console.WriteLine("Here is your hand:");
            player.PrintHand();


            //now to make selection switch to choose cards and car features
        }

        private static void BeginGame(bool isValid)
        {
            do
            {
                Console.WriteLine("Would you like to start a new game? Y/N?");

                switch (Console.ReadLine().ToLower())
                {
                    case "yes":
                        Console.WriteLine("Nice!");
                        Console.WriteLine("[Hit enter to start]");
                        Console.ReadKey();
                        Console.Clear();
                        isValid = true;
                        break;

                    case "y":
                        Console.WriteLine("Nice!");
                        Console.WriteLine("[Hit enter to start]");
                        Console.ReadKey();
                        Console.Clear();
                        isValid = true;
                        break;

                    case "n":
                        Console.WriteLine("I'm going to start one anyway!");
                        Console.WriteLine("[Hit enter to start]");
                        Console.ReadKey();
                        Console.Clear();
                        isValid = true;
                        break;

                    case "no":
                        Console.WriteLine("I'm going to start one anyway!");
                        Console.WriteLine("[Hit enter to start]");
                        Console.ReadKey();
                        Console.Clear();
                        isValid = true;
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (!isValid);
        }
    }
}
