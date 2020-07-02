using Homework4.Enums;
using Homework4.Interfaces;
using Homework4.Models;
using System;

namespace Homework4.Logic
{
    class ZooAnimalAction:Animal,IAnimalAction {
        
        public void Getinfo(Animal animal) {
            Console.WriteLine($"ID:{animal.Getid()}");
            Console.WriteLine($"Variety:{animal.Variety}");
            Console.WriteLine($"Name:{animal.Name}");
            Console.WriteLine($"Taxonomic class:{animal.TaxonomikClass}");
        }
        public Animal CreateAnimal() {
            return new Animal();
        }
        public Animal CreateAnimal(string variety)
        {
            return new Animal(variety);
        }
        public Animal CreateAnimal(string variety, string name)
        {
            return new Animal(variety, name);
        }
        public Animal CreateAnimal(string variety, string name, Taxonomic taxonomikClass)
        {
            return new Animal(variety, name, taxonomikClass);
        }
    }
}
