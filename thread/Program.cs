using System;
using System.Threading;

namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);
            Thread Thread1 = new Thread(CountUp);
            Thread Thread2 = new Thread(CountDown);
            Thread1.Start();
            Thread2.Start();
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #1 : {i} seconds;");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer is complete!!!");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Timer #2 : {i} seconds;");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer is complete!!!");
        }



    }      
    
}
