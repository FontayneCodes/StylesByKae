using Microsoft.EntityFrameworkCore;
using DemoHairSite.Models;

namespace DemoHairSite.Data
    {
    public class ApplicationDbContext : DbContext
        {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }

        public DbSet<ContactModel> Contacts
            {
            get; set;
            }
        public DbSet<ServicesModel> Services
            {
            get; set;
            }
        public DbSet<BookingModel> Bookings
            {
            get; set;
            }
        }
    }

