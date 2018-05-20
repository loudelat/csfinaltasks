using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Menu
    {
        List<AllTasks> allTasks = new List<AllTasks>();

        public void StartMenu()
        {
            bool hasExited = false;

            while(!hasExited)
            {
                ShowMenu();
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    CreateTask();
                }
                else if (userInput == "2")
                {
                    ShowTasks();
                }
                else if (userInput == "3")
                {
                    hasExited = true;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("Please select an option.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1) Creat new task");
            Console.WriteLine("2) List tasks and descriptions");
            Console.WriteLine("3) Exit");
        }

        public void CreateTask()
        {
            
            Console.Write("Enter New Task Number: ");
            int taskNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter New Task Name: ");
            string taskName = Console.ReadLine();

            Console.Write("Enter New Task Description: ");
            string taskDescription = Console.ReadLine();

            new Task(taskNumber, taskName, taskDescription);
                                    
        }

        public void ShowTasks()
        {
            Task task1 = new Task(1, "Create Tasks Program", "This is a task to create a Tasks list program in C#");
            Task task2 = new Task(2, "Zip Tasks Program", "This is a task to zip Tasks program");

            AllTasks tasks = new AllTasks("Lou's Tasks: ");
            tasks.AddTask(task1);
            tasks.AddTask(task2);

            tasks.Describe();

        }

    }
}
