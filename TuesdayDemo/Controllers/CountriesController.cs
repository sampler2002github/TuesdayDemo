using Microsoft.AspNetCore.Mvc;
using TuesdayDemo.Data.Interface;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CountriesController : Controller
    {
        private readonly ICountry _country; //called instance of country
        public CountriesController(ICountry country)
        {
            _country = country;
        }  
        [HttpGet]
        [Route("GetAllCountries")]
        public IActionResult GetAllCountries()
        {
            return Ok(_country.GetAllCountries());
        }
        [HttpGet]
        [Route("GetCountryById")]
        public IActionResult GetCountryById(int Id)
        {
            return Ok(_country.GetCountryById(Id));
        }
        [HttpPost]
        [Route("AddCountry")]
        public IActionResult AddCountry(Country country) //instance
        {
            return Ok(_country.AddCountry(country));
        }
        [HttpPut]
        [Route("UpdateCountry")]
        public IActionResult UpdateCountry(Country country)
        {
            return Ok(_country.UpdateCountry(country));
        }
        [HttpDelete]
        [Route("DeleteCountry")]
        public IActionResult DeleteCountry(int Id)
        {
            return Ok(_country.DeleteCountry(Id));
        }
    }
}
