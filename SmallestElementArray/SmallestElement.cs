using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblems.SmallestElementArray
{
    internal class SmallestElement
    {
        public SmallestElement() { }

        public int findSmallest()
        {
            Console.WriteLine("Enter the size of an Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter the Number {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"The Array is : " + string.Join(" ", arr));

            int smallest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] <smallest)
                    smallest= arr[i];
            }
            return smallest;
        }
    }
}
