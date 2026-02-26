using DOTNET_Assessment1.Implementation;
using DOTNET_Assessment1.Interfaces;
using DOTNET_Assessment1.Models;

namespace DOTNET_Assessment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Peoples = new List<Person>
            {
                new Person{Name = "Sangeeth",Age = 19, HasHealthChallenges= false, NumberOfDependents= 2, AnnualIncome = 300000, HasPreviousClaims = false},
                new Person{Name = "Vijay",Age = 29, HasHealthChallenges = true, NumberOfDependents= 4, AnnualIncome = 1300000, HasPreviousClaims = true},
                new Person{Name = "Mokesh", Age = 56, HasHealthChallenges= false, NumberOfDependents= 4, AnnualIncome = 1100000, HasPreviousClaims = false},
                new Person{Name = "Abishek", Age = 10, HasHealthChallenges= true, NumberOfDependents= 0, AnnualIncome = 3000, HasPreviousClaims = true},
                new Person{Name = "Mugesh", Age = 34, HasHealthChallenges = false, NumberOfDependents = 4, AnnualIncome = 900000, HasPreviousClaims = false},
                new Person{Name = "Santhosh", Age = 68, HasHealthChallenges = false, NumberOfDependents = 4, AnnualIncome = 2300000, HasPreviousClaims = false},
                new Person{Name = "Prabu", Age = 24, HasHealthChallenges= true, NumberOfDependents = 3, AnnualIncome = 1600000, HasPreviousClaims = true},
            };

            IPersonEvaluator evaluator = new PersonEvaluator();
             
            var results = Peoples.Select( p=> new { p.Name, Tier = evaluator.Evaluate(p) }).ToList();

            foreach( var r in results )
            {
                Console.WriteLine($"Name: {r.Name}, Tier: {r.Tier.TierName}, High Risk: {r.Tier.IsHighRisk}");
            }


        }
    }

}
