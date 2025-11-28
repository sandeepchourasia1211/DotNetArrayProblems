using ArraysProblems.BiggestElementArray;
using ArraysProblems.SumOfEvenNumber;

namespace ArraysProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat;
            do
            {
                Console.WriteLine("------------ MENU ------------");
                Console.WriteLine("Option 1 : Sum of Even Elements Present in An Array");
                Console.WriteLine("Option 2 : Biggest Element Present in an Array");
                Console.WriteLine("Option 3 : Smallest Element present in an Array");
                Console.WriteLine("Option 4 : Get All the Elements Present in an Array");
                Console.WriteLine("Option 5 : Count Palindrome Element present in an Array");
                Console.WriteLine("Option 6 : Reverse An Array in optimal way");
                Console.WriteLine("Option 7 : Implement Linear Search");
                Console.WriteLine("Option 8 : Replace Every Element By Their Sum");
                Console.WriteLine("Option 9 : Sum of All Strong Number in an Array");
                Console.WriteLine("Option 10 :Swap the Given Two Number");
                Console.WriteLine("Option 11 :Swap the Given Number without using extra variable");
                Console.WriteLine("Option 12 :Frequency/Occurence of each Element in an Array");
                Console.WriteLine("Option 13 : Unique Element in an Array");
                Console.WriteLine("Option 14 : Duplicate Element in an Array");
                Console.WriteLine("Option 15 : First Unique Element in an Array");
                Console.WriteLine("Option 16 : First Three Unique Element in an Array");
                Console.WriteLine("Option 17 : First Four Duplicate Element in an Array");
                Console.WriteLine("Option 18 : Element Which is more repeated in an Array (VVI)");
                Console.WriteLine("Option 19 : Nth Unique Element an Array");
                Console.WriteLine("Option 20 : Merge Two Array in Single Array");
                Console.WriteLine("Option 21 : Merge Two Array in Single Array in Zig-Zag");
                Console.WriteLine("Option 22 : Merge Two Sorted Array in Single Array in Sorted Format");
                Console.WriteLine("Option 23 : Pair of Elements Who's Sum is Equal to Even Number.");
                Console.WriteLine("Option 24 :Misiing Elements In an Array.");
                Console.WriteLine("Option 25 :Nth Biggest Elements In an Array.");
                Console.WriteLine("Option 26 :Nth Smallest Elements In an Array.");
                Console.WriteLine("Option 27 :Missing value In an Array.");
                Console.WriteLine("Option 28 :Sort an Array in Accending Order.");
                Console.WriteLine("------------------------------");

                Console.Write("Please choose an option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (option == 1)
                {
                    printSumEven();
                }
                else if (option == 2)
                {
                    printBiggest();
                }
                else if (option == 3)
                {
                    
                }
                else if (option == 4)
                {
                   
                }
                else if (option == 5)
                {
                    
                }
                else if (option == 6)
                {
                   
                }
                else if (option == 7)
                {
                    
                }
                else if (option == 8)
                {
                    
                }
                else if (option == 9)
                {
                   
                }
                else if (option == 10)
                {
                    
                }
                else if (option == 11)
                {
                    

                }
                else if (option == 12)
                {
                    

                }
                else if (option == 13)
                {
                    
                }
                else if (option == 14)
                {
                    
                }
                else
                {
                    Console.WriteLine("Invalid option! Try again.");
                }

                Console.WriteLine();
                Console.Write("Do you want to continue? (y/n): ");
                string ans = Console.ReadLine();

                repeat = ans.ToLower() == "y";

                Console.WriteLine();

            } while (repeat);
        }

        private static void printBiggest()
        {
            Console.WriteLine("Enter The Size of an Array : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter number to Find Biggest Number {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("The Array is " + string.Join(" ", arr));

            BiggestElement biggest = new BiggestElement();
            int res=biggest.bigElement(arr);
            Console.WriteLine($"The Biggest Element is : {res}");
        }

        private static void printSumEven()
        {
            Console.WriteLine("Enter The Size of an Array : ");
            int num=Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[num];

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write($"Enter number to get Sum of Even Numbers {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("The Array is "+string.Join(" ", arr));

            EvenSum eS= new EvenSum();
            int res=eS.sumEven(arr);
            Console.WriteLine($"The Sum of Even Elements of the Array is {res}");
            
        }
    }
}
