using System;
using System.ComponentModel.Design;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContenue = true;
            TaskList taskList1 = new TaskList();
            while (isContenue)
            {
                int userChoise = ChoiseMenu();
                switch (userChoise)
                {
                    case 1:
                        {
                            GetAndAddTask(taskList1);
                            break;
                        }
                    case 2:
                        {
                            ChangeTaskStatus(taskList1);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Task List:\n_________________");
                            taskList1.PrintList();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("You want to delete task."
                                + "\nWhich task?" +
                                "\nEnter its number");
                            taskList1.PrintList();
                            int index = int.Parse(Console.ReadLine()) - 1;
                            String taskName = taskList1.TasksList[index].Title;
                            //taskList1.RemoveTask(0);
                            taskList1.RemoveTask(index);
                            Console.WriteLine("\'" + taskName + "\' deleted.");
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Have a good day!");
                            isContenue = false;
                            break;
                        }

                    default:
                        {
                            Console.Write("'" + userChoise + "' is not a legal number");
                            break;
                        }
                }
            }
        }

        static int ChoiseMenu()
        {
            String[] options = { "Add taks", "Cange task status", "Display tasks list", "Delete task", "Exit" };
            Console.WriteLine("Tasks manager. Chooce option by enter its number:");
            int index = 1;
            foreach (var option in options)
            {
                Console.WriteLine(index++ + ". " + option + ".");
            }
            return getIndexFromUser(1, options.Length);
        }

        static int getIndexFromUser(int min, int max)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                    if (max >= input && input >= min) return input;
                    else
                    {
                        Console.WriteLine("Enter number in " + min + "-" + max + " range!");
                    }
                else
                {
                    Console.WriteLine("Enter digits only!");
                }
            }
        }

        static void GetAndAddTask(TaskList taskList1)
        {
            Console.WriteLine("Enter your task:");
            String? title;
            do
            {
                title = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(title))
                    Console.WriteLine("Please nter at least one visible character:");
            }
            while (String.IsNullOrWhiteSpace(title));
            taskList1.AddTask(title);
            Console.WriteLine("Task Added");
        }

        static void ChangeTaskStatus(TaskList taskList1)
        {
            if (taskList1.Length == 0)
                Console.WriteLine("You have no tasks!");
            else if (taskList1.Length == 1)
            {
                Console.WriteLine("You have only one task:");
                taskList1.PrintList();
                Console.WriteLine("You want to mark it as " +
                    (taskList1.TasksList[0].IsCompleted ? "Not Completed" : "Completed")
                    + "? Enter Y/N."
                );
                //ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char answer = char.ToLower(Console.ReadKey(true).KeyChar);
                if (answer == 'y') taskList1.ChangeTaskStatus(0);
                else if (answer != 'n')
                    Console.WriteLine("You don't want to change. It is still " +
                        (taskList1.TasksList[0].IsCompleted ? "Completed" : "Not Completed"));

            }
            else if (taskList1.Length > 1){
                Console.WriteLine("Enter the number of the task that you want to change its status:");
                taskList1.PrintList();
                int index = getIndexFromUser(1, taskList1.Length) - 1;
                taskList1.ChangeTaskStatus(index);
            }
        }
    }
}
