using DOTNET_Assessment1.Interfaces;
using DOTNET_Assessment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_Assessment1.Implementation
{
    public class PersonEvaluator : IPersonEvaluator
    {
        public Tier Evaluate(Person person)
        {
            if (person.Age < 18 && person.Age > 75)
            {
                return new Tier { TierName = " Not Eligible", IsHighRisk = false };
            }

            bool isHighRisk = person.HasHealthChallenges && person.HasPreviousClaims;

            string tierName;


            if (!isHighRisk)
                tierName = EvaluateTier(person);
            else
                tierName = "Standard";


            return new Tier
            {
                TierName = tierName,
                IsHighRisk = isHighRisk
            };
        }

      
        
        private string EvaluateTier(Person person)
        {
            if (person.Age >= 60)
                return "Senior";

            if (person.HasHealthChallenges)
                return "Care";

            if (person.NumberOfDependents > 3)
                return "Family";

            if (person.AnnualIncome > 1_000_000)
                return "Premium";

            return "Standard";
        }

    }
}
