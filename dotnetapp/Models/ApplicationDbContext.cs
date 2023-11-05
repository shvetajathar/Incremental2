﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public virtual DbSet<Player> Players{get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for your custom application entities here, if needed.
        // For example, if you have a Player entity, you can add it ...
        
    }
}
