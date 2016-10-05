using System;
using System.Linq;

namespace Roblox
{

    public class Solution
    {
        public int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;
            int[] merged = new int[n1 + n2];

            try
            {
                if (n1 == 0 && n2 == 0) return merged;
                if (n1 > 1)
                {
                    for (int i = 1; i < n1; i++)
                    {
                        if (arr1[i - 1] > arr1[i])
                        {
                            throw new Exception("Array1 is not sorted");
                        }
                    }
                }
                if (n2 > 1)
                {
                    for (int i = 1; i < n2; i++)
                    {
                        if (arr2[i - 1] > arr2[i])
                        {
                            throw new Exception("Array2 is not sorted");
                        }
                        if (n1 == 0 && n2 != 0)
                        {
                            merged = arr2; return merged;
                        }
                    }
                }
                    if (n1 != 0 && n2 == 0)
                    {
                        merged = arr1; return merged;
                    }
                    if (n1 == 0 && n2 != 0)
                    {
                        merged = arr2; return merged;
                    }
                    //Merging the 2 arrays into a new array
                    int l = 0; int r = 0;
                    int mer = 0;
                    while (l < n1 && r < n2)
                    {
                        if (arr1[l] <= arr2[r])
                        {
                            merged[mer++] = arr1[l++];
                        }
                        else
                            merged[mer++] = arr2[r++];
                    }
                    if (l < n1)
                    {
                        while (l < n1)
                        {
                            merged[mer++] = arr1[l++];
                        }
                    }
                    else if (r < n2)
                    {
                        while (r < n2)
                        {
                            merged[mer++] = arr2[r++];
                        }
                    }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return new int[] { };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new int[] { };
            }
            return merged;
        }
        public int MaximumProduct(int[] arr)
        {
            try
            {
                int size = arr.Length;
                if (size < 3) { throw new Exception("The array size is invalid"); }
                // Base case
                if (size == 3) return checked(arr[0] * arr[1] * arr[2]);

                int max = arr[0], min = arr[0], max_index = 0, min_index = 0;

                for ( int i = 0; i < size; i++)
                {
                    if (arr[i] > max)
                    { 
                        max = arr[i];
                        max_index = i;
                    }
                    else if (arr[i] < min)
                    {
                        min = arr[i];
                        min_index = i;
                    }
                }
                int max_sec = min, max_third = min, min_sec = max;
                for (int i = 0; i < size; i++)
                {
                    if (i == max_index || i == min_index) continue;
                    if (arr[i] > max_sec)
                    {
                        max_third = max_sec;
                        max_sec = arr[i];
                    }
                    else if (arr[i] > max_third)
                    {
                        max_third = arr[i];
                    }
                    if (arr[i] < min_sec) min_sec = arr[i];
                }
                //to check if product is not greater than int.max  or less than min.int              
                int prod_one = checked(max * max_sec * max_third);              
                int prod_two = checked(min * min_sec * max);
                if (prod_one > prod_two) return prod_one;
                return prod_two;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
          
        }
}