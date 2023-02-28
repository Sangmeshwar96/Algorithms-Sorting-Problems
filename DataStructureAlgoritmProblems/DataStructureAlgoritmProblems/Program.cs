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
                "2. End");
                Console.Write("Please Select One Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BinarySearchWord word = new BinarySearchWord();
                        word.Search();
                        break;
                    case 2:
                        Console.WriteLine("\nThankYou..");
                        break;
                }
                if (option == 2)
                    break;
            }
        }
    }
}