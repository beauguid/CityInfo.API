using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        //Changed from JSONResult to IActionResult to allow for return of other-than-JSON requests and handle status codes
        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }
        //Changed from JSONResult to IActionResult to allow for return of other-than-JSON requests and handle status codes
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            //Gets the first or default value from List of cities by performing the LINQ query in method
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
