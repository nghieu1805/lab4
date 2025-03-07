using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class ToDoList
    {
        List<Task> tasks = new List<Task>();
        public void insertTask (Task task)
        {
            tasks.Add(task);
        }
        public void displayTasks()
        {
            int i = 1;
            foreach (Task task in tasks) {
                Console.Write(i + ": ");
                Console.WriteLine(task.getDescription);
        }
    }
}
