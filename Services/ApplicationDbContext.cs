using Events_WebApiApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace Events_WebApiApplication.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public required DbSet<Event> Events { get; set; }

        protected ApplicationDbContext()
        {
        }
    }
}
