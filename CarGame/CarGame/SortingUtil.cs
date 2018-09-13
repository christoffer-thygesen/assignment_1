using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarGame
{
    public static class SortingUtil
    {
        public static List<Car> SortByTopSpeed(this List<Car> list)
        {
            return list.OrderBy(x => x.TopSpeed).ToList();
        }

        public static List<Car> SortByCylinders(this List<Car> list)
        {
            return list.OrderBy(x => x.Cylinders).ToList();
        }

        public static List<Car> SortByEngineSize(this List<Car> list)
        {
            return list.OrderBy(x => x.EngineSize).ToList();
        }

        public static List<Car> SortByHorsePower(this List<Car> list)
        {
            return list.OrderBy(x => x.HorsePower).ToList();
        }

        public static List<Car> SortByName(this List<Car> list)
        {
            return list.OrderBy(x => x.Name).ToList();
        }

        public static List<Car> SortByRampSpeed(this List<Car> list)
        {
            return list.OrderBy(x => x.RampSpeed).ToList();
        }

        public static List<Car> SortByRpm(this List<Car> list)
        {
            return list.OrderBy(x => x.Rpm).ToList();
        }
    }
}
