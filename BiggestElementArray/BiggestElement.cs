using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblems.BiggestElementArray
{
    internal class BiggestElement
    {
        public BiggestElement() { }

        public int bigElement(int size)
        {           
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter number to Find Biggest Number {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("The Array is " + string.Join(" ", arr));
            int big = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i]>big)
                   big = arr[i];               
            }
            return big;
        }
    }
}
