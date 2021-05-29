using System;
using medianArray; // for calling module

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ma = new Class1();
            int [] nums2 = new int[] {1, 2, 3};
            int [] nums1 = new int[] {0, 1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            // Console.WriteLine(String.Join(", ", nums1));
            double medianArray = ma.FindMedianSortedArrays(nums1, nums2);
            //Console.WriteLine("The median of [{nums1}] and [{nums2}] is {medianArray}."
            Console.WriteLine("The median of [{0}] and [{1}] is {2}."
                              , String.Join(", ", nums1)
                              , String.Join(", ", nums2)
                              , medianArray
                );
        }
    }
}
