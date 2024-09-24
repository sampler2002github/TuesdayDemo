using Microsoft.AspNetCore.Mvc;
using TuesdayDemo.Data.Interface;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICity _city;
        public CitiesController(ICity city)
        {
            _city = city;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("GetAllCities")]
        public IActionResult GetAllCities()
        {
            return Ok(_city.GetAllCities());
        }
        [HttpGet]
        [Route("GetCityById")]
        public IActionResult GetCityById(int Id)
        {
            return Ok(_city.GetCityById(Id));
        }

        [HttpPost]
        [Route("AddCity")]
        public IActionResult AddCity(City city)
        {
            return Ok(_city.AddCity(city));
        }
        [HttpPut]
        [Route("UpdateCity")]
        public IActionResult UpdateCity(City city)
        {
            return Ok(_city.UpdateCity(city));
        }
        [HttpDelete]
        [Route("DeleteCity")]
        public IActionResult DeleteCity(int Id)
        {
            return Ok(_city.DeleteCity(Id));
        }
    }
}
