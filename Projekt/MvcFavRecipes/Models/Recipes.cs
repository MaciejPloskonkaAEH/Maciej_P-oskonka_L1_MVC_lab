using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFavRecipes.Models;

public class Recipes
{
    public int Id { get; set; }

    [StringLength(40, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }

    [StringLength(100, MinimumLength = 3)]
    public string? Ingredients { get; set; }

    [StringLength(200, MinimumLength = 3)]
    public string? Instruction { get; set; }
}