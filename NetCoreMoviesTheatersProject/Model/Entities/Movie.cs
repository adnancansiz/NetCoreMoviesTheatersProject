using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Entities
{
    public class Movie:BaseEntity
    {
        public string MovieName { get; set; }
        public string Description { get; set; }
        public List<Theater> Theaters { get; set; }
        public List<MoviesCategories> MoviesCategories { get; set; }
    }
}
