using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantsWebApp_AdamNeumiller.Models
{
    public class Restaurant
    {
        
        public Restaurant (int rank)
         {
        iRestaurantRanking = rank;
         }
        [Required]
        public int iRestaurantRanking { get;  }
        [Required]
        public string sRestaurantName { get; set;  }
        
        public string sRestaurantDish { get; set; } = "It's all tasty!";
 
        public string sRestaurantAddress { get; set;  }
        [Required]
        public string sRestaurantPhone { get; set; }
        public string? sRestaurantWebsite { get; set; } = "Coming Soon!";
        public static Restaurant[] GetRestaurants() 
        {
            Restaurant r1 = new Restaurant(1)
            {
                sRestaurantName = "Don Joaquins",
                sRestaurantAddress = "150 W 1230 N St, Provo, UT 84604",
                sRestaurantDish = "Pollo Burritto",
                sRestaurantPhone = "(801) 400-2894",
                sRestaurantWebsite = "https://stdonjoaquin.com/"
            };
            Restaurant r2 = new Restaurant(2)
            {
                
                sRestaurantName = "J-Dawgs",
                sRestaurantAddress = "858 700 E, Provo, UT 84606",
                sRestaurantDish = "Polish Dawg",
                sRestaurantPhone = "(801) 842-1898",
                sRestaurantWebsite = "https://jdawgs.com/",
            };
            Restaurant r3 = new Restaurant(3)
            {
                
                sRestaurantName = "Bombay House",
                sRestaurantAddress = "123 Sesame Street",
                sRestaurantDish = "Chicken Vindaloo",
                sRestaurantPhone = "(801) 373-6677",
                sRestaurantWebsite = "https://bombayhouse.com/",
            };
            Restaurant r4 = new Restaurant(4)
            {
                
                sRestaurantName = "Asa Ramen",
                sRestaurantAddress = "1120 State St, Orem, UT 84097",
                sRestaurantDish = null,
                sRestaurantPhone = "(801) 842-1898",
                sRestaurantWebsite = null,
            }; 
            Restaurant r5 = new Restaurant(5)
            {
          
                sRestaurantName = "Brick Oven",
                sRestaurantAddress = "111 E 800 N, Provo, UT 84606",
                sRestaurantDish = "Margarita Pizza",
                sRestaurantPhone = "(801) 374-8800",
                sRestaurantWebsite = "https://www.brickovenrestaurants.com/",
            };
            return new Restaurant[] { r1, r2, r3, r4, r5 }; 
        }

    }
}
