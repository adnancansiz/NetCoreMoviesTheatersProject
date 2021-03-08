using NetCoreMoviesTheatersProject.Model.Context;
using NetCoreMoviesTheatersProject.Model.Entities;
using NetCoreMoviesTheatersProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Services
{
    public class SaloonService : ISaloonRepository
    {
        private readonly MovieTheaterDb context;

        public SaloonService(MovieTheaterDb context)
        {
            this.context = context;
        }
        public void Create(Saloon saloon)
        {
            context.Saloons.Add(saloon);
            context.SaveChanges();
        }

        public void Delete(Saloon saloon)
        {
            context.Saloons.Remove(saloon);
            context.SaveChanges();
        }

        public Saloon GetSaloon(int id)
        {
            return context.Saloons.FirstOrDefault(x => x.Id == id);

        }

        public List<Saloon> GetSaloons()
        {
            return context.Saloons.ToList();
        }

        public void Update(Saloon saloon)
        {
            context.Saloons.Update(saloon);
            context.SaveChanges();
        }
    }
}
