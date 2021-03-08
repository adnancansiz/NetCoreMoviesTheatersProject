using NetCoreMoviesTheatersProject.Model.Context;
using NetCoreMoviesTheatersProject.Model.Entities;
using NetCoreMoviesTheatersProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Services
{
    public class MovieService : IMovieRepository
    {
        private readonly MovieTheaterDb context;

        public MovieService(MovieTheaterDb context)
        {
            this.context = context;
        }

        public void Create(Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            context.Movies.Remove(movie);
            context.SaveChanges();
        }

        public Movie GetMovie(int id)
        {
            return context.Movies.FirstOrDefault(x => x.Id == id);
        }

        public List<Movie> GetMovies()
        {
            return context.Movies.ToList();
        }

        public void Update(Movie movie)
        {
            context.Movies.Update(movie);
            context.SaveChanges();
        }
    }
}
