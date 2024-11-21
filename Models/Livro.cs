using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro
    {
        // atributos:
        // int CategoriaID
        [Key]
        public int LivroID { get; set; }
        // string Nome
        public string? Nome { get; set; }
        // string Escritor
        public string? Escritor { get; set; }
        // string Editora
        public string? Editora { get; set; }
        // string Descricao
         public string? Descricao { get; set; }
        // string Idioma
         public string? Idioma { get; set; }
        // string Imagem
         public string? Imagem{ get; set; }
  
        // bool Reservado
         public bool Reservado { get; set; }
        // bool Ativo
         public bool Ativo { get; set; }
    }
}