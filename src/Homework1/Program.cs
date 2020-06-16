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

            try
            {
                int key = int.Parse(Console.ReadLine());

                if (key <= 7 && key >= 1)
                {
                    var dayOfWeek = (Week)key;

                    Console.WriteLine("The " + key + " day of week it is: " + dayOfWeek);
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
    }
}
