using NetCoreMoviesTheatersProject.Model.Context;
using NetCoreMoviesTheatersProject.Model.Entities;
using NetCoreMoviesTheatersProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Services
{
    public class CategoryService : ICategoryRepository
    {
        private readonly MovieTheaterDb context;

        public CategoryService(MovieTheaterDb context)
        {
            this.context = context;
        }
        public void Create(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}
