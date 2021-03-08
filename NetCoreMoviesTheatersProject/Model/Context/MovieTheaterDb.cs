using Microsoft.EntityFrameworkCore;
using NetCoreMoviesTheatersProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Context
{
    public class MovieTheaterDb:DbContext
    {
        public MovieTheaterDb(DbContextOptions<MovieTheaterDb>options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<MoviesCategories> MoviesCategories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoviesCategories>().HasKey(x => new { x.MovieId, x.CategoryId });

            modelBuilder.Entity<Week>().Property(p => p.FirstDay).HasColumnType("datetime2");
            modelBuilder.Entity<Week>().Property(p => p.LastDay).HasColumnType("datetime2");

            modelBuilder.Entity<Session>().Property(p => p.Sessions).HasColumnType("datetime2");

            base.OnModelCreating(modelBuilder);
        }

    }
}
