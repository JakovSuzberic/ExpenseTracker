using ExpenseTracker.Data;
using ExpenseTracker.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ExpenseTracker.Controllers
{
    

    [ApiController]
    [Route("api/vi/[controller]")]
    public class AutentificationController(ExpenseTrackerContext context) : ControllerBase
    {

        private readonly ExpenseTrackerContext _context = context;

        [HttpPost("token")]
        public IActionResult GenerateToken(OperaterDTO operater)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var operBaza = _context.Operateri
                   .Where(p => p.Email!.Equals(operater.email))
                   .FirstOrDefault();

            if (operBaza == null)
            {
                return StatusCode(StatusCodes.Status403Forbidden, "You are not authorized, can not find operater");
            }

            if (!BCrypt.Net.BCrypt.Verify(operater.password, operBaza.Password))
            {
                return StatusCode(StatusCodes.Status403Forbidden, "You are not authorized, password does not match");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("MojKljucKojijeJakoTajan i dovoljno dugacak da se moze koristiti");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.Add(TimeSpan.FromHours(8)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwt = tokenHandler.WriteToken(token);

            return Ok(jwt);
        }





    }




}
