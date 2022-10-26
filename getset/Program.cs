using System;

namespace getset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1000000000);
            Console.WriteLine(car.Speed);




        }
    }

    class Car
    {
        private int speed;

        public Car(int Speed)
        {
            this.Speed = Speed;
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 500) 
                { 
                    speed = 500;
                }
                else
                {
                    speed = value; 
                }

            } 
        }
    }
}
