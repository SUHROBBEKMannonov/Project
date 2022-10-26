using System;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("Mustang", "red");
          //  ChangeColor(Car1, "Pink");
            Car Car2 = Copy(Car1);
            
            Console.WriteLine(Car2.Color + "  " + Car2.Model);
            Console.ReadKey();

        }

        public static void ChangeColor(Car car, string color)
        {
            car.Color = color;
          
        }

        public static Car Copy(Car car)
        {
            return new Car(car.Model, car.Color);
        }
    }


    class Car 
    {
        public string Model;
        public string Color;
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }
        
    }
}
