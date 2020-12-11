using System;
using System.Collections.Generic;

namespace _01_Komodo_Claims_Department
{
    
    public class ClaimRepo
    {
        private readonly List<Claim>_claimsDirectory = new List<Claim>();
        private int _claimID = 201901;
        Random random = new Random();
        

        //Claim Create
        public void AddClaimToDirectory(Claim claim)
        {
            
            claim.ClaimID = _claimID + 1;
            Console.WriteLine(claim.ClaimID);
            _claimsDirectory.Add(claim);
            _claimID++;
        }
        //ClaimRead
        public List<Claim> GetAllClaims()
        {
            return _claimsDirectory;
        }
        //ClaimRead Helper(Get Claim by ID)
        public Claim GetClaimBYID(int id)
        {
            foreach (var claim in _claimsDirectory)
            {
                if (claim.ClaimID==id)
                {
                    return claim;
                }

            } return null;
        }
        // Developer update
        public bool UpdateClaim(int claimID, Claim newClaim)
        {
            Claim oldClaim = GetClaimBYID(claimID);

            if (oldClaim!=null)
            {
                oldClaim.ClaimAmount = newClaim.ClaimAmount;
                oldClaim.Description = newClaim.Description;
                oldClaim.ClaimType = newClaim.ClaimType;
                oldClaim.DateOfIncident = newClaim.DateOfIncident;
                oldClaim.DateOfClaim = oldClaim.DateOfClaim;

                return true;
            }
            return false;
        }
        //Developer Remove Claim

        public bool RemoveClaim(int claimID)
        {
            Claim claim = GetClaimBYID(claimID);
            if (_claimsDirectory.Remove(claim))
            {
                return true;
            }
            return false;
        }

    }
}
