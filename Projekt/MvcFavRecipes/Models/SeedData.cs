using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcFavRecipes.Data;
using System;
using System.Linq;

namespace MvcFavRecipes.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcFavRecipesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcFavRecipesContext>>()))
        {
            // Look for any recipes.
            if (context.Recipes.Any())
            {
                return;   // DB has been seeded
            }
            context.Recipes.AddRange(
                new Recipes
                {
                    Title = "Banana Oat Pancakes",
                    Ingredients = "1 banana, 2 eggs, 1/2 cup oats, pinch of cinnamon",
                    Instruction = "Blend all ingredients, cook on medium heat until golden on both sides."
                },
                new Recipes
                {
                    Title = "Spaghetti Aglio e Olio",
                    Ingredients = "Spaghetti, garlic, olive oil, chili flakes, parsley",
                    Instruction = "Sauté garlic in olive oil, add chili flakes, toss with cooked spaghetti and parsley."
                },
                new Recipes
                {
                    Title = "Avocado Toast with Egg",
                    Ingredients = "Bread, avocado, egg, lemon juice, salt, pepper",
                    Instruction = "Toast bread, mash avocado with lemon, top with fried or poached egg."
                },
                new Recipes
                {
                    Title = "Greek Yogurt Parfait",
                    Ingredients = "Greek yogurt, granola, mixed berries, honey",
                    Instruction = "Layer yogurt, granola, and berries in a glass, drizzle with honey."
                }
            );
            context.SaveChanges();
        }
    }
}