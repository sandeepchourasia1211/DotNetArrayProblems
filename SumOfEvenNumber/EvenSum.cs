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

        public int sumEven(int[] num)
        {
            int sum = 0;
            for(int i=0; i<num.Length; i++)
            {
                if (num[i] % 2 == 0)
                    sum += num[i];
            }
            return sum;
        }
    }
}
