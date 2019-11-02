using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new string[5] { "Ksenia", "Britta", "Andri", "Britta", "Bogdan" };
            string searchName = "Britta";
            CountNames(names, searchName);

            

          
            Console.ReadLine();

        }

        public static void CountNames(string[] searchArray, string searchWord)
        {
            int counter = 0;
            foreach (string word in searchArray)
            {
                
                if (word == searchWord)
                {
                   counter++;
                }
            }
            Console.WriteLine($"There are {counter} {searchWord}s in the array!");

        }
    }
}
