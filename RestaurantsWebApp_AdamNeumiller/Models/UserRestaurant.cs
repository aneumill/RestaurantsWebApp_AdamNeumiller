using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantsWebApp_AdamNeumiller.Models
{
    public class UserRestaurant
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string Dish { get; set; }
        [Phone, Required, RegularExpression("[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]")]
        public string RestaurantPhone { get; set; }
    }
}
