using System;
using System.Threading;

namespace Homework7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread thread = new Thread(Cash.WorkCash);
                thread.Start(i);
            }
            Console.ReadKey();
        }
    }
}
