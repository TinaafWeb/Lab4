﻿using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Community> Communities { get; set; }
       
        public DbSet<StudentMembership> StudentMemberships { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<CommunityMembership> CommunityMemberships { get; set; }
        public DbSet<AdsCommunity> AdvertisementCommunity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Community>().ToTable("Community");
            modelBuilder.Entity<CommunityMembership>().ToTable("CommunityMembership");
            modelBuilder.Entity<CommunityMembership>().ToTable("CommunityMembership");
            modelBuilder.Entity<StudentMembership>().ToTable("StudentMembership");
            modelBuilder.Entity<Advertisement>().ToTable("Advertisement");
            modelBuilder.Entity<AdsCommunity>().ToTable("AdvertisementCommunity");

            modelBuilder.Entity<CommunityMembership>()
                .HasKey(c => new { c.StudentId, c.CommunityId });

        }
        }
    }
