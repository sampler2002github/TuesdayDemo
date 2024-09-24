using Microsoft.AspNetCore.Mvc; 
using TuesdayDemo.Data.Interface;
using TuesdayDemo.Data.Models;

namespace TuesdayDemo.Controllers
{
    public class StatesController : Controller
    {
        private readonly IState _state;
        public StatesController(IState state)
        {
                _state = state;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("GetAllStates")]
        public IActionResult GetAllStates()
        {
            return Ok(_state.GetAllStates());
        }
        [HttpGet]
        [Route("GetStateById")]
        public IActionResult GetStateById(int Id) 
        {
        return Ok(_state.GetStateById(Id));
        }

        [HttpPost]
        [Route("AddState")]
        public IActionResult AddState(State state)
        {
            return Ok(_state.AddState(state));
        }

        [HttpPut]
        [Route("UpdateState")]
        public IActionResult UpdateState(State state)
        {
            return Ok(_state.UpdateState(state));
        }
        [HttpDelete]
        [Route("DeleteState")]
        public IActionResult DeleteState(int Id)
        {
            return Ok(_state.DeleteState(Id));
        }
    }
}
