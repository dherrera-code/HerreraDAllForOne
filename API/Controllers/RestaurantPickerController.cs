using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _restaurantPicker;
        public RestaurantPickerController(RestaurantPickerService restaurantPicker)
        {
            _restaurantPicker = restaurantPicker;
        }

        [HttpGet("/burgerPizzaMisc/{category}")]
        public string GetRestaurant(string category)
        {
            return _restaurantPicker.GetRestaurant(category);
        }
    }
}