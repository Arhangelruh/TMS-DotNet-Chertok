using Homework4.Models;

namespace Homework4.Interfaces
{
    interface IZooManager {
        public void GetAnimal(string variety);
        public void GetAllAnimals();
        public void AddAnimal(Animal animal);

        public void Remove(string id);
    }
}
