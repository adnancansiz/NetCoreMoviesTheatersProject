using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Entities
{
    public class Week:BaseEntity
    {
        public string Weeks { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }


        public List<Theater> Theaters { get; set; }

    }
}
