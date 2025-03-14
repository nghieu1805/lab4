using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Task
    {
        protected string Description;

        public Task()
        {
            this.SetDescription("Default task");
        }
        public Task(string description)
        {
            this.SetDescription(description);
        }

        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string description)
        {
            this.Description = description;
        }
        public void DisplayTask()
        {
            Console.WriteLine(GetDescription());
        }

    }
}
