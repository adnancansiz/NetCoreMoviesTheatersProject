using NetCoreMoviesTheatersProject.Model.Context;
using NetCoreMoviesTheatersProject.Model.Entities;
using NetCoreMoviesTheatersProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Services
{
    public class TheaerService : ITheaterRepository
    {
        private readonly MovieTheaterDb context;

        public TheaerService(MovieTheaterDb context)
        {
            this.context = context;
        }
        public void Create(Theater theater)
        {
            context.Theaters.Add(theater);
            context.SaveChanges();
        }

        public void Delete(Theater theater)
        {
            context.Theaters.Remove(theater);
            context.SaveChanges();
        }

        public Theater GetTheater(int id)
        {
            return context.Theaters.FirstOrDefault(x => x.Id == id);
        }

        public List<Theater> GetTheaters()
        {
            return context.Theaters.ToList();
        }

        public void Update(Theater theater)
        {
            context.Theaters.Update(theater);
            context.SaveChanges();
        }
    }
}
