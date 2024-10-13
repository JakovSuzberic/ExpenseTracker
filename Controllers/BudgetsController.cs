//using ExpenseTracker.Data;
//using Microsoft.AspNetCore.Mvc;
//using ExpenseTracker.Models;

//namespace ExpenseTracker.Controllers
//{
//    [ApiController]
//    [Route("api/v1/[controller]")]

//    public class BudgetsController: ControllerBase
//    {

//        private readonly ExpenseTrackerContext _context;
//        public BudgetsController(ExpenseTrackerContext context)
//        {

//            _context = context;

//        }

//        [HttpGet]
//        public IActionResult Get()
//        {

//            return Ok(_context.Budgets);

//        }




//    }
//}
