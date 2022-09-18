using System;

namespace ConsoleApp55
{
    static class Ext
    {
        static public int[] HSort(this int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 4, 7, 23, 9 };
            a.HSort();
            for(int i = 0; i< a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
