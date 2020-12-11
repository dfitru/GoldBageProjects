using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Komodo_Claims_Department
{
    public enum ClaimOptions
    {
        Car = 1,
        Home,
        Renter
    }
   public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimOptions ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public Claim(ClaimOptions claimType, string description, double amount,DateTime incidentDate,DateTime claimDate, bool validation)
        {
           
            ClaimType = claimType;
            Description = description;
            ClaimAmount = amount;
            DateOfIncident = incidentDate;
            DateOfClaim = claimDate;
        }
    }
}
