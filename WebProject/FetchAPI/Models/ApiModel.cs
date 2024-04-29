using System;

namespace FetchAPI.Models
{
    public class ApiModel
    {
        public string? Message { get; set; }

        public override string ToString()
        {
            return $"{Message}";
        }
    }

    public class CatFactApiResponse
    {
        public string? Fact { get; set; }
        public int Length { get; set; }
    }
}
