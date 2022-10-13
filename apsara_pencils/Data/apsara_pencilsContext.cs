using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apsara_pencils.Models;

namespace apsara_pencils.Data
{
    public class apsara_pencilsContext : DbContext
    {
        public apsara_pencilsContext (DbContextOptions<apsara_pencilsContext> options)
            : base(options)
        {
        }

        public DbSet<apsara_pencils.Models.PencilClass> PencilClass { get; set; }
    }
}
