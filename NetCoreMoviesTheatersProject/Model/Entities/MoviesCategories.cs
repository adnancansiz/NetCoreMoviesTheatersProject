using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Entities
{
    public class MoviesCategories
    {
        public int CategoryId { get; set; }
        public int MovieId { get; set; }

        public Category Category { get; set; }
        public Movie Movie { get; set; }

    }
}
