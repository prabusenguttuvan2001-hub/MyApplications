using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.LINQ
{
    internal class LinqGroupBy
    {
        //static void Main(string[] args)
        //{

        //    var users = new List<User>
        //    {
        //        new User { Id = 1, Email = "a@gmail.com" },
        //        new User { Id = 2, Email = "b@gmail.com" },
        //        new User { Id = 3, Email = "a@gmail.com" },
        //        new User { Id = 4, Email = "c@gmail.com" },
        //        new User { Id = 5, Email = "b@gmail.com" }
        //    };

        //    var DuplicateEmails = users.GroupBy(e => e.Email)
        //                               .Where(g => g.Count() > 1)
        //                               .Select(s => s.Key)
        //                               .ToList(); //ForEach(f => {Console.WriteLine(f.email)});
          
        //}

        class User
        {
            public int Id { get; set; }
            public string Email { get; set; }
        }

        
    }
}
