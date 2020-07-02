using Homework4.Interfaces;
using Homework4.Logic;
using Homework4.Models;
using System;
using System.Collections.Generic;

namespace Homework4
{
    class ZooManager:IZooManager
    {
        private readonly ZooAnimalAction _animalManager=new ZooAnimalAction();
        List<Animal> animals = new List<Animal>();

        public void GetAnimal(string variety) {
            foreach (var animal in animals) {
                if (animal.Variety == variety)
                {
                    _animalManager.Getinfo(animal);
                }
            }
        }
        public void GetAllAnimals()
        {
            foreach (var animal in animals)
            {
                _animalManager.Getinfo(animal);
            }
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAnimal added :)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Remove(string id) {
         
            foreach (var animal in animals)
            {
                Guid returnid =animal.Getid();
                string animalid = returnid.ToString();
                
                if (animalid==id)
                {
                    animals.Remove(animal);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nAnimal removed");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                
            }

        }
    }
}
