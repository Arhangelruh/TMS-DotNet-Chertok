using Homework4.Enums;
using Homework4.Interfaces;
using Homework4.Logic;
using Homework4.Models;
using System;

namespace Homework4
{
    class Program
    {
        private static readonly ZooAnimalAction _zooAnimalAction = new ZooAnimalAction();
        private static readonly ZooManager _zoo = new ZooManager();
        static void Main(string[] args)
        {
          var zoo = new ZooManager();
            while (true) {
                ShowMenu();
                int.TryParse(Console.ReadLine(), out int userInput);
                
                    switch (userInput) {
                        case 1: {
                                InputAnimal();
                            }
                            break;
                        case 2: {
                            Console.WriteLine("Enter variety");
                            var variety =Console.ReadLine();
                            _zoo.GetAnimal(variety);
                        }
                            break;
                        case 3: {
                            Console.WriteLine("Enter ID");
                            var id = Console.ReadLine();
                            _zoo.Remove(id);
                        }
                            break;
                        case 4: {
                                _zoo.GetAllAnimals();
                            }
                            break;
                        case 5: {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Команда не найдена");
                            }
                            break;
                }
            }
        }

        private static void InputAnimal()
        {
            Console.WriteLine("Add variety");
            var variety = Console.ReadLine();
            Console.WriteLine("Add Name");
            var name = Console.ReadLine();
            Console.WriteLine("Add taxonomic class:");
            Console.WriteLine("1:None");
            Console.WriteLine("2:Predator");
            Console.WriteLine("3:Herbivore");
            Console.WriteLine("4:Omnivorous");
            int.TryParse(Console.ReadLine(), out int userInputTaxonomic);
            var taxonomicClass = Enums.Taxonomic.None;
            switch (userInputTaxonomic)
            {
                case 1:
                    {
                        taxonomicClass = Enums.Taxonomic.None;
                       
                    }
                    break;
                case 2:
                    {
                        taxonomicClass = Enums.Taxonomic.Predator;
                    }
                    break;
                case 3:
                    {
                        taxonomicClass = Enums.Taxonomic.Herbivore;
                    }
                    break;
                case 4:
                    {
                        taxonomicClass = Enums.Taxonomic.Omnivorous;
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Команда не найдена");
                    }
                    break;
            }

            Animal animal;
          
                animal = _zooAnimalAction.CreateAnimal(variety,name,taxonomicClass);
  
            _zoo.AddAnimal(animal);
        }

        private static void ShowMenu() {
            Console.WriteLine("\n1: Add animal");
            Console.WriteLine("2: Show animal");
            Console.WriteLine("3: Delete animal");
            Console.WriteLine("4: Show all animal");
            Console.WriteLine("5:Exit");
            Console.WriteLine("");
        }
        
    }
}
