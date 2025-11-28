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

        public int bigElement(int[] arr)
        {
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
