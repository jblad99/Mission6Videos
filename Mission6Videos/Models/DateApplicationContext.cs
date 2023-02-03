using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Videos.Models
{
    public class DateApplicationContext : DbContext
    {
        //Constructor
        public DateApplicationContext (DbContextOptions<DateApplicationContext> options) : base (options)
        {
            //Leave blank for now
        }

        //Set up set of data called responses, a set of responses from the database
        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                    new ApplicationResponse
                    {
                        ApplicationId = 1,
                        FirstName = "Michael",
                        LastName = "Scott",
                        Age = 45,
                        Phone = "555-123-4567",
                        Major = "Sales",
                        CreeperStalker = false
                    },
                    new ApplicationResponse
                    {
                        ApplicationId = 1,
                        FirstName = "Creed",
                        LastName = "Bratton",
                        Age = 90,
                        Phone = "555-123-7890",
                        Major = "Undeclared",
                        CreeperStalker = true
                    }
                ); 
        }
    }
}
