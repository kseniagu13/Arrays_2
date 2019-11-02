using System;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trim() võtab tühikud mõlemalt poolt ära, mitte keskel
            //IndexOf()
            //Substring()
            //Split()

            string fullName = "Ksenia Kaasik";
            Console.WriteLine($"Full name length before trim: {fullName.Length}");

            /*fullName = fullName.Trim();
            Console.WriteLine($"Full name length after trim: {fullName.Length}");


            Console.WriteLine($"{fullName[0]}");*/

             int indexOfSpace = fullName.IndexOf(' ');
             Console.WriteLine($"The position of the space is {indexOfSpace}"); //IndexOf leiab esimese tühiku

            string firstName = fullName.Substring(0, indexOfSpace); // esimene aadress kuni space-ni
            Console.WriteLine($"Name: {firstName}");

            string lastName = fullName.Substring(indexOfSpace + 1);
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");

            //Split()
            string[] personalData = fullName.Split(' ');
            foreach (string value in personalData)
            {
                Console.WriteLine($"Value from personalData: {value}");
            }

        }
    }
}
