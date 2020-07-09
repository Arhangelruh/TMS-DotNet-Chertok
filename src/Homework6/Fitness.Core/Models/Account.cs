using Fitness.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Fitness.Core.Models
{
    public class Account : IAccount
    {
        public string Login { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public IList<Calories> CaloriesPerDay { get; set; } = new List<Calories>();
    }
}
