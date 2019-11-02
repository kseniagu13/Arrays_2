using System;

namespace DateTimeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date Time on obejktid
            /*var dateToday = new DateTime(1991, 01, 13);
            Console.WriteLine(dateToday);
            var dayOfTheWeek = dateToday.DayOfWeek;
            Console.WriteLine(dayOfTheWeek);*/

            /* Console.WriteLine("Enter your year of birth and birthday: ");
             string userAnswer = Console.ReadLine();
             Form(userAnswer); */


            var currentDate = DateTime.Now;
            var dateObject = new DateTime(2019, 11, 01);
            Console.WriteLine(currentDate);
            var currentDayOfTheWeek = currentDate.DayOfWeek;
            Console.WriteLine(currentDayOfTheWeek);

            var ticks = dateObject.Ticks; //seconds since 1970
            Console.WriteLine($"Ticks {ticks}");
            Console.WriteLine($"Print current {currentDate}");
            Console.WriteLine($"Print long date string  {currentDate.ToLongDateString()}");
            Console.WriteLine($"Print short date string  {currentDate.ToShortDateString()}");
            Console.WriteLine($"Print long time string  {currentDate.ToLongTimeString()}");
            Console.WriteLine($"Print short time string  {currentDate.ToShortTimeString()}");
            Console.WriteLine($"Date format: {currentDate.ToString("yyyy-MM-dd HH:mm")}"); //MM-month, mm- minutes

            //arvutada vanuse sekuntides


            Console.ReadLine();


        }
        public static void Form(string items)
        {
            string[] personalData = items.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine($"{int.Parse(personalData[0])},{int.Parse(personalData[1])}, {int.Parse(personalData[2])}");
            var userBirthday = new DateTime(int.Parse(personalData[0]),int.Parse(personalData[1]), int.Parse(personalData[2]));
            var dayOfTheWeek = userBirthday.DayOfWeek;
            Console.WriteLine(dayOfTheWeek);



        }
           
    }
}
