using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task
    {
        public int taskNumber { get; set; }
        public string taskName { get; set; }
        public string taskDescription { get; set; }

        public Task(int taskNumber, string taskName, string taskDescription)
        {
            this.taskNumber = taskNumber;
            this.taskName = taskName;
            this.taskDescription = taskDescription;
        }

        public void Describe()
        {
            Console.WriteLine(taskNumber + ") " + taskName + " - " + taskDescription);
        }
    }
}
