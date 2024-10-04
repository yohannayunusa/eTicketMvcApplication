using eTicketMvcApp.Data.Base;
using eTicketMvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketMvcApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
