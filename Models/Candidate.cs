using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_voting.Models
{
    public class Candidate
    {
        public int CandidateNIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
