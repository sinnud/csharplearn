/*
unit test

Compute median of two sorted arrays

https://leetcode.com/problems/median-of-two-sorted-arrays/
*/
using System;
using Xunit;

using medianArray; // test module name

namespace MyTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_medianArray_ex1()
        {
            Class1 ma = new Class1();
            int [] nums1 = new int[] {1, 3};
            int [] nums2 = new int[] {2};
            Assert.Equal(2.0, ma.FindMedianSortedArrays(nums1, nums2));
        }
        [Fact]
        public void Test_medianArray_ex2()
        {
            Class1 ma = new Class1();
            int [] nums1 = new int[] {1, 2};
            int [] nums2 = new int[] {3, 4};
            Assert.Equal(2.5, ma.FindMedianSortedArrays(nums1, nums2));
        }
        [Fact]
        public void Test_medianArray_ex3()
        {
            Class1 ma = new Class1();
            int [] nums1 = new int[] {0, 0};
            int [] nums2 = new int[] {0, 0};
            Assert.Equal(0.0, ma.FindMedianSortedArrays(nums1, nums2));
        }
        [Fact]
        public void Test_medianArray_ex4()
        {
            Class1 ma = new Class1();
            int [] nums1 = new int[] {};
            int [] nums2 = new int[] {1};
            Assert.Equal(1.0, ma.FindMedianSortedArrays(nums1, nums2));
        }
        [Fact]
        public void Test_medianArray_ex5()
        {
            Class1 ma = new Class1();
            int [] nums1 = new int[] {2};
            int [] nums2 = new int[] {};
            Assert.Equal(2.0, ma.FindMedianSortedArrays(nums1, nums2));
        }
        [Fact]
        public void Test_medianArray_ex6()
        {
            Class1 ma = new Class1();
            int [] nums1 = new int[] {1, 2};
            int [] nums2 = new int[] {3, 4, 5};
            Assert.Equal(3, ma.FindMedianSortedArrays(nums1, nums2));
        }
        [Fact]
        public void Test_medianArray_ex7()
        {
            Class1 ma = new Class1();
            int [] nums1 = new int[] {0, 1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            int [] nums2 = new int[] {1, 2, 3};
            Assert.Equal(5, ma.FindMedianSortedArrays(nums1, nums2));
        }
    }
}
