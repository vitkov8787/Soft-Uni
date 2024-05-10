using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace api.Controllers
{
    // [Route("[controller]")]
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
                    var json = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON to concrete object
                    var apiResponse = JsonConvert.DeserializeObject<ApiModel>(json);

                    // Create model and populate Text
                    var model = new ApiModel();
                    model.Text = apiResponse?.Text;

                    return View(model);
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