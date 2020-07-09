using Fitness.Core;
using System;
using System.Linq;

namespace FeatnesConsoleApp
{
    class Program
    {
        public static FitnesManager fitnesManager = new FitnesManager();
        static void Main(string[] args)
        {
           
            //fitnesManager.AddAccount("Fitonyash", 75, 175, 25);
            //fitnesManager.UpdateCaloriesWithWalking("Fitonyash",10);
            //fitnesManager.UpdateCaloriesWithRun("Fitonyash", 20);
            //fitnesManager.UpdateCaloriesWithDriveBicycle("Fitonyash", 15);
            //fitnesManager.GetStatistic("Fitonyash");
            
            while (true) {
                ShowMenu();
                int.TryParse(Console.ReadLine(), out int input);
                switch (input) {
                    case 1: {
                            AddProfile();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\nInput Login");
                            var login = Console.ReadLine();
                            var persone = fitnesManager.tracker.FirstOrDefault(c => c.Login == login);
                            if (persone == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Login {login} not found");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                bool action = true;
                                while (action)
                                {
                                    Console.WriteLine("\n1:Add activity");
                                    Console.WriteLine("2:Show statistic");
                                    Console.WriteLine("3:Remove account");
                                    Console.WriteLine("4:Logout");
                                    int.TryParse(Console.ReadLine(), out int inputactivity);
                                    switch (inputactivity)
                                    {
                                        case 1:
                                            {
                                                AddActivity(login);
                                            }
                                            break;
                                        case 2:
                                            {
                                                fitnesManager.GetStatistic(login);
                                            }
                                            break;
                                        case 3:
                                            {
                                                fitnesManager.RemoveAccount(login);
                                            }
                                            break;
                                        case 4:
                                            {
                                                action = false;   
                                            }
                                            break;
                                        default:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Unknown command");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    case 3: {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unknown command");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                }
            }

        }
        static void ShowMenu() {
            Console.WriteLine("\n1: Add new profile");
            Console.WriteLine("2: Log in");
            Console.WriteLine("3: exit");
        }

        static void AddProfile() {
            while (true)
            {
                Console.WriteLine("Input Login");
                var login = Console.ReadLine();
                var persone = fitnesManager.tracker.FirstOrDefault(c=>c.Login==login);
                if (persone == null)
                {
                    Console.WriteLine("Input weight: ");
                    try
                    {
                        var weight = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input height: ");
                        var height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input Age: ");
                        var age = int.Parse(Console.ReadLine());
                        fitnesManager.AddAccount(login, weight, height, age);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Accont created :)");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input value is invalide");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Login {login} already exist");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static void AddActivity(string login) {
            Console.WriteLine("Select activity: 1-Walking, 2-Running, 3-bicycling. 4-exit");
            int.TryParse(Console.ReadLine(), out int input);
            switch (input) {
                case 1: {
                        Console.WriteLine("1: Add taim activity walking (minuts)");
                        try
                        {
                            var walking = double.Parse(Console.ReadLine());
                            fitnesManager.UpdateCaloriesWithWalking(login, walking);
                            Console.WriteLine($"Activity walking {walking} minuts added");
                        }
                        catch (Exception) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect data");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    break;
                
                case 2:
                    {
                        Console.WriteLine("1: Add taim activity running (minuts)");
                        try
                        {
                            var running = double.Parse(Console.ReadLine());
                            fitnesManager.UpdateCaloriesWithRun(login, running);                            
                            Console.WriteLine($"Activity running {running} minuts added");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect data");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    break;
                
                case 3:
                    {
                        Console.WriteLine("1: Add taim activity bicycling (minuts)");
                        try
                        {
                            var bicycling = double.Parse(Console.ReadLine());
                            fitnesManager.UpdateCaloriesWithDriveBicycle(login, bicycling);
                            Console.WriteLine($"Activity walking {bicycling} minuts added");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect data");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    break;
                case 4: {
                        break;
                    }
                
                default: {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown command");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }
        }
    }
}
