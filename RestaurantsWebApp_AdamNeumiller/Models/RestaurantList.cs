using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsWebApp_AdamNeumiller.Models
{
    public class RestaurantList
    {
        private static List<UserRestaurant> suggestions_list = new List<UserRestaurant>();

        public static IEnumerable<UserRestaurant> RestaurantSuggestions => suggestions_list;

        public static void AddSuggestion(UserRestaurant suggestion)
        {
            suggestions_list.Add(suggestion);
        }
    }
}
