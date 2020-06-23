using System;

namespace Homework3
{
    public class Task {
        public string TaskName { get; set; }
        public string TaskTime { get; set; }
        private DateTime _creation;

        public Task() { }

        public Task(string a, string b) {
            TaskName = a;
            TaskTime = b;
            _creation = DateTime.Now;
        }

        public void Show() {
            Console.WriteLine($"Task: {TaskName}  Time from task:{TaskTime}  Task create:{_creation}");
        }
    }
}
