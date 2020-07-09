namespace Fitness.Core.Interfaces
{
    interface IAction {
        public double Walking(double timeWalking);

        public double Run(double timeWalking);

        public double Drivebicycle(double timeWalking);
        
    }
}
