﻿global using Microsoft.EntityFrameworkCore;
using UniversidadApi.Models;

namespace UniversidadApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Genero> Generos { get; set; }
    }
}
