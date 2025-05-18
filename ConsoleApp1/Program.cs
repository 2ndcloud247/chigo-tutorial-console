using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace ConsoleApp1
{
    internal class Program
    {
        static string filePath = "tasks.txt";
        static void Main(string[] args)
        {
            ////// Create a list of integers
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //// Use LINQ to filter the list
            //var evenNumbers = numbers.Where(n => n % 2 == 0);
            //// Print the filtered list
            //Console.WriteLine("Even numbers:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);

            //}
            //var a = 10;
            //decimal b = 20.9m;
            //float c = 30.5f;
            //bool isFirstLoop = true;
            //string name = "John";

            ////If-Else Statement
            //if (isFirstLoop == false)
            //{
            //    Console.WriteLine("This is not the first loop");
            //}
            //else
            //{
            //    Console.WriteLine("This is the first loop");
            //}
            //// var result = a + b;
            //// Console.WriteLine($"The sum of {a} and {b} is {result}");
            //if (a > b)
            //{
            //    Console.WriteLine($"{a} is greater than {b}");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine($"{a} is less than {b}");
            //}
            //else
            //{
            //    Console.WriteLine($"{a} is equal to {b}");
            //}
            //// Loops

            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine("Number: " + i);
            //}

            ////while Loop:

            //int count = 0;
            //while (count <= 4)
            //{
            //    Console.WriteLine("Count: " + count);
            //    count++;
            //}

            //Greet("Alice");
            //Greet("Bob");

            ////Arrays
            //string[] fruits = { "Apple", "Banana", "Orange" };

            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}
            ////Classes and Objects

            //Person person = new Person();
            //person.Name = "Chigozie";

            //person.Age = 25;
            //person.SayHello();


            //// developing a mini Caluulator

            //bool keepRunning = true;
            //while (keepRunning) {
            //    Console.Clear();
            //    Console.WriteLine("Welcome to the Calculator!");
            //    Console.WriteLine("================\n");
            //    Console.Write("Enter first number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Enter operators (+, -, *, /): ");
            //    string op = Console.ReadLine();
            //    Console.Write("Enter second number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());
            //    double result = 0;
            //    bool valid = true;
            //    switch (op)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            break;
            //        case "/":
            //            if(num2 == 0)
            //            {
            //                Console.WriteLine("Error: Division by zero.");
            //                valid = false;
            //            }
            //            else
            //            {
            //                result = num1 / num2;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Error: Invalid operator.");
            //            valid = false;
            //            break;
            //    }
            //    if(valid)
            //    {
            //        Console.WriteLine($"\nResult:  {result}");
            //    }

            //    Console.WriteLine("\nDo you want to perform another calculation? (y/n): ");
            //    string choice = Console.ReadLine().ToLower();
            //    if(choice != "y")
            //    {
            //        keepRunning = false;
            //    }

            //    Console.WriteLine("\nThanks for using this calulator!");
            //}


            //Console.WriteLine(name);
            //Console.WriteLine("hello world");
            //Console.ReadLine();

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
            if (!string.IsNullOrWhiteSpace(task))
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
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= tasks.Count)
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
        class Person
        {
            public string Name;
            public int Age;

            public void SayHello()
            {
                Console.WriteLine("Hi, I'm " + Name + "I am, " + Age);
            }
        }

        //function and methods
        static void Greet(string names)
        {
            Console.WriteLine("Hello, " + names);
        }

       
    }
}
