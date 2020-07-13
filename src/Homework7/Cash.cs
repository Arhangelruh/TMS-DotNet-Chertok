using System;

namespace Homework7
{
    public class Cash {
       // public int cash { get; set; }
        public void WorkCash(object cash)
        {
            Random random = new Random();
            for (int i = 1; ; i++)
            {
                var purchase = random.Next(1, 100);
                for (int j = 1; j <= purchase; j++)
                {
                    Console.WriteLine($"Cash {cash} Clients {i} Purchase {j}");
                }
            };
        }
    }

}
