using ScheduleMVC.Entities;
using System.Data.Entity;
namespace ScheduleMVC.Context
{
    public class MVCContext : DbContext
    {
        public MVCContext() : base("MVCContext")
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSchedule> EventSchedules { get; set; }
    }
}