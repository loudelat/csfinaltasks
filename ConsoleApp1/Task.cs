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

        public void Describe()
        {
            Console.WriteLine(taskNumber + ") " + taskName + " - " + taskDescription);
        }
    }
}
