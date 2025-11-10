using ezzyTickets.Data.Base;
using ezzyTickets.Models;

namespace ezzyTickets.Data.Services
{
    public class CinemasService: EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { } 
    }
}
