namespace Fitness.Core.Interfaces
{
    interface IFitnesManager {
        public void AddAccount(string login, double weight, double height, int age);

        public void RemoveAccount(string login);

        public void UpdateCaloriesWithWalking(string login, double timeWalking);

        public void UpdateCaloriesWithRun(string login, double timeWalking);

        public void UpdateCaloriesWithDriveBicycle(string login, double timeWalking);

        public void GetStatistic(string login);
    }
}
