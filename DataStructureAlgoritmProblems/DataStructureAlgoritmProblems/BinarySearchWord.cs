using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgoritmProblems
{
    public class BinarySearchWord
    {
        bool check = false;
        public string FILEPATH = @"C:\Users\hp\source\repos\DataStructureAlgoritmProblems\DataStructureAlgoritmProblems\Word.txt";
        public void Search()
        {
            string words = File.ReadAllText(FILEPATH);
            string[] wordsList = words.Split(",");
            Console.Write("\nGive the Word To Search: ");
            string searchWord = Console.ReadLine();
            foreach (string word in wordsList)
            {
                if (word.Equals(searchWord))
                {
                    Console.WriteLine("\n\'" + searchWord + "\' is Found in Words List");
                    check = true;
                    break;
                }
            }
            if (check == false)
                Console.WriteLine("\n\'" + searchWord + "\' is Not Found in Words List");
        }
    }
}
