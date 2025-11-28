using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblems.GetAllTheElements
{
    internal class GetElement
    {
        public GetElement() { }

        public void getEle()
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
            Console.Write("The Array is : ");
            foreach (int ele in arr)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine() ;
            //Console.WriteLine($"The Array is : " + string.Join(" ", arr));
        }
    }
}
