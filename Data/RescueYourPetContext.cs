using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RescueYourPet.Models
{
    public class RescueYourPetContext : DbContext
    {
        public RescueYourPetContext (DbContextOptions<RescueYourPetContext> options)
            : base(options)
        {
        }

        public DbSet<RescueYourPet.Models.Email> Email { get; set; }
    }
}
