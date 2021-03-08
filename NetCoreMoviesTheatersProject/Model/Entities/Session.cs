using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Entities
{
    public class Session:BaseEntity
    {
        public DateTime Sessions { get; set; }

        public List<Theater> Theaters { get; set; }
    }

}
