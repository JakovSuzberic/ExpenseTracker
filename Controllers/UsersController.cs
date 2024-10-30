using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{

    /// <summary>
    /// Controller for managing courses in the application.
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController: ControllerBase
    {

        private readonly ExpenseTrackerContext _context;

        /// <summary>Initializes a new instance of the <see cref="UsersController" /> class.</summary>
        /// <param name="context">The context.</param>
        public UsersController(ExpenseTrackerContext context)
        {

            _context = context;

        }



        /// <summary>Retrieves all users</summary>
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_context.Users);

        }

        /// <summary>Retrievers user by id</summary>
        /// <param name="User_id">The user identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpGet]
        [Route("{User_id:int}")]
        public IActionResult GetByUserId(int User_id)
        {

            return Ok(_context.Users.Find(User_id));

        }


        /// <summary>Adds new user</summary>
        /// <param name="User">The user.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpPost]
        public IActionResult Post(Users User) 
        {

            _context.Users.Add(User);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, User);
            
        }



        /// <summary>Updates new user</summary>
        /// <param name="User_id">The user identifier.</param>
        /// <param name="User">The user.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpPut]
        [Route("{User_id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int User_id, Users User)
        {

            var UserDataBase = _context.Users.Find(User_id);
            // UserDataBase.User_Id = User.User_Id;
            UserDataBase.Name = User.Name;
            UserDataBase.Password = User.Password;
            UserDataBase.Email = User.Email;
            UserDataBase.Created_At = User.Created_At;

            _context.Users.Update(UserDataBase);
            _context.SaveChanges();

            return Ok(new {message = "Succesfully changed!"});

        }


        /// <summary>Deletes user by id</summary>
        /// <param name="User_id">The user identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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
