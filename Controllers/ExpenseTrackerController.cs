using AutoMapper;
using ExpenseTracker.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [Authorize]
    public abstract class ExpenseTrackerController(ExpenseTrackerContext context, IMapper mapper):ControllerBase
    {

        protected readonly ExpenseTrackerContext _context;

        protected readonly IMapper _mapper;

       
    }
}
