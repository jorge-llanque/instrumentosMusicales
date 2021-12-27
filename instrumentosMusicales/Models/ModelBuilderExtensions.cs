using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instrumentosMusicales.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrumento>().HasData(
                new Instrumento { Id = 1, Name = "Piano", Marca = "Yamaha", Modelo = "PSR400", TipoInstrumentoId = 1},
                new Instrumento { Id = 2, Name = "Guitarra", Marca = "Yamaha", Modelo = "Phil", TipoInstrumentoId = 2},
                new Instrumento { Id = 3, Name = "Bateria", Marca = "Zild", Modelo = "OKA", TipoInstrumentoId = 4});
            modelBuilder.Entity<TipoInstrumento>().HasData(
                new TipoInstrumento { Id = 1, Title = "Cuerda", Category = "Acustico"},
                new TipoInstrumento { Id = 2, Title = "Cuerda", Category = "Acustico"},
                new TipoInstrumento { Id = 3, Title = "Viento", Category = "Acustico"},
                new TipoInstrumento { Id = 4, Title = "Percusion", Category = "Acustico"}
                );
        }
    }
}
