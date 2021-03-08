using NetCoreMoviesTheatersProject.Model.Context;
using NetCoreMoviesTheatersProject.Model.Entities;
using NetCoreMoviesTheatersProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Services
{
    public class WeekService : IWeekRepository
    {
        private readonly MovieTheaterDb context;

        public WeekService(MovieTheaterDb context)
        {
            this.context = context;
        }
        public void Create(Week week)
        {
            context.Weeks.Add(week);
            context.SaveChanges();
        }

        public void Delete(Week week)
        {
            context.Weeks.Remove(week);
            context.SaveChanges();
        }

        public Week GetWeek(int id)
        {
            return context.Weeks.FirstOrDefault(x => x.Id == id);
           
        }

        public List<Week> GetWeeks()
        {
            return context.Weeks.ToList();
        }

        public void Update(Week week)
        {
            context.Weeks.Update(week);
            context.SaveChanges();
        }
    }
}
