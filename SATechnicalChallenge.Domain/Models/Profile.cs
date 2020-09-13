using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SATechnicalChallenge.Domain.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public bool Status { get; set; }
    }
}
