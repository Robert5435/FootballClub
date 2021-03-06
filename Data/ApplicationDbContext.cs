using Football.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<StaffMember> StaffMembers { get; set; }
        public DbSet<PagePlayers> PagePlayers { get; set; }
    }
}
