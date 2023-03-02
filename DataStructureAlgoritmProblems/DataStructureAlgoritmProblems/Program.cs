using System;

namespace DataStructureAlgoritmProblems
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome To Data Structure Algorithm Problems---\n");
            while (true)
            {
                Console.WriteLine("\nSelect One Option : \n" +
                "1. Binary Search Word From Word List\n" +
                "2. Insertion Sort\n" +
                "3. Bubble Sort\n" +
                "4. End\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearchWord word = new BinarySearchWord();
                        word.Search();
                        break;
                    case 2:
                        Insertion_Sort insertionSort = new Insertion_Sort();
                        insertionSort.InsertionSort();
                        break;
                    case 3:
                        Console.WriteLine("\nThankYou..");
                        break;
                }
                if (option == 4)
                    break;
            }
        }
    }
}