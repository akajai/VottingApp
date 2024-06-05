using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class CandidateVote
    {
        public List<Candidate> candidates { get; set; } = new List<Candidate>();
        public List<Voter> voters { get; set; } = new List<Voter>();
    }
}
