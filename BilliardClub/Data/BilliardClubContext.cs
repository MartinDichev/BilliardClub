using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BilliardClub.Models;

namespace BilliardClub.Data
{
    public class BilliardClubContext : DbContext
    {
        public BilliardClubContext (DbContextOptions<BilliardClubContext> options)
            : base(options)
        {
        }

        public DbSet<BilliardClub.Models.Reservation> Reservation { get; set; } = default!;

        public DbSet<BilliardClub.Models.Table> Table { get; set; } = default!;

        public DbSet<BilliardClub.Models.User> User { get; set; } = default!;
    }
}
