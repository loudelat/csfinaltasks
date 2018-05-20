using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task();
            task1.taskNumber = 1;
            task1.taskName = "Create Tasks Program";
            task1.taskDescription = "This is a task to create a Tasks list program in C#";

            task1.Describe();

            Console.Read();
        }
    }
}
