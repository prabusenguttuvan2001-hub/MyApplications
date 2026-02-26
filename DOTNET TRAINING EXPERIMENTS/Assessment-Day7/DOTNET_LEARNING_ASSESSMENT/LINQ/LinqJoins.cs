using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.LINQ
{
    internal class LinqJoins
    {
        //static void Main(string[] args)
        //{
        //    var employees = new List<Employee>
        //    {
        //        new Employee { Id = 1, Name = "Prabu", DepartmentId = 1 },
        //        new Employee { Id = 2, Name = "Ravi", DepartmentId = 2 },
        //        new Employee { Id = 3, Name = "Kumar", DepartmentId = 1 },
        //        new Employee { Id = 4, Name = "Anu", DepartmentId = 3 }
        //    };

        //    var departments = new List<Department>
        //    {
        //        new Department { Id = 1, DepartmentName = "IT" },
        //        new Department { Id = 2, DepartmentName = "HR" }
        //    };

        //    var joinedRows = employees.Join(departments,
        //        emp => emp.DepartmentId,
        //        d => d.Id,
        //        (emp, d) => new
        //        {
        //            emp.Name,
        //            d.DepartmentName
        //        }).ToList(); // Where(e => e.Name == "Prabu" && e.DepartmentName == "IT");

        //    //joinedRows.ForEach(e =>
        //    //{
        //    //    Console.WriteLine(e.Name +" "+ e.DepartmentName);
        //    //});
        //}
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int DepartmentId { get; set; }
        }
        class Department
        {
            public int Id { get; set; }
            public string DepartmentName { get; set; }
        }
    }
}
