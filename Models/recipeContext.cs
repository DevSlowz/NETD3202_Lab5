using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Make sure you use the Nu Get package manager to instal the Microsoft Entity Framework Core
using Microsoft.EntityFrameworkCore;
namespace NETD3202_Lab5.Models
{
    public class recipeContext : DbContext
    {
        // Constructor for the recipeContext class
        public recipeContext(DbContextOptions<recipeContext> options) : base(options)
        {
        }

        // Properties
        public DbSet<recipe> Recipes { get; set; }
    }
}
