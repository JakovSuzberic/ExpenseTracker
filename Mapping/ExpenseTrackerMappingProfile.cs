using AutoMapper;
using ExpenseTracker.Models;
using ExpenseTracker.Models.DTO;

namespace ExpenseTracker.Mapping
{
    public class ExpenseTrackerMappingProfile: Profile
    {

        public ExpenseTrackerMappingProfile()
        {

            CreateMap<Users, UsersDTORead>();
            CreateMap<UsersDTOInsertUpdate, Users>();

        }       

    }
}
