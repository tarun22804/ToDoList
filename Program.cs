using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("Enter 1 to add a task");
                Console.WriteLine("Enter 2 to remove a task");
                Console.WriteLine("Enter 3 to view all tasks");
                Console.WriteLine("Enter e to exit");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter the task you would like to add:");
                    string task = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(task))
                    {
                        taskList.Add(task);
                        Console.WriteLine("✅ Task added!");
                    }
                    else
                    {
                        Console.WriteLine("⚠ Task cannot be empty!");
                    }
                }
                else if (option == "2")
                {
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("⚠ No tasks to remove!");
                        continue;
                    }

                    Console.WriteLine("Here are your tasks:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {taskList[i]}");
                    }

                    Console.Write("Enter the task number you want to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= taskList.Count)
                    {
                        taskList.RemoveAt(taskNumber - 1);
                        Console.WriteLine("✅ Task removed!");
                    }
                    else
                    {
                        Console.WriteLine("⚠ Invalid task number. Please enter a valid number.");
                    }
                }
                else if (option == "3")
                {
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("⚠ Your to-do list is empty.");
                    }
                    else
                    {
                        Console.WriteLine("📋 Here are your tasks:");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {taskList[i]}");
                        }
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("👋 Exiting the program...");
                }
                else
                {
                    Console.WriteLine("⚠ Invalid option. Please try again.");
                }
            }

            Console.WriteLine("🎉 Thank you for using the To-Do List!");
        }
    }
}
