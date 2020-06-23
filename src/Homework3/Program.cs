using System;
using System.Collections.Generic;

namespace Homework3
{
    class Program
    {
        static void Main()
        {
            List<string> tasksName = new List<string>();
            List<string> timeName = new List<string>();
            string question;
           
            do
            {
                Console.WriteLine("\nInsert task: ");
                string task = Console.ReadLine();
                tasksName.Add(task);
                Console.WriteLine("\nInsert time for your task: ");
                string time = Console.ReadLine();
                timeName.Add(time);
                Console.WriteLine("\nWant to enter another task?(Press eny key or n)");
                string q = Console.ReadLine();
                question = q.ToUpper();
            }
            while (question != "N");

            for (var i = 0; i < tasksName.Count && i < timeName.Count; i++)
            {
                string a = tasksName[i];
                string b = timeName[i];
                Task task = new Task(a, b);
                task.Show();
            }
                Console.ReadKey();
        }
    }
}
