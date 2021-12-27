using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instrumentosMusicales.Models
{
    public class Instrumento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int TipoInstrumentoId { get; set; }
        public virtual TipoInstrumento TipoInstrumento { get; set; }

    }
}
