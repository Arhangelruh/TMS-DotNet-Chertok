using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Security.Cryptography;

namespace Homework1
{
    enum Week{
    Monday=1,
    Tuesday=2,
    Wednasday=3,
    Thursday=4,
    Friday=5,
    Saturday=6,
    Sunday=7
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day number (1-7) of the week and we will say what day it is: ");
            string[] weekDays = { "Monday", "Tuesday", "Wednasday", "Thursday", "Friday", "Saturday", "Sunday"};
            try
            {
                int key = int.Parse(Console.ReadLine());

                if (key <= 7 && key >= 1)
                {
                    var dayOfWeek = (Week)key;

                    Console.WriteLine("The " + key + " day of week it is: " + dayOfWeek);
                    Console.WriteLine("\r\nSame with arroy:");
                    var dayOfWeek2 = key-1 ;
                    Console.WriteLine("The " + key + " day of week it is: "+weekDays[dayOfWeek2]);
                    Console.WriteLine("\r\nSame with method:");                    
                    Console.WriteLine("The " + key + " day of week it is: " + DayOfWeek(key));
                }
                else
                {
                    Console.WriteLine("In week only seven days  :*( ");
                }
            }
            catch {
                Console.WriteLine("The entered value is not a number");
            }
            Console.ReadKey();
        }
        public static string DayOfWeek(int numberOfDay)
        {
            switch (numberOfDay) {
                case 1:
                    {
                        var dayOfWeek3 = "Monday";
                        return dayOfWeek3;
                    }
                case 2:
                    {
                        var dayOfWeek3 = "Tuesday";
                        return dayOfWeek3;
                    }
                case 3:
                    {
                        var dayOfWeek3 = "Wednasday";
                        return dayOfWeek3;
                    }
                case 4:
                    {
                        var dayOfWeek3 = "Thursday";
                        return dayOfWeek3;
                    }
                case 5:
                    {
                        var dayOfWeek3 = "Friday";
                        return dayOfWeek3;
                    }
                case 6:
                    {
                        var dayOfWeek3 = "Saturday";
                        return dayOfWeek3;
                    }
                case 7:
                    {
                        var dayOfWeek3 = "Sunday";
                        return dayOfWeek3;
                    }
            }
            string dayOfWeek4 = "In week only seven days: *(";
            return dayOfWeek4;
        }
    }
}
