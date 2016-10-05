using System;

public static class Solution
{
    public  int[] MergeSortedArrays(int[] arr1, int[] arr2)
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
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return merged;
    }

    public  int MaximumProduct(int[] arr)
    {
        int max = 0;
        try
        {
            int size = arr.Length;
            Array.Sort(arr);
            //highest product in either the product the of the largest 3 numbers in the array
            //or the product of the largest and the largest 2 negetive numbers in the array
            if (arr.Contains(0) && (Array.IndexOf(arr, 0) - 2) >= 0)
            {
                int max1 = arr[0] * arr[1] * arr[size - 1];
                int max2 = arr[size - 1] * arr[size - 2] * arr[size - 3];
                max = Math.Max(max1, max2);
            }
            else
                max = arr[size - 1] * arr[size - 2] * arr[size - 3];
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        return max;
    }
}
