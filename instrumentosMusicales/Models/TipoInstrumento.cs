using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace instrumentosMusicales.Models
{
    public class TipoInstrumento
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        public virtual List<Instrumento> Instrumentos { get; set; }
    }
}
