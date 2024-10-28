using ExpenseTracker.Data;
using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Models;
using AutoMapper;
using ExpenseTracker.Models.DTO;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class BudgetsController(ExpenseTrackerContext context, IMapper mapper) : ExpenseTrackerController(context, mapper)
    {

        //private readonly ExpenseTrackerContext _context;
        //public BudgetsController(ExpenseTrackerContext context)
        //{
        //    _context = context;
        //}


        [HttpGet]
        public ActionResult<List<BudgetsDTORead>> Get()
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(new { message = ModelState });

            }
            try
            {

                return Ok(_mapper.Map<List<BudgetsDTORead>>(_context.Budgets));

            }
            catch( Exception ex)
            {

                return BadRequest(new { message = ex.Message });

            }

        }

        [HttpGet]
        [Route("{Budget_id:int}")]
        public ActionResult<BudgetsDTORead> GetBySifra(int budget_id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = ModelState });
            }
            Budgets? e;
            try
            {
                e = _context.Budgets.Find(budget_id);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { messave = "Budget does not exist in database" });
            }

            return Ok(_mapper.Map<BudgetsDTORead>(e));
        }

        [HttpPost]
        public IActionResult Post(BudgetsDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = ModelState });
            }
            try
            {
                var e = _mapper.Map<Budgets>(dto);
                _context.Budgets.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<BudgetsDTORead>(e));
            }
            catch (Exception ex)
            {
                return BadRequest(new { budgets = ex.Message });
            }

        }

        [HttpPut]
        [Route("{Budgets_id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, BudgetsDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = ModelState });
            }
            try
            {
                Budgets? e;
                try
                {
                    e = _context.Budgets.Find(sifra);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
                if (e == null)
                {
                    return NotFound(new { message = "Budget does not exist in database" });
                }

                e = _mapper.Map(dto, e);

                _context.Budgets.Update(e);
                _context.SaveChanges();

                return Ok(new { poruka = "Succesfully changed" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        [HttpDelete]
        [Route("{Budgets_id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int budget_id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = ModelState });
            }
            try
            {
                Budgets? e;
                try
                {
                    e = _context.Budgets.Find(budget_id);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
                if (e == null)
                {
                    return NotFound("Budget does not exist in database");
                }
                _context.Budgets.Remove(e);
                _context.SaveChanges();
                return Ok(new { message = "Succesfully deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }



    }
}
