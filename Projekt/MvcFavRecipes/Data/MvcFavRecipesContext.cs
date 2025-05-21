using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFavRecipes.Models;

namespace MvcFavRecipes.Data
{
    public class MvcFavRecipesContext : DbContext
    {
        public MvcFavRecipesContext (DbContextOptions<MvcFavRecipesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcFavRecipes.Models.Recipes> Recipes { get; set; } = default!;
    }
}
