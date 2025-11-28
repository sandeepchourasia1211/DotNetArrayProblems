using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblems.PalindromElementCount
{
    internal class PalindromeCount
    {
        public PalindromeCount() { }

        
        public Boolean isPalindrome(int num)
        {
            int rev = 0, original=num;

            while(num > 0)
            {
                int temp = num % 10;
                rev = rev * 10 + temp;
                num /= 10;
            }
            return rev == original;
        }

        public int getPalindromeCount(int size)
        {           
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter the Number {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"The Array is : " + string.Join(" ", arr));

            int count = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                int temp= arr[i];
                if(isPalindrome(temp) )
                    count++;
            }
            return count;

        }


    }
}
