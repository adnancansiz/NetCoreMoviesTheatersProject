using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Model.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public List<MoviesCategories> MoviesCategories { get; set; }

    }
}
