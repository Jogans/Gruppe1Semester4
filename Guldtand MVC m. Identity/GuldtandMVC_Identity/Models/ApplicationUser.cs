using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GuldtandMVC_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        
        public string Name { get; set; }


    }
}