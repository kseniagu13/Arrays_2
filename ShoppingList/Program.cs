using System;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter your list of supplies separated by comma: ");
            string userList = Console.ReadLine();

            string[] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}: {shoppingList[i]}");
            }*/

            Console.WriteLine("Enter your name, year of birth by comma: ");
            string userAnswer = Console.ReadLine();
            Form(userAnswer);

        }

        public static void Form (string items)
        {
            string [] personalData = items.Split (new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"First name: {personalData[0]}");
            Console.WriteLine($"First name: {personalData[1]}");
            Console.WriteLine($"Age: {2019 - int.Parse(personalData[2])}");
        }
    }
}
