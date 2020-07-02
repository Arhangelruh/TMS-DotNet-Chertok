using Homework4.Models;
using System;

namespace Homework4.Interfaces
{
    interface IAnimalAction {      
        public void Getinfo(Animal animal);
        public Animal CreateAnimal();
    }
}
