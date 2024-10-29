using AutoMapper;
using ExpenseTracker.Data;
using ExpenseTracker.Models;
using ExpenseTracker.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController(ExpenseTrackerContext context, IMapper mapper): ExpenseTrackerController(context, mapper)
    {

        //private readonly ExpenseTrackerContext _context;
        //public UsersController(ExpenseTrackerContext context)
        //{

        //    _context = context;

        //}



        [HttpGet]
        public ActionResult<UsersDTORead> Get()
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(new { message = ModelState });

            }

            try
            {

                return Ok(_mapper.Map<List<UsersDTORead>>(_context.Users));

            }
            catch (Exception ex)
            {

                return BadRequest(new {message = ex.Message});

            }

        }

        [HttpGet]
        [Route("{User_id:int}")]
        public ActionResult<UsersDTORead> GetByUserId(int User_id)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(new { message = ModelState });

            }

            Users? e;
            try
            {

                e = _context.Users.Find(User_id);

            }
            catch (Exception ex)
            {

                return BadRequest(new { message = ex.Message });

            }

            if (e == null)
            {

                return NotFound(new { message = "User does not exist in database" });

            }

            return Ok(_mapper.Map<UsersDTORead>(e));

        }


        [HttpPost]
        public IActionResult Post(UsersDTOInsertUpdate dto) 
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(new { message = ModelState });

            }

            try
            {

                var e = _mapper.Map<Users>(dto);
                _context.Users.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<UsersDTORead>(e));

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });

            }

        }



        [HttpPut]
        [Route("{User_id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int User_id, UsersDTOInsertUpdate dto)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(new { poruka = ModelState });

            }

            try
            {

                Users? e;
                try
                {

                    e = _context.Users.Find(User_id);

                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });

                }

                if (e == null)
                {

                    return NotFound(new { poruka = "Smjer ne postoji u bazi" });

                }

                e = _mapper.Map(dto, e);

                _context.Users.Update(e);
                _context.SaveChanges();

                return Ok(new { poruka = "Uspješno promjenjeno" });

            }

            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });

            }

        }


        [HttpDelete]
        [Route("{User_id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int User_id)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(new { poruka = ModelState });

            }

            try
            {

                Users? e;
                try
                {

                    e = _context.Users.Find(User_id);

                }
                catch (Exception ex)
                {

                    return BadRequest(new { poruka = ex.Message });

                }

                if (e == null)
                {

                    return NotFound("Smjer ne postoji u bazi");

                }

                _context.Users.Remove(e);
                _context.SaveChanges();
                return Ok(new { poruka = "Uspješno obrisano" });

            }
            catch (Exception ex)
            {

                return BadRequest(new { poruka = ex.Message });

            }

        } 



    }
}
