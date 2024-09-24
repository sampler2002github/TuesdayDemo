using TuesdayDemo.Data.Interface;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Data.Repository
{
    public class CitiesRepositry : ICity
    {
        private readonly ApplicationDbContext _context;
        public CitiesRepositry(ApplicationDbContext  context)
        {
            _context = context;
        }
        public bool AddCity(City city)
        {
            try
            {
                _context.Citytbl.Add(city);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
              return false;
            }
        }

        public bool DeleteCity(int Id)
        {
            try
            {
                var city = _context.Citytbl.Find(Id);
                _context.Citytbl.Remove(city);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }

        public List<City> GetAllCities()
        {
            try
            {
                return _context.Citytbl.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public City GetCityById(int Id)
        {
            try
            {
                return _context.Citytbl.Find(Id);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool UpdateCity(City city)
        {
            try
            {
                _context.Citytbl.Update(city);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

              return false ;
            }
        }
    }
}
