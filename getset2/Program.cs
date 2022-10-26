using System;

namespace getset2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Porsche");
            Console.WriteLine(car.Model);
        }

        class Car
        {
            public string Model { get; set; }
            public Car(string model)
            {
                this.Model = model;
              
            }
        }
    }
}
