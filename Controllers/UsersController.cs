using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class UsersController: ControllerBase
    {

        private readonly ExpenseTrackerContext _context;
        public UsersController(ExpenseTrackerContext context)
        {

            _context = context;

        }



        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_context.Users);

        }

        [HttpGet]
        [Route("{User_id:int}")]
        public IActionResult GetByUserId(int User_id)
        {

            return Ok(_context.Users.Find(User_id));

        }


        [HttpPost]
        public IActionResult Post(Users User) 
        {

            _context.Users.Add(User);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, User);
            
        }



        [HttpPut]
        [Route("{User_id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int User_id, Users User)
        {

            var UserDataBase = _context.Users.Find(User_id);

            UserDataBase.User_Id = User.User_Id;
            UserDataBase.Name = User.Name;
            UserDataBase.Password = User.Password;
            UserDataBase.Email = User.Email;
            UserDataBase.Created_At = User.Created_At;

            _context.Users.Update(UserDataBase);
            _context.SaveChanges();

            return Ok(new {message = "Succesfully changed!"});

        }


        [HttpDelete]
        [Route("{User_id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int User_id)
        {

            var UserDataBase = _context.Users.Find(User_id);

            _context.Users.Remove(UserDataBase);
            _context.SaveChanges();

            return Ok(new { message = "Succesfully changed!" });

        } 



    }
}
