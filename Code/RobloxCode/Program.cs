using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roblox;

namespace RobloxCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Solution sol = new Solution();
                Console.WriteLine("Select number for test to run:");
                Console.WriteLine("1. Merge two sorted arrays");
                Console.WriteLine("2. Return the maximum product from 3 integers in the list");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //Input size of array1
                        Console.WriteLine("Please enter the number of elements in the first array");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        //Input elements of array1
                        Console.WriteLine("Please enter the elements in the first array:");
                        int[] arr1 = new int[n1];
                        string[] input1 = Console.ReadLine().Split(',');
                        for (int i = 0; i < n1; i++)
                        {
                            int value = 0;
                            //validation if input type is not integer
                            if (!int.TryParse(input1[i], out value))
                            {
                                throw new Exception("Invalid input");
                            }
                            arr1[i] = value;
                        }
                        //Input size of array2
                        Console.WriteLine("Please enter the number of elements in the second array");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        //Input elemets of array2
                        Console.WriteLine("Please enter the elements in the second array:");
                        int[] arr2 = new int[n2];
                        string[] input2 = Console.ReadLine().Split(',');
                        for (int i = 0; i < n2; i++)
                        {
                            int value = 0;
                            //validation if input is not integer
                            if (!int.TryParse(input2[i], out value))
                            {
                                throw new Exception("Invalid input");
                            }
                            arr2[i] = value;
                        }
                        int[] merged = sol.MergeSortedArrays(arr1, arr2);
                        //printing sorted array
                        for (int i = 0; i < (n1 + n2); i++)
                        {
                            Console.Write(merged[i]);
                            if (i == (n1 + n2 - 1))
                                continue;
                            else
                                Console.Write(",");
                        }
                        Console.WriteLine("The runtime of this methid is O(n+m), where n and m are the sizes of the two different arrays");

                        break;
                    case 2:

                        Console.WriteLine("Enter the size of the input array:");
                        int size = Convert.ToInt32(Console.ReadLine());
                        //Input elements of array
                        Console.WriteLine("Please enter the elements in the array:");
                        int[] arr = new int[size];
                        string[] input = Console.ReadLine().Split(',');
                        for (int i = 0; i < size; i++)
                        {
                            int value = 0;
                            //validation if input is not integer
                            if (!int.TryParse(input[i], out value))
                            {
                                throw new Exception("Invalid input");
                            }
                            arr[i] = value;
                        }
                        int max = sol.MaximumProduct(arr);
                        Console.WriteLine("The maximum product of the array is:" + max);
                        Console.WriteLine("The runtime of this method is O(n)");
                        break;
                    default: break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }


    }
}
