using Fitness.Core.Interfaces;
using Fitness.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness.Core
{
    public class FitnesManager : IFitnesManager
    {
        public IList<Account> tracker = new List<Account>();

        public void AddAccount(string login, double weight, double height, int age) {

            var person = tracker.FirstOrDefault(c=>c.Login==login);
            if (person == null)
            {
                var account = new Account
                {
                    Login = login,
                    Weight = weight,
                    Height = height,
                    Age = age
                };
                tracker.Add(account);
            }
            else {
                Console.WriteLine($"This {login} already exist");
            }
        }

        public void RemoveAccount(string login)
        {

            var person = tracker.FirstOrDefault(c => c.Login == login);
            if (person == null)
            {
                Console.WriteLine($"{login} not found");
            }
            else
            {
                tracker.Remove(person);
            }
        }

        public void UpdateCaloriesWithWalking(string login, double timeWalking) {
           
            var person = tracker.FirstOrDefault(c => c.Login == login);
            if (person == null)
            {
                Console.WriteLine($"{login} not found");
            }
            else
            {
                Actions actions = new Actions();
                var walking = actions.Walking(timeWalking);
                Calories calories = new Calories(walking);
                person.CaloriesPerDay.Add(calories);
            }
        }

        public void UpdateCaloriesWithRun(string login, double timeWalking)
        {

            var person = tracker.FirstOrDefault(c => c.Login == login);
            if (person == null)
            {
                Console.WriteLine($"{login} not found");
            }
            else
            {
                Actions actions = new Actions();
                var walking = actions.Run(timeWalking);
                Calories calories = new Calories(walking);
                person.CaloriesPerDay.Add(calories);
            }
        }

        public void UpdateCaloriesWithDriveBicycle(string login, double timeWalking)
        {

            var person = tracker.FirstOrDefault(c => c.Login == login);
            if (person == null)
            {
                Console.WriteLine($"{login} not found");
            }
            else
            {
                Actions actions = new Actions();
                var walking = actions.Drivebicycle(timeWalking);
                Calories calories = new Calories(walking);
                person.CaloriesPerDay.Add(calories);
            }
        }

        public void GetStatistic(string login) 
        {
            var person = tracker.FirstOrDefault(c => c.Login == login);
            if (person == null)
            {
                Console.WriteLine($"{login} not found");
            }
            else
            {
                Console.WriteLine($"Show statistic from login: {login}");
                Console.WriteLine($"Show calories: ");
                double Calories=0;
                foreach (var item in person.CaloriesPerDay) {
                    Console.WriteLine($"Date:{item.Time} Calories:{item.CaloriesOnTime}");
                    Calories += item.CaloriesOnTime;
                }
                Console.WriteLine($"Total calories: {Calories}");
            }
        }
    }
}
