using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplication1
{
    public partial class Usuario
    {
        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Computed)]

        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? Escolaridade { get; set; }
    }
}
