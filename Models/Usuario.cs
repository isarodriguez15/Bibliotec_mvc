using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
         // atributos:
         // int CategoriaID
         [Key]
         public int UsuarioID { get; set; }
         // string Nome
         public string? Nome { get; set; }
         // DateOnly DtNascimento
        public DateOnly DtNascimento { get; set; }
         // string Email
        public string? Email { get; set; }
         // string Senha
         public string? Senha { get; set; }
         // string Contato
         public string? Contato { get; set; }
         // bool Admin
         public bool Admin { get; set; }
         // bool Status
         public bool Status { get; set; }

         // Criar um atributo
        // Eu falo para este atributo que ele e uma FK
        [ForeignKey("Curso")]
         public int? CursoId { get; set; }

         public Curso? Curso { get; set; }
    }
}