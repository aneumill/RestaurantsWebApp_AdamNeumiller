using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//Submission page model
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
        [Phone, Required, RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone number must be 10 digits. Ex. 111-111-1111 or 111.111.1111 or 1111111111")]
        public string RestaurantPhone { get; set; }
    }
}
