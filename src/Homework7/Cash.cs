using System;
using System.Threading;

namespace Homework7
{
    class Cash {
        private static Random _random = new Random();
        private static int _speedWork = _random.Next(500, 1500);

        public static void WorkCash(object cash)
        {
            var timework = DateTime.Now.TimeOfDay;
            Random random = new Random();
            string timeopen = "10:30";
            string timeclose = "11:37";

            TimeSpan tsOpen = TimeSpan.Parse(timeopen);
            TimeSpan tsClose = TimeSpan.Parse(timeclose);

            if (timework > tsOpen && timework < tsClose)
            {
                for (int i = 1; timework < tsClose; i++)
                {
                    timework = DateTime.Now.TimeOfDay;
                    var purchase = random.Next(1, 50);
                    for (int j = 1; j <= purchase; j++)
                    {
                        Console.WriteLine($"Cash №{(int)cash} Clients {i} Purchase {j}");
                        Thread.Sleep(_speedWork);
                    }
                };
                Console.WriteLine("The cash is closed");
            }
            else
            {

                Console.WriteLine("The store is closed");
            }
        }
    }
}
