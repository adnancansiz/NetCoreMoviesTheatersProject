using NetCoreMoviesTheatersProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Repositories
{
    public interface ISaloonRepository
    {
        List<Saloon> GetSaloons();

        void Create(Saloon saloon);

        void Delete(Saloon saloon);
        void Update(Saloon saloon);

        Saloon GetSaloon(int id);
    }
}
