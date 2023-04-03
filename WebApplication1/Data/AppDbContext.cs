using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_movies>().HasKey(am => new
            {
                am.IDActor,
                am.IdMovies
            });
            modelBuilder.Entity<Actor_movies>().HasOne(m => m.movies).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.IdMovies);
            modelBuilder.Entity<Actor_movies>().HasOne(m => m.actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.IDActor);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> actors { get; set; }
        public DbSet<Movies> movies { get; set; }
        public DbSet<Actor_movies> actors_movies { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Producer> producers { get; set; }
    }
}
