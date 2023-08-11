using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FichaCadastroAPI.Base;
using FichaCadastroAPI.Enum;

namespace FichaCadastroAPI.Models
{
    [Table("Detalhe")]
    public class DetalheModel : RelationalBase
    {
        [Column(TypeName = "VARCHAR"), Required, StringLength(500)]
        public string Feedback {get; set; }
        
        [Required]
        public EnumNota Nota {get; set; }

        [Required]
        public bool Ativado {get; set; }

        // Relacionamento com FichaModel
        [Required]
        public virtual FichaModel Ficha { get; set; }
        
    }
}