namespace Fitness.Core.Interfaces
{
    interface IAccount {
        public string Login { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
   
    }
}
