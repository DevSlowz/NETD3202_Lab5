using System.Collections.Generic;

namespace NETD3202_Lab5.Models
{
    public class RecipeSearch
    {
        // Fields
        public string Query { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public IEnumerable<string> CuisineTypes { get; set; }

        // Methods
        //public IEnumerable<recipe> Search()
        //{
        //    // Query the database using the provided search criteria and return the matching recipes
        //}
    }
}
