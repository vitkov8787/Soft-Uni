using System;
using System.Net.Http;
using System.Threading.Tasks;
using FetchAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FetchAPI.Controllers
{
    public class ApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://catfact.ninja/");
                var response = await client.GetAsync("fact");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var apiResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<CatFactApiResponse>(jsonString);
                    var apiModel = new ApiModel
                    {
                        Message = apiResponse?.Fact
                    };
                    return View(apiModel);
                }
                else
                {
                    // Handle error
                    return View("Error");
                }
            }
        }
    }
}
