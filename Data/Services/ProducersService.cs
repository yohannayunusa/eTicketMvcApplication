using eTicketMvcApp.Data.Base;
using eTicketMvcApp.Models;

namespace eTicketMvcApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        { 
        }
    }
}
