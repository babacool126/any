using MyCVKetel_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyCVKetel_Project.Data
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
    }
}
