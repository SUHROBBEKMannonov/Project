using System;

namespace Palindrome
{
    internal class Program
    {
        public static bool palindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int y = 0;
            int temp = x;
            while (temp != 0)
            {
                y = y * 10 + temp % 10;
                temp = temp / 10;
            }

            if (y == x)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(palindrome(1212121));
        }

        
    }
}
