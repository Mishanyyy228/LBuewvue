using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using taskLibrary;
using TodoEntities;


namespace LB.Repositoty
{
    public class TaskRepository
    {
        private static List<ClassTask> Tasks = new List<ClassTask>()
       {

       };
    public static IEnumerable<ClassTask> AllTasks => Tasks;
        public static ClassTask CurrentTask { get; private set; }
        public bool AddTask(string category, string name, string description)
        {
            var newTask = new ClassTask
            {
                Category=category,
                Name = name,
                Description = description,
                IsCompleted = false,
                DateAndTime = DateTime.Now,
                Date = DateTime.Now,
            };
            Tasks.Add(newTask);
            CurrentTask = newTask;
            return true;
        }
    }
}
