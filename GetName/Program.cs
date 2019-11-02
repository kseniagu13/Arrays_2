using System;

namespace GetName
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            Console.WriteLine("Enter your name, please: ");
            fullName = Console.ReadLine();
            GetArrayFromString(fullName);
            
        }


        public static void GetArrayFromString(string stringTosplit)
        {
            string[] personalData = stringTosplit.Split(' ');
            Console.WriteLine($"First name: {personalData[0]}");
            Console.WriteLine($"Last name: {personalData[1]}");

        }
    }
}
