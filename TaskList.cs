using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class TaskList
    {
        public List<TaskItem> TasksList { get; set; } = new List<TaskItem>();
        public int NextId { get; set; } = 0;
        public int Length { get { return TasksList.Count; } }

        public void AddTask(String title)
        {
            TasksList.Add(new TaskItem(title, NextId++));
        }
        public void RemoveTask(int index)
        {
            String taskTitle = TasksList[index].Title;
            TasksList.RemoveAt(index);
            String message = "\'" + taskTitle + "\' deleted.";
            Console.WriteLine(message);
        }
        public void PrintList()
        {
            if (TasksList.Count == 0)
                Console.WriteLine("You have no tasks!");
            else if (TasksList.Count == 1){
                Console.WriteLine("You have only one task:");
                TasksList[0].PrintTask();
            }
            else
            {
                Console.WriteLine("Task List:\n_________________");
                for (int i = 0; i < TasksList.Count; i++)
                {
                    Console.Write(i + 1 + ". ");
                    TasksList[i].PrintTask();
                }
            }
                
        }
        public void ChangeTaskStatus(int index)
        {
            TasksList[index].SetStatus(!TasksList[index].IsCompleted);
            Console.WriteLine(
                "Status has been changed to " +
                (TasksList[index].IsCompleted ?
                "Completed." : "Not Completed.")
            );
        }
    }
}
