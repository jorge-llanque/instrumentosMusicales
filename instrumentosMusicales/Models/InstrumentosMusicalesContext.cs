using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instrumentosMusicales.Models
{
    public class InstrumentosMusicalesContext : DbContext
    {
        public InstrumentosMusicalesContext(DbContextOptions<InstrumentosMusicalesContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrumento>().HasOne(o => o.TipoInstrumento);
            modelBuilder.Entity<TipoInstrumento>().HasMany(c => c.Instrumentos).WithOne(a => a.TipoInstrumento).HasForeignKey(a => a.TipoInstrumentoId);

            modelBuilder.Seed();
        }

        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<TipoInstrumento> TipoInstrumentos { get; set; }
    }
}
