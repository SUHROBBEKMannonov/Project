using System;
using System.Collections.Generic;

namespace Roma
{
    
       
    
    internal class Program
    {
        public static int RomaToInt(string x)
        {
            if (x == string.Empty || x == null)
            {
                return 0;
            }

            Dictionary<string,int> disc=new Dictionary<string,int>();
            int result = 0;
            disc.Add("I", 1);
            disc.Add("V", 5);
            disc.Add("X", 10);
            disc.Add("L", 50);
            disc.Add("C", 100);
            disc.Add("D", 500);
            disc.Add("M", 1000);
            disc.Add("IV", 4);
            disc.Add("IX", 9);
            disc.Add("XL", 40);
            disc.Add("XC", 90);
            disc.Add("CD", 400);
            disc.Add("CM", 900);


            for (int i = 0; i < x.Length; i++)
                if ((x[i] == 'I' || x[i] == 'X' || x[i] == 'C') && i < x.Length - 1 && disc.ContainsKey(x.Substring(i, 2)))
                {
                    Console.WriteLine(i);
                    result += disc[x.Substring(i+x+, 2)];
                    Console.Write(i);
                }

                else
                {
                    Console.WriteLine(i);
                    result += disc[x[i].ToString()];
                }
        
            return result;


        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomaToInt("MCMXCIV"));
            string aa= "MCMXCIV";
            Console.WriteLine(aa.Substring(2,2));



        }
    }
}
