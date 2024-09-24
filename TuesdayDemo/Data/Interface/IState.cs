using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Data.Interface
{
    public interface IState
    {
        bool AddState(State state);
        bool UpdateState(State state);
        bool DeleteState(int Id); 
        List<State> GetAllStates();
        State GetStateById(int Id);
    }
}
