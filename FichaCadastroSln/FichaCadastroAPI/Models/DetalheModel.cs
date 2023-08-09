using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FichaCadastroAPI.Models
{
    [Table("Detalhe")]
    public class DetalheModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set; }

        [Column(TypeName = "VARCHAR"), Required, StringLength(500)]
        public string Feedback {get; set; }
        
        [Required]
        public int Nota {get; set; }

        [Required]
        public bool Ativado {get; set; }

        [Required]
        public DateTime DataCadastro {get; set; }

        // Relacionamento com FichaModel
        [Required]
        public virtual FichaModel Ficha { get; set; }
        
    }
}