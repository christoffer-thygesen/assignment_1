using System;
using System.Collections.Generic;

namespace CarGame
{
    public class Hand
    {
        public List<Car> CardsHolding { get; set; }

        public Hand(List<Car> cardsHolding)
        {
            CardsHolding = new List<Car>();
            DealHandThreeCards(cardsHolding);
        }

        public List<Car> TopSpeedGreaterThan(int topSpeed)
        {
            List<Car> tmp = new List<Car>();

            foreach (Car car in CardsHolding)
            {
                if (car.TopSpeed > topSpeed)
                {
                    tmp.Add(car);
                }
            }

            return tmp;
        }

        public void DealHandThreeCards(List<Car> list)
        {
            Random rnd = new Random();
            List<Car> tmp = list;

            for (int i = 0; i < 3; i++)
            {
                int num = rnd.Next(0, list.Count - 1);
                CardsHolding.Add(tmp[num]);
                tmp.Remove(tmp[num]);

            }
        }

        public void PrintHand()
        {
            foreach (var car in CardsHolding)
            {
                Console.WriteLine("\t "+car.Name);
                Console.WriteLine("km/h\t\t" + car.TopSpeed);
                Console.WriteLine("PS/kW\t\t" + car.HorsePower.Item1+"/"+car.HorsePower.Item2);
                Console.WriteLine("U/min\t\t" + car.Rpm);
                Console.WriteLine("ccm\t\t" + car.EngineSize);
                Console.WriteLine("0-100 km/h\t" + car.RampSpeed);
                Console.WriteLine("Cylinders\t"+car.Cylinders);
                Console.WriteLine("");
            }
        }
    }
}