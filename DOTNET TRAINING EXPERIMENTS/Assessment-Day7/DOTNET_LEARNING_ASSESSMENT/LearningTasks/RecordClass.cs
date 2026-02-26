using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.LearningTasks
{
    internal class RecordClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //static void Main(string[] args)
        //{
        //    RecordClass rc1 = new RecordClass { Name = "Prabu", Age = 24 };
        //    RecordClass rc2 = new RecordClass { Name = "Prabu", Age = 24 };

        //    Console.WriteLine(rc1 == rc2); // false


        //    Person p1 = new Person("Prabu",24);
        //    Person p2 = new Person("Prabu",24);

        //    Console.WriteLine(p1 == p2); // true
        //}
    }

    record Person(string PersonName, int PersonAge);
}
