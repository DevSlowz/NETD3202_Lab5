using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Add the following import (you do not need to use the nu-get package manager).
//We are obtaining the class IdentityUser from it (to inherit from it).
using Microsoft.AspNetCore.Identity;
namespace NETD3202_Lab5.Models
{
    public class user
    {
        // Fields
        public string Name { get; set; }
        public string ProfilePictureUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Relations
        public IEnumerable<recipe> Recipes { get; set; }

        // Methods
        public override string ToString()
        {
            return this.Name;
        }
    }
}
