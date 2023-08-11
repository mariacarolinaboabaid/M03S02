using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FichaCadastroAPI.Base;

namespace FichaCadastroAPI.Models
{
    [Table("Ficha")]
    public class FichaModel: RelationalBase
    {
        [Column(TypeName = "VARCHAR"), Required, StringLength(250)]
        public string Nome {get; set; }
        
        [Column(TypeName = "VARCHAR"), Required, StringLength(100)]
        public string Email {get; set; }

        [Required]
        public DateTime DataNascimento {get; set; }

        // Relacionamento com DetalheModel
        public virtual IList<DetalheModel>? Detalhes {get; set; }
    }
}