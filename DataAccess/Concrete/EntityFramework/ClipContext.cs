﻿using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ClipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Clip;Trusted_Connection=true");
        }

        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SaloonImage> SaloonImages { get; set; }
        public DbSet<SocialMediaLink> SocialMediaLinks { get; set; }
        public DbSet<SaloonStarCount> SaloonStarCounts { get; set; }
        public DbSet<SaloonComment> SaloonComments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeStarCount> EmployeeStarCounts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Folower> Folowers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Saved> Saveds { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
    }
}
