using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
namespace ConsoleApp1
{
   class TodoList
    {
        static string filePath = "tasks.txt";
        static void Mainh()
        {
            List<string> tasks = LoadTasks();
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== To-Do LIST APP ===\n");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("\nChoose an option:  ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ViewTasks(tasks);
                        break;
                    case "2":
                        AddTask(tasks);
                        break;
                    case "3":
                        RemoveTask(tasks);
                        break;
                    case "4":
                        SaveTasks(tasks);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
                if (running)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Goodbye!");
        }
        static List<string> LoadTasks()
        {
            List<string> tasks = new List<string>();
            if (File.Exists(filePath))
            {
                tasks.AddRange(File.ReadAllLines(filePath));

            }
            return tasks;

        }

        static void SaveTasks(List<string> tasks)
        {
            File.WriteAllLines(filePath, tasks);
            
        }

        static void ViewTasks(List<string> tasks)
        {
            Console.WriteLine("\n--- Your Tasks ---");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }

        static void AddTask(List<string> tasks)
        {
            Console.Write("\nEnter a new task: ");
            string task = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine($"Task '{task}' added.");
            }
            else
            {
                Console.WriteLine("Task cannot be empty.");
            }
        }

        static void RemoveTask(List<string> tasks)
        {
            ViewTasks(tasks);
            Console.Write("\nEnter the task number to remove: ");
            if(int.TryParse(Console.ReadLine(), out int index))
            {
                if(index >=1 && index <= tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                    Console.WriteLine($"Task {index} removed.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
