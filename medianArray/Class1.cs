/*
unit test sample

Assume two arrays are sorted integers (increasing order)
*/
using System;
using System.Diagnostics; // debug

namespace medianArray
{
    public class Class1
    {
        static (int, double) SpecialMedian(int[] nums1, int[] nums2)
        {
            // Special case handle
            // return status and result
            // status = 0 means good with result
            // status != 0 means not good, discard result
            int len1, len2, idx;
            len1 = nums1.Length;
            len2 = nums2.Length;
            if (len1 == 0 && len2 == 0)
            {
                return (0, 0.0); // exception
            }
            if (len1 == 0 && len2 == 1)
            {
                return (0, nums2[0]); // only one number in two arrays
            }
            if (len1 == 1 && len2 == 0)
            {
                return (0, nums1[0]); // only one number in two arrays
            }
            if (len1 == 0)
            { // one array empty
                idx = len2 / 2;
                if (len2 / 2 > idx + 0.01)
                {
                    return (0, nums2[idx]); // another array with odd number of elements
                }
                return (0, (nums2[idx] + nums2[idx - 1]) / 2.0); // another array with even number of elements
            }
            if (len2 == 0)
            { // one array empty
                idx = len1 / 2;
                if (len1 / 2 > idx + 0.01)
                {
                    return (0, nums1[idx]); // another array with odd number of elements
                }
                return (0, (nums1[idx] + nums1[idx - 1]) / 2.0); // another array with even number of elements
            }
            return (1, 0.0); // not special case
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            // variable declaration
            // idx is the index of middle number. If total length is odd, array with idx is median
            //     other wise, median is average of array value with idx and previous element
            // i1 and i2 are loop index variable for giving nums1 and nums2
            // len1 and len2 are length of giving nums1 and nums2
            // len is the total length of giving nums1 and nums2
            // crtidx and crtval is cumulative index and value for combined array (may not be computed)
            // preval is the value for previous index. Use this when len is even to compute median.
            int idx, i1 = 0, i2 = 0, len1, len2, len;
            int crtidx, crtval, preval;

            int status;
            double rst;
            (status, rst) = SpecialMedian(nums1, nums2);
            if (status == 0)
            {
                return rst;
            }

            len1 = nums1.Length;
            len2 = nums2.Length;
            len = len1 + len2;
            idx = len / 2;
            if (1.0 * len / 2.0 > idx + 0.01)
            { // total number of array elements are odd
                Trace.WriteLine("Debug");
                Debug.WriteLineIf(len == 3, "Value is 3.");
                crtidx = -1;
                crtval = 0;
                while (i1 < len1 && i2 < len2)
                {
                    if (nums1[i1] < nums2[i2])
                    {
                        crtidx = crtidx + 1;
                        crtval = nums1[i1];
                        i1 = i1 + 1;
                        if (crtidx == idx)
                        {
                            return crtval;
                        }
                    }
                    else
                    {
                        crtidx = crtidx + 1;
                        crtval = nums2[i2];
                        i2 = i2 + 1;
                        if (crtidx == idx)
                        {
                            return crtval;
                        }
                    }
                }
                if (i1 == len1) // nums1 is out
                {
                    if (idx > crtidx)
                    {
                        return nums2[i2 + (idx - crtidx) - 1];
                    }
                    return crtval;
                }
                // nums2 is out
                if (idx > crtidx)
                {
                    return nums1[i1 + (idx - crtidx) - 1];
                }
                return crtval; 
            }
            else
            {// total number of array elements are even
                crtidx = -1;
                preval = 0;
                crtval = 0;
                while (i1 < len1 && i2 < len2)
                {
                    if (nums1[i1] < nums2[i2])
                    {
                        crtidx = crtidx + 1;
                        if (crtidx == idx)
                        {
                            preval = crtval; // record preval
                        }
                        crtval = nums1[i1];
                        i1 = i1 + 1;
                        if (crtidx == idx)
                        {
                            return (preval + crtval) / 2.0;
                        }
                    }
                    else
                    {
                        crtidx = crtidx + 1;
                        if (crtidx == idx)
                        {
                            preval = crtval; // record preval
                        }
                        crtval = nums2[i2];
                        i2 = i2 + 1;
                        if (crtidx == idx)
                        {
                            return (preval + crtval) / 2.0;
                        }
                    }
                }
                if (i1 == len1) // nums1 is out
                {
                    if (idx - crtidx < 2)
                    {
                        preval = crtval;
                    }
                    else{
                        preval = nums2[i2 + (idx - crtidx) - 2];
                    }
                    crtval = nums2[i2 + (idx - crtidx) - 1];
                    return (preval + crtval) / 2.0;
                }
                // nums2 is out
                if (idx - crtidx < 2)
                {
                    preval = crtval;
                }
                else{
                    preval = nums1[i2 + (idx - crtidx) - 2];
                }
                crtval = nums1[i1 + (idx - crtidx) - 1];
                return (preval + crtval) / 2.0;
            }
        }

    }
}
