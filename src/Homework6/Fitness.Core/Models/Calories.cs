using System;

namespace Fitness.Core.Models
{
   public class Calories {

        public double CaloriesOnTime { get; set; }

        public DateTime Time;

        public Calories(double caloriesOnTime)
        {
            CaloriesOnTime = caloriesOnTime;
            Time = DateTime.Now;
        }
    }
}
