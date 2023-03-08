using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edzoterem_adatbazis
{
    public class Edzoterem_adatbazisDBContext : DbContext
    {
        public DbSet<Tagok> Tagok { get; set; }
        public DbSet<Tagsag> Tagsagok { get; set; }
        public DbSet<Maganedzo> Maganedzok { get; set; }
        public DbSet<Recepcios> Recepciosok { get; set; }
        public DbSet<Takarito> Takaritok { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EdzoteremDBV3;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
