using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantsWebApp_AdamNeumiller.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsWebApp_AdamNeumiller.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {

                restaurantList.Add($"#{r.iRestaurantRanking} {r.sRestaurantName} -- {r.sRestaurantAddress} -- Favorite Dish: {r.sRestaurantDish ?? "It's all Tasty" }--{r.sRestaurantPhone} -- Website: <a href='{ r.sRestaurantWebsite ?? "#"}'> {r.sRestaurantWebsite ?? "Coming Soon"} </a>"); 
            }

            return View(restaurantList);
        }
        [HttpGet]
        public IActionResult AddSuggestion()
        {
            return View();
        }
     
        public IActionResult ViewSuggestion()
        {
            return View(RestaurantList.RestaurantSuggestions);
        }
        [HttpPost]
        public IActionResult AddSuggestion(UserRestaurant appResponse)
        {
            if (ModelState.IsValid)
            {
                RestaurantList.AddSuggestion(appResponse);
                return View("Confirmation", appResponse);
            }
            else
            {
                return View();
            }
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
