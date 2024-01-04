using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase3End.model;

namespace Phase3End.Data
{
    public class Phase3DbContext : DbContext
    {
        public Phase3DbContext (DbContextOptions<Phase3DbContext> options)
            : base(options)
        {
        }

        public DbSet<Phase3End.model.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<Phase3End.model.EmpProfile>? EmpProfile { get; set; }
    }
}
