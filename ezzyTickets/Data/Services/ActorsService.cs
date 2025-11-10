using System.Threading.Tasks;
using ezzyTickets.Data.Base;
using ezzyTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace ezzyTickets.Data.Services
{
    public class ActorsService:EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) :base(context) { }
    }
}
