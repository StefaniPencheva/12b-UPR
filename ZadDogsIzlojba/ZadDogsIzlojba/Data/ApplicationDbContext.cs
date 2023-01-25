using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZadDogsIzlojba.Domain;
using ZadDogsIzlojba.Models;

namespace ZadDogsIzlojba.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<ZadDogsIzlojba.Models.DogEditViewModel> DogEditViewModel { get; set; }
        public DbSet<ZadDogsIzlojba.Models.DogDeleteViewModel> DogDeleteViewModel { get; set; }
        public DbSet<ZadDogsIzlojba.Models.DogDetailsViewModel> DogDetailsViewModel { get; set; }
        
    }
}
