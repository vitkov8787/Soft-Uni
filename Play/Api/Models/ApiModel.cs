using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace api.Models
{
    public class ApiModel
    {
        [JsonProperty("fact")]
        public string? Text { get; set; }


    }
}