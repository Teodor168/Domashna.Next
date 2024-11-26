using System.Collections.Generic;

namespace Domashna.Next
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            CreateLinkedList(numbers);
            LinkedList<int> evenNumbers = new LinkedList<int>();
            LinkedList<int> oddNumbers = new LinkedList<int>();
            SplitNumbers(numbers, evenNumbers, oddNumbers);

            PrintList("original list", numbers);
            PrintList("even numbers", evenNumbers);
            PrintList("odd numbers", oddNumbers);
        }

        public static void CreateLinkedList(LinkedList<int> numbers)
        {
            Console.Write("enter 10 numbers: ");
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                numbers.AddLast(nums[i]);
            }
        }

        public static void SplitNumbers(LinkedList<int> numbers, LinkedList<int> evenNumbers, LinkedList<int> oddNumbers)
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.AddLast(num);
                }
                else
                {
                    oddNumbers.AddFirst(num);
                }
            }
        }

        public static void PrintList(string listName, LinkedList<int> list)
        {
            Console.WriteLine($"{listName}:");
            foreach (var num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}