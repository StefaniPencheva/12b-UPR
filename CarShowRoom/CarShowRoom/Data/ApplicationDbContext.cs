using CarShowRoom.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CarShowRoom.Models;

namespace CarShowRoom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarShowRoom.Models.CarCreateViewModel> CarCreateViewModel { get; set; }
        public DbSet<CarShowRoom.Models.CarAllViewModel> CarAllViewModel { get; set; }
        public DbSet<CarShowRoom.Models.CarReadViewModel> CarReadViewModel { get; set; }
        public DbSet<CarShowRoom.Models.CarUpdateViewModel> CarUpdateViewModel { get; set; }
    }
}
