using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace Rest.Service.Models
{
    
    /// <summary>
    /// This is the user class
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// This is the date the user was added
        /// </summary>
        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
    
}
