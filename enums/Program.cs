using System;

namespace enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume = Volume(PlanetsRadius.Earth);
            Console.WriteLine("Planet: " + Planets.Earth);
            Console.WriteLine("Radius:  " + (int)PlanetsRadius.Earth);
            Console.WriteLine("Volume: "+ volume);

             
            


        }
        public static double Volume(PlanetsRadius radius)
            {
                double Volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
                return Volume;

            }

    }
    enum Planets
        {
            Mercury=1,
            Venus=2,
            Earth=3,
            Mars=4,
            Jupiter=5,
            Saturn=6,
            Uranus=7,
            Neptune=8,
            Pluto=9
        }
        enum PlanetsRadius {
            Mercury = 5461,
            Venus = 9892,
            Earth = 54546,
            Mars = 878712,
            Jupiter = 5464985,
            Saturn = 84884845,
            Uranus = 878452127,
            Neptune = 4654658,
            Pluto = 96546545,
       

    }
}
