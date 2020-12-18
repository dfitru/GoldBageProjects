using System;
using System.Collections.Generic;

namespace _01_Komodo_Claims_Department
{
    
    public class ClaimRepo
    {
        private  Queue<Claim>_claimsDirectory = new Queue<Claim>();
        private int _claimID = 201901;
        //Random random = new Random();
        //Claim Create
        public void AddClaimToDirectory(Claim claim)
        {    
            claim.ClaimID = _claimID + 1;
            _claimsDirectory.Enqueue(claim);
            _claimID++;
        }
       //
        //Re,oving Claim Read
       
        public Queue<Claim> GetAllClaims()
        {
            return _claimsDirectory;
        }
       // ClaimRead Helper(Get Claim by ID)
        public Claim GetClaimBYID(int id)
        {
            foreach (Claim claim in _claimsDirectory)
            {
                if (claim.ClaimID == id)
                {
                    return claim;
                }

            }
            return null;
            
        }
        ////    Claim update
        //public bool UpdateClaim(int claimID, Claim newClaim)
        //{
        //    Claim oldClaim = GetClaimBYID(claimID);

        //    if (oldClaim!=null)
        //    {
        //        oldClaim.ClaimAmount = newClaim.ClaimAmount;
        //        oldClaim.Description = newClaim.Description;
        //        oldClaim.ClaimType = newClaim.ClaimType;
        //        oldClaim.DateOfIncident = newClaim.DateOfIncident;
        //        oldClaim.DateOfClaim = oldClaim.DateOfClaim;

        //        return true;
        //    }
        //    return false;
        //}
        //Developer Remove Claim
        public bool RemoveClaim(Claim claims)
        {
            Claim claim = GetClaimBYID(claims.ClaimID);
            if (claim == null)
            {
                return false;
            }
           int count = _claimsDirectory.Count;
            _claimsDirectory.Dequeue();
            
            if (_claimsDirectory.Count<count)
            {
                return true;
            }
            return false;
        }

        //Peek Helper

        public Claim PeekSeed()
        {
            return _claimsDirectory.Peek();
        }

    }
}
