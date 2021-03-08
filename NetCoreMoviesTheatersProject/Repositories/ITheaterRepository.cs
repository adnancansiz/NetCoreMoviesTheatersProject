using NetCoreMoviesTheatersProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Repositories
{
    public interface ITheaterRepository
    {
        List<Theater> GetTheaters();

        void Create(Theater theater);

        void Delete(Theater theater);
        void Update(Theater theater);

        Theater GetTheater(int id);
    }
}
