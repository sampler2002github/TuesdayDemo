using TuesdayDemo.Data.Interface;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Data.Repository
{
    public class StatesRepositry : IState
    {
        private readonly ApplicationDbContext _context;
        public StatesRepositry(ApplicationDbContext context)
        {
                _context = context;
        }
        public bool AddState(State state)
        {
            try
            {
                _context.Statetbl.Add(state);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteState(int Id)
        {
            try
            {
                var state = _context.Statetbl.Find(Id);
                _context.Statetbl.Remove(state);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<State> GetAllStates()
        {
            try
            {
                return _context.Statetbl.ToList();

            }
            catch (Exception)
            {

                return null;
            }
        } 
        public State GetStateById(int Id)
        {
            try
            {
                return _context.Statetbl.Find(Id);
            }
            catch (Exception)
            {

                return null;
            }
        } 
        public bool UpdateState(State state)
        {
            try
            {
                _context.Statetbl.Update(state);
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
