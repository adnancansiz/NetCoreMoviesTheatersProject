using NetCoreMoviesTheatersProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Repositories
{
    public interface IWeekRepository
    {
        List<Week> GetWeeks();

        void Create(Week week);

        void Delete(Week week);
        void Update(Week week);

        Week GetWeek(int id);
    }
}
