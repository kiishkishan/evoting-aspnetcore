using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_voting.Models
{
    public class Voting
    {
        public int VoterNIC { get; set; }
        public int CandidateNIC { get; set; }
        public int ElectionID { get; set; }
        public DateTime Data { get; set; }

    }
}
