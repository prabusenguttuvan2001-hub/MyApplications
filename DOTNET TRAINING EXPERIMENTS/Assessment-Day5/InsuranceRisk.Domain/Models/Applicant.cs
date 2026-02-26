using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRisk.Domain.Models
{
    public class Applicant
    {
        public int Age { get; }
        public int DrivingExperience { get; }
        public ClaimHistory History { get; }

        public Applicant(int age, int drivingExperience, ClaimHistory history)
        {
            if (age < 18)
                throw new ArgumentException("Applicant must be at least 18 years old");

            Age = age;
            DrivingExperience = drivingExperience;
            History = history;
        }

        //public bool IsExperiencedDriver() => DrivingExperience >= 2;
    }
}
