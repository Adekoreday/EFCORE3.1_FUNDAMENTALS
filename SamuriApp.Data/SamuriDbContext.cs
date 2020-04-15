﻿using System;
using SamuriApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace SamuriApp.Data
{
    public class SamuriDbContext: DbContext
    {
        public SamuriDbContext()
        {}
        String connectionString = @"
      Server=127.0.0.1;
      Database=NewDb;
      User Id=sa;
      Password=
   ";
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Samuri> Samuris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
