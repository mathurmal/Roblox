using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roblox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roblox_Testing
{
    [TestClass]
    class MultiplicationTest
    {
        Solution sol = new Solution();

        [TestMethod]
        [ExpectedException(typeof(SystemException) ,"The array size is invalid")]
        public void LessThan3()
        {
            int[] arr = new int[] { 10, 20 };
            int max = sol.MaximumProduct(arr);
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException), "The array size is invalid")]
        public void NullArray()
        {
            int[] arr = new int[] {};
            int max = sol.MaximumProduct(arr);
        }
        
        //all positive
        [TestMethod]
        public void AllPositive()
        {
            int[] arr = new int[] { 2, 40, 5, 12, 1, 7 };
            int max = 3360;
            Assert.IsTrue(sol.MaximumProduct(arr)== max);
        }
        //all negetive
        [TestMethod]
        public void AllNegetive()
        {
            int[] arr = new int[] { -7, -9, -4, -5, -9, -12, -13 };
            //sorted : -13,-12,-9,-9,-7,-5,-4
            int max = -140;
            Assert.IsTrue(sol.MaximumProduct(arr) == max);
        }
        //if two numbers are negetive (and not bigger than the positive integers)
        [TestMethod]
        public void TwoNegativeLess()
        {
            int[] arr = new int[] {2,1,5,11,7,8,3,-9,-1 };
            //sorted : -9,-1,2,3,5,7,8,11
            int max = 616;
            Assert.IsTrue(sol.MaximumProduct(arr) == max);
        }
        
        //high value negetive numbers
        [TestMethod]
        public void HighNegatives()
        {
            int[] arr = new int[] {-1900234,-45663,-23949504,-34352114 };
        }

        //product above max.int
       [TestMethod]
       [ExpectedException(typeof(System.OverflowException))]
        public void maxint()
        {
            int[] arr = new int[] { 999999999, 999999999, 999999999, 999999999 };
            int max = sol.MaximumProduct(arr);
           
        }

        //product below min.int
        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void minint()
        {
            int[] arr = new int[] { -12345667, -123455678, -928244353 };
            int max = sol.MaximumProduct(arr);

        }

        //majority number is 0
        //[TestMethod]
        //public void MajorityZero()
        //{
        //    int[] arr = new int[] {4,7,-1,-9,4,6,0,0,0,0,0,0,0,0,0,11,67,89,0,0,0,0,0,0 };
        //    //sorted:-9,-1,0...0,4,4,6,7,11,67,89
        //    //int max = 

        //}
    }
}
