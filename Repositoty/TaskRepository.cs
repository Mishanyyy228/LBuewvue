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
                new ClassTask{Category="njvn234234",Name="Прогулка с собакой",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="jvekbvr",IsCompleted=false},
                new ClassTask{Category="Дом",Name="Пробежка утром",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="Пробежать утром 5км",IsCompleted=false},
                new ClassTask{Category="Дом",Name="Еда",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="Приготовить ужин",IsCompleted=false},
                new ClassTask{Category="YtДом",Name="Еда",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="VGVUYVYGIGV",IsCompleted=true},
                new ClassTask{Category="YtДом",Name="Едsdvi si dvа",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="VyrryuGIGV",IsCompleted=true},
                new ClassTask{Category="nnjbrebejvn234234",Name="Прогулка с собакой",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="jvekbvr",IsCompleted=false},
                new ClassTask{Category="Домerueh",Name="Пробежка утром",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="Пробежать утром 5км",IsCompleted=false},
                new ClassTask{Category="До1248м",Name="Еда",Date=DateTime.Now,DateAndTime=DateTime.Now,Description="Приготовить ужин",IsCompleted=false},

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
        //public static void GetAllCustomers()
        //{
        //    ClassTask context = new ClassTask();
        //    var names = context.
        //        .OrderBy(c => c.LastName)
        //        .Select(c => c.LastName);
        //    foreach (string lastname in names)
        //        Console.WriteLine(lastname);
        //}


    }
}
