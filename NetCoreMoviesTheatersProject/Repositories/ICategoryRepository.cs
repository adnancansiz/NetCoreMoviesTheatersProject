using NetCoreMoviesTheatersProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();

        void Create(Category category);

        void Delete(Category category);
        void Update(Category category);

        Category GetCategory(int id);
    }
}
