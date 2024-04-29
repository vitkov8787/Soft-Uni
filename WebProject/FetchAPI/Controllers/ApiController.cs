using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FetchAPI.Controllers
{
    public class ApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            // call the API
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://catfact.ninja/fact");
                var response = await client.GetAsync("fact");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var apiModel = new Models.ApiModel();

                    apiModel.Message = jsonString;
                    return View(apiModel);
                }
                else
                {
                    //error\
                    return View("Error");
                }
            }
        }
    }
}