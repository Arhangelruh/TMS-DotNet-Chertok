using Fitness.Core.Interfaces;

namespace Fitness.Core.Models
{
    class Actions : IAction
    {

        public double Walking(double timeWalking)
        {

            const double caloriespertimewalking = 3.2;
            return timeWalking * caloriespertimewalking;
        }

        public double Run(double timeWalking)
        {

            const double caloriespertimerun = 5.1;
            return timeWalking * caloriespertimerun;
        }

        public double Drivebicycle(double timeWalking)
        {

            const double caloriespertimebicycle = 8.3;
            return timeWalking * caloriespertimebicycle;
        }
    }
}
