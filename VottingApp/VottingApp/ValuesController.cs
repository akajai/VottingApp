using Microsoft.AspNetCore.Mvc;
using Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VottingApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public CandidateVote Get()
        {
            var voters = Enumerable.Range(1, 10).Select(a => new Voter
            {
                Id = a,
                HasVoted = false,
                Name = $"Voter {a}"
            }).ToList();
            var candidates = Enumerable.Range(1, 10).Select(a => new Candidate
            {
                Id = a,
                Name = $"Candidate {a}",
                Count = 0

            }).ToList();
            CandidateVote? candidateVote = new CandidateVote {candidates = candidates,voters=voters};
            return candidateVote;      
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
