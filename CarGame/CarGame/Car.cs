using System;

namespace CarGame
{
    public class Car
    {
        public string Name { get; set; }
        public int TopSpeed { get; set; } //km/h
        public Tuple<int,double> HorsePower { get; set; }
        //public double HorsePower { get; set; } // PS/kW
        public int Rpm { get; set; } // U/min
        public int EngineSize { get; set; } // ccm
        public double RampSpeed { get; set; } // 0-100 km/h, measured in seconds
        public int? Cylinders { get; set; } //no. of cylinders in engine

        public Car(string name, int topSpeed, Tuple<int, double> horsePower, int rpm, int engineSize, double rampSpeed, int cylinders)
        {
            Name = name;
            TopSpeed = topSpeed;
            HorsePower = horsePower;
            Rpm = rpm;
            EngineSize = engineSize;
            RampSpeed = rampSpeed;
            Cylinders = cylinders;
        }
    }
}
