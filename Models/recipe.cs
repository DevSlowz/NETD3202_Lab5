using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Add the following import (you do not need to use the nu-get package manager).
//We are obtaining the class IdentityUser from it (to inherit from it).


namespace NETD3202_Lab5.Models
{
    public class recipe
    {
        // Fields
        public int recipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }

        //// Relations
        //public user User { get; set; }

        //// Methods
        //public override string ToString()
        //{
        //    return this.Name;
        //}
    }
}
