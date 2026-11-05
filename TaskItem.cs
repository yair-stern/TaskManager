using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class TaskItem
    {
        public String Title { get; set; }
        public int Id { get; set; }
        public Boolean IsCompleted { get; set; }
        public TaskItem (String title, int id)
        {
            Title = title;
            Id = id;
            IsCompleted = false;
        }

        public void PrintTask()
        {
            Console.Write(Title);
            Console.WriteLine(" (" + (IsCompleted ? 'V' : 'X') +')');
        }

        public void SetStatus(bool isCompleted)
        {
            IsCompleted = isCompleted;
        }
    }
}
