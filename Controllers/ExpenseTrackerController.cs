using AutoMapper;
using ExpenseTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public abstract class ExpenseTrackerController:ControllerBase
    {

        protected readonly ExpenseTrackerContext _context;

        protected readonly IMapper _mapper;

        public ExpenseTrackerController(ExpenseTrackerContext context, IMapper mapper)
        {

            _context = context;

            _mapper = mapper;

        }

    }
}
