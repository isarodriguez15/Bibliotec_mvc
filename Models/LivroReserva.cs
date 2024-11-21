using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroReserva
    {
        public int LivroReservaId { get; set; }
        [ForeignKey("Livro")]  

        public int UsuarioId { get; set; }
        [ForeignKey("Usuario")]  

        public int LivroID { get; set; }

        public DateOnly DtReversa { get; set; }

        public DateOnly DtRevolucao { get; set; }

        public int Status  { get; set; }
    }
}