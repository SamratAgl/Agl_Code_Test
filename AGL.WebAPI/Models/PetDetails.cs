using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGL.WebAPI.Models
{
    public class PetDetails
    {
        [JsonProperty("name")]
        public string PetName { get; set; }

        [JsonProperty("type")]
        public string PetType { get; set; }
    }
}
