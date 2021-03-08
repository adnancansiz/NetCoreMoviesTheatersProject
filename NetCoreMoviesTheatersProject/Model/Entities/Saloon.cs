using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Entities
{
    public class Saloon:BaseEntity
    {
        public string SaloonName { get; set; }
        public short Capacity { get; set; }
        public List<Theater> Theaters { get; set; }

    }
}
