using Microsoft.EntityFrameworkCore;
using WebApi.Data.Models;

namespace WebApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Sonali singh",
                    Email = "sonalisingh7639@gmail.com",
                    Mobile = "8851490003",
                    Company = "Siemens",
                    Address = "Bangalore",
                    ShortDescription = "Hi",
                    LongDescription = "shutterstock_66842440.jpg"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Mountain Walkers",
                    Email = "sonalisingh7639@gmail.com1",
                    Mobile = "88514900031",
                    Company = "Siemens1",
                    Address = "Bangalore1",
                    ShortDescription = "Hi1",
                    LongDescription = "shutterstock_66842440.jpg1"
                }


            );
        }
    }
}
