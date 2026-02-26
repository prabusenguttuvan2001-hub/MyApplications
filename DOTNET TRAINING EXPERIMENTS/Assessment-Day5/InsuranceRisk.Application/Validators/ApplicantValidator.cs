using InsuranceRisk.API.DTOs;
using InsuranceRisk.Application.Interfaces;
using System;

namespace InsuranceRisk.Application.Validators
{
    public class ApplicantValidator : IApplicantValidator
    {
        public void Validate(RiskRequest request)
        {
            if (request == null)
            {
                throw new Exception("Request cannot be null");
            }

            if (request.Age < 18)
            {
                throw new Exception("Applicant must be at least 18 years old");
            }

            if (request.Experience < 0)
            {
                throw new Exception("Experience cannot be negative");
            }

            if (request.Incidents < 0)
            {
                throw new Exception("Incident count cannot be negative");
            }
        }
    }
}
