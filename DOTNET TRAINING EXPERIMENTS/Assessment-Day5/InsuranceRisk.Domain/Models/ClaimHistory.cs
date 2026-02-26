using System;
using System.Collections.Generic;
using System.Linq;


namespace InsuranceRisk.Domain.Models
{
    public class ClaimHistory
    {
        public int IncidentCount { get; }

        public ClaimHistory(int incidentCount)
        {
            if (incidentCount < 0)
            {
                throw new ArgumentException("Incident count cannot be negative");
            }

            IncidentCount = incidentCount;
        }

        public bool HasSevereHistory()
        {
            if (IncidentCount >= 3)
            {
                return true;
            }
            return false;
        }
    }
}
