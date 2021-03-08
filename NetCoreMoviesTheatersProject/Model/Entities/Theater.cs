using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Entities
{
    public class Theater:BaseEntity
    {
        public int MovieId { get; set; }
        public int SaloonId { get; set; }
        public int WeekId { get; set; }
        public int SessionId { get; set; }


        public Movie Movie { get; set; }
        public Saloon Saloon { get; set; }
        public Week Week { get; set; }
        public Session Session { get; set; }


    }
}
