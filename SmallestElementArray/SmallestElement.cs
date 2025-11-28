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

        public int findSmallest(int[] arr)
        {
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
