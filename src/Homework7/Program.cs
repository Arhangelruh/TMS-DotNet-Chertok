﻿using System;
using System.Threading;

namespace Homework7
{
    class Program
    {
        
        static void Main(string[] args)
        {

            for (int i=1; i<=5; i++ ) {
                Thread thread = new Thread(WorkCash);
                thread.Start(i);
            }
            Console.ReadKey();
        }

        public static void WorkCash(object cash)
        {
            DateTime timework = DateTime.Now;
            Random random = new Random();
            int timeopen = 10;
            int timeclose = 15;

            if (timework.Minute > timeopen && timework.Minute < timeclose)
            {
                for (int i = 1; timework.Minute < timeclose ; i++)
                {
                    timework = DateTime.Now;
                    var purchase = random.Next(1, 50);
                    for (int j = 1; j <= purchase; j++)
                    {
                        Console.WriteLine($"Cash №{(int)cash} Clients {i} Purchase {j}");
                        Thread.Sleep(1000);
                    }
                };
                Console.WriteLine("The cash is closed");
            }
            else {

                Console.WriteLine("The store is closed");
            }
        }
    }
}
