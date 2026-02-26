using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.LINQ
{
    internal class LinqExecutions
    {
        //public static void Main(string [] args)
        //{
        //    List<Employee> employees = new List<Employee>
        //    {
        //        new Employee { Id = 1, Name = "Prabu", Department = "IT", Salary = 60000 },
        //        new Employee { Id = 2, Name = "Ravi", Department = "HR", Salary = 40000 },
        //        new Employee { Id = 3, Name = "Kumar", Department = "IT", Salary = 75000 },
        //        new Employee { Id = 4, Name = "Anu", Department = "Finance", Salary = 50000 },
        //        new Employee { Id = 5, Name = "Divya", Department = "HR", Salary = 45000 }
        //    };

        //    var filteredEmployeeBySalary = employees.Where(s => s.Salary > 50000).Select(s => new { s.Id, s.Name, s.Salary})
        //                                            .OrderBy(e => e.Id)
        //                                            .OrderBy(e => e.Name)
        //                                            .ToList();


        //    filteredEmployeeBySalary.ForEach(e =>
        //    {
        //        Console.WriteLine($"Id: {e.Id}"+$" Name - {e.Name} Salary - {e.Salary}");
        //    });



        //}


    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
