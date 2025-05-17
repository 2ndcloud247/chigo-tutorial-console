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
      static void Main(string[] args)
        {
            //// Create a list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Use LINQ to filter the list
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            // Print the filtered list
            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);

            }
            var a = 10;
            decimal b = 20.9m;
            float c = 30.5f;
            bool isFirstLoop = true;
            string name = "John";

            //If-Else Statement
            if (isFirstLoop == false)
            {
                Console.WriteLine("This is not the first loop");
            }
            else
            {
                Console.WriteLine("This is the first loop");
            }
            // var result = a + b;
            // Console.WriteLine($"The sum of {a} and {b} is {result}");
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a} is less than {b}");
            }
            else
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            // Loops

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Number: " + i);
            }

            //while Loop:

            int count = 0;
            while (count <= 4)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }

            Greet("Alice");
            Greet("Bob");

            //Arrays
            string[] fruits = { "Apple", "Banana", "Orange" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            //Classes and Objects

            Person person = new Person();
            person.Name = "Chigozie";

            person.Age = 25;
            person.SayHello();


            // developing a mini Caluulator

            bool keepRunning = true;
            while (keepRunning) {
                Console.Clear();
                Console.WriteLine("Welcome to the Calculator!");
                Console.WriteLine("================\n");
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operators (+, -, *, /): ");
                string op = Console.ReadLine();
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = 0;
                bool valid = true;
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if(num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero.");
                            valid = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        valid = false;
                        break;
                }
                if(valid)
                {
                    Console.WriteLine($"\nResult:  {result}");
                }

                Console.WriteLine("\nDo you want to perform another calculation? (y/n): ");
                string choice = Console.ReadLine().ToLower();
                if(choice != "y")
                {
                    keepRunning = false;
                }

                Console.WriteLine("\nThanks for using this calulator!");
            }

            Console.WriteLine(name);
            Console.WriteLine("hello world");
            Console.ReadLine();
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
