using ezzyTickets.Data.Base;
using ezzyTickets.Models;

namespace ezzyTickets.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context):base(context)
        {
            
        }
    }
}
