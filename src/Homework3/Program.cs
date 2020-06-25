using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Homework3
{
    class Program
    {
        static void Main()
        {
            List<string> tasksName = new List<string>();
            List<string> timeName = new List<string>();
            string question;          

            for (int i=0; ;i++) {
                Console.WriteLine("\nInsert task: ");
                string task = Console.ReadLine();
                tasksName.Add(task);

                for (int j = 0; ; j++) {
                    Regex regex = new Regex(@"\d{2}:\d{2}");
                    Console.WriteLine("\nInsert time for your task in format 00:00: ");
                    string timeforlist = Console.ReadLine();
                    if (regex.IsMatch(timeforlist))
                    {
                        timeName.Add(timeforlist);
                        break;
                    }
                    else {
                        Console.WriteLine("Incorrect format");
                    }
                }
                Console.WriteLine("\nWant to enter another task?(Press eny key or n)");
                string q = Console.ReadLine();
                question = q.ToUpper();
                if (question=="N") {
                    break;
                }
            }
            
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
