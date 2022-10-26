using System;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.Speak();
            dog.Speak();
            Console.ReadKey();
        }
    }

    class Animal
    {
        public  virtual void Speak() 
        {
            Console.WriteLine("The animal goes    'Brrr brrrr'  ");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The animal goes    'Myauu'  ");
        }
    }

    class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The animal goes    'Bouww '  ");
        }
    }




}
