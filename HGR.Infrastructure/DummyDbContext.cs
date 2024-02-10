using HGR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGR.Infrastructure
{
    public class DummyDbContext(DbContextOptions<DummyDbContext> options) : DbContext(options)
    {
        public DbSet<Dummyentitiy> Dummy { get; set; }
    }
}
