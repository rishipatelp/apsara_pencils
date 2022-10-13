using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apsara_pencils.Models;

namespace apsara_pencils.Data
{
    public class PencilContext: DbContext
    {
        public PencilContext (DbContextOptions<PencilContext> options) : base(options)
        {

        }
        public DbSet<PencilClass> PencilClass { get; set; }
    }
}
