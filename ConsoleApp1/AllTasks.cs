using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AllTasks
    {
        public string Name { get; }
        private List<Task> Tasks = new List<Task>();
        
        public AllTasks(string Name)
        {
            this.Name = Name;
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void Describe()
        {
            Console.WriteLine(Name);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach(Task task in Tasks)
            {
                task.Describe();
            }
        }

    }
}
