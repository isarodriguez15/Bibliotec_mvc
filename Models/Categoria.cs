using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Categoria
    {
        // atributos:
        [Key]
        public int CategoriaID { get; set;}
        // int CategoriaID
        // string Nome
        public string? Nome { get; set;}
}
}