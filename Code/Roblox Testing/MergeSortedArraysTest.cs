using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roblox;
using System.Collections.Generic;
using System.Linq;


namespace Roblox_Testing
{
    [TestClass]
    public class MergeSortedAraysTest
    {
        Solution sol = new Solution();
        //both are merged
        [TestMethod]
        public void Arr1Arr2Merged()
        {
            int[] arr1 = new int[] { 0, 2, 6, 8, 12, 17, 23 };
            int[] arr2 = new int[] { 2, 5, 7, 9, 12, 14, 15, 19, 20 };
            int[] final = new int[] { 0, 2, 2, 5, 6, 7, 8, 9, 12, 12, 14, 15, 17, 19, 20, 23 };
            int[] mess =  arr1.Concat(arr2).OrderBy(x => x).ToArray();
            Assert.IsTrue(Enumerable.SequenceEqual(final, mess));
        }
        //arr1 is null
        [TestMethod]
        public void Arr1Null()
        {
            int[] arr2 = new int[] { 2, 5, 7, 9, 12, 14, 15, 19, 20 };
            int[] final = new int[] { 2, 5, 7, 9, 12, 14, 15, 19, 20 };
            int[] mess = sol.MergeSortedArrays(new int[] { }, arr2);
            Assert.IsTrue(Enumerable.SequenceEqual(final, mess));
        }
        //arr2 is null
        [TestMethod]
        public void Arr2Null()
        {
            int[] arr1 = new int[] { 2, 5, 7, 9, 12, 14, 15, 19, 20 };
            int[] final = new int[] { 2, 5, 7, 9, 12, 14, 15, 19, 20 };
            int[] mess = sol.MergeSortedArrays(arr1, new int[] { });
            Assert.IsTrue(Enumerable.SequenceEqual(final, mess));
        }
        //both 
        [TestMethod]
        public void Arr1NullArr2Null()
        {           
            int[] final = new int[] { };
            int[] mess = sol.MergeSortedArrays(new int[] { }, new int[] { });
            Assert.IsTrue(Enumerable.SequenceEqual(final, mess));
        }
        //array1 not sorted
        [TestMethod]
        public void Arr1NotSorted()
        {
            int[] arr1 = new int[] { 1, 2, 6, 3, 8, 6, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            int[] final = new int[] { };
            int[] mess = sol.MergeSortedArrays(arr1,arr2);
            Assert.IsTrue(Enumerable.SequenceEqual(final,mess));
        }
        //array2 not sorted
        [TestMethod]
        public void Arr2NotSorted()
        {            
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            int[] arr2 = new int[] { 1, 2, 6, 3, 8, 6, 9 };
            int[] final = new int[] { };
            int[] mess = sol.MergeSortedArrays(arr1, arr2);
            Assert.IsTrue(Enumerable.SequenceEqual(final, mess));
        }
        //array1 and array2 not sorted
        [TestMethod]
        public void Arr1Arr2NotSorted()
        {
            int[] arr1 = new int[] { 1, 2, 6, 3, 8, 6, 9 };
            int[] arr2 = new int[] { 3,1,7,5,9,7};
            int[] final = new int[] { };
            int[] mess = sol.MergeSortedArrays(arr1, arr2);
            Assert.IsTrue(Enumerable.SequenceEqual(final, mess));
        }
        //too many inputs.
        [TestMethod]
        public void Arr1Arr2Multiple()
        {
            int[] arr1 = new int[] { 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9 };
            int[] arr2 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
            int[] final = arr1.Concat(arr2).OrderBy(x => x).ToArray();
            int[] mess = sol.MergeSortedArrays(arr1, arr2);
            Assert.IsTrue(Enumerable.SequenceEqual(final, mess));
        }

        
    }
}
