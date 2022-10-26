using System;

namespace Leet1
{
    public class Solution
    {
        public int[] sums;
        public int target;
        public Solution(int[] sums, int target)
        {
            this.sums = sums;
            this.target = target;
        }
        public  int[] TwoSum()
        {
            for (int i=0; i < sums.Length; i++)
            {
                for (int j = 0; j < sums.Length; j++)
                {
                    if (sums[i] + sums[j]==target && i != j)
                    {
                        int[] arr = { i, j };
                        return arr;
                    }
                }
            }
            return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 5, 2, 3, 8, 10 };
            int taget = 11;
            Solution solution1 = new Solution(ints, taget);
           
            foreach (int item in solution1.TwoSum())
            {
                Console.Write(item+"; ");
            }

        }
    }
}
