using System;

namespace  interfaces
{
    internal class Program
{
    static void Main(string[] args)
    {
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();

            hawk.Hunt();
            rabbit.Flee();

            Fish fish = new Fish();

            fish.Hunt();
            fish.Flee();

            


    }   
    interface IPrey
        {
            void Flee();
        }
    interface IPredator
    {
            void Hunt();
    }
        class Hawk: IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching  for  food!");

            }

        }

        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit suns away!");
            }

        }
        class Fish : IPredator, IPrey
        {      
            public void Hunt()
            {
                Console.WriteLine("The fish searching for new smaller fish !");
            }
            public void Flee() {

                Console.WriteLine("The fish swims away!");
            }


        }




    }
}  

    
    

   
