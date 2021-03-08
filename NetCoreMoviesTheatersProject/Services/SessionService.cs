using NetCoreMoviesTheatersProject.Model.Context;
using NetCoreMoviesTheatersProject.Model.Entities;
using NetCoreMoviesTheatersProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Services
{
    public class SessionService : ISessionRepository
    {
        private readonly MovieTheaterDb context;

        public SessionService(MovieTheaterDb context)
        {
            this.context = context;
        }
        public void Create(Session session)
        {
            context.Sessions.Add(session);
            context.SaveChanges();
        }

        public void Delete(Session session)
        {
            context.Sessions.Remove(session);
            context.SaveChanges();
        }

        public Session GetSession(int id)
        {
            return context.Sessions.FirstOrDefault(x => x.Id == id);

        }

        public List<Session> GetSessions()
        {
            return context.Sessions.ToList();
        }

        public void Update(Session session)
        {
            context.Sessions.Update(session);
            context.SaveChanges();
        }
    }
}
