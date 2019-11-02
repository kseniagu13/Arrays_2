using System;
using System.Collections.Generic; //käsitsi lisada
namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>() { 1, 2, 3, 4, 5 }; //listi saab muuta, ta on dünaamiline, Array ei ole.
            numbers.Add(1); // tegi listi pikkust ühe võrra pikemaks ja lõpu lisas number 1
            numbers.AddRange(new int[3] { 6, 7, 8 });

            

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }

            int index = numbers.IndexOf(1);
            Console.WriteLine($"Value of IndexOf: {index}");
            int lastIndex = numbers.LastIndexOf(1);
            Console.WriteLine($"Value of LastIndexOf: {lastIndex}");
            numbers.RemoveAt(lastIndex); //tahan teise ühe kustutada ära listis, mida lisaasin enne

            foreach(int element in numbers)
            {
                Console.WriteLine(element);
            }

            int sizeOfList = numbers.Count; // Listi suurus
            Console.WriteLine($"You size of list is {sizeOfList}.");

           /* foreach (int number in numbers)
            {
                if (number == 1)
                {
                    numbers.Remove(number);
                }
            }*/

            for (int i =0; i < sizeOfList; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);

                }
            }
            //empty the list
            numbers.Clear();

            foreach (int element in numbers) // ei näita midagi, sest kõik ühed on kustutatud.
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();


            // programm küsib kasutajalt, mida kasutaja tahab osta. Kasutaja sisestab , salvestame listi sisse. siis kui sisestab siis puhastame konsoolie.Cpnsole.clear
            // kuvame seda nimekirja ja küsime, kas ta soovib veel midagi lisada , kui jah , siis lisab siis puhastame ja kuvame uut listi. Jälle küsime
            //mida ta tahab ära kustutada. kustutab ja siis kuvame uue.
            //teeme While-ga



        }
    }
}
