﻿using Microsoft.EntityFrameworkCore;

namespace studentFreelance.Models
{
    public class FreelancerDBcontext:DbContext
    {
        public FreelancerDBcontext(DbContextOptions<FreelancerDBcontext> options):base(options)
        {

        }

        public DbSet<freelancer> freelancer { get; set; }
        public DbSet<testModels> test { get; set; }
        public DbSet<Project> project { get; set; }
        
    }
}
