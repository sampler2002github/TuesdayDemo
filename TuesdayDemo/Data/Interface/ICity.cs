using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Data.Interface
{
    public interface ICity
    {
        bool AddCity(City city);
        bool UpdateCity(City city);
        bool DeleteCity(int Id);
        List<City> GetAllCities();
        City GetCityById(int Id);
    }
}
