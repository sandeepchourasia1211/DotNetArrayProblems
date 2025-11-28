using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblems.SumOfEvenNumber
{
    internal class EvenSum
    {
        public EvenSum() { }

        public int sumEven(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter number to get Sum of Even Numbers {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("The Array is " + string.Join(" ", arr));
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    sum += arr[i];
            }
            return sum;
        }
    }
}
