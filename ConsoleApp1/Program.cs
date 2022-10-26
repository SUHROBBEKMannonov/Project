using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 7, 11, 9 };
           var model = Solution.TwoSum(ints, 9);
            foreach (var item in model)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
        }
    }
    public class Solution
    {
        public  static  int[] TwoSum(int[] nums, int target)
        {

            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i])) ;
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }

            return new int[2];
        }
    }
}
