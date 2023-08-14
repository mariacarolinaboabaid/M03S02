using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FichaCadastroAPI.Enum;

namespace FichaCadastroAPI.DTO.Ficha
{
    public class FichaReadDTO
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public IList<FichaDetalheReadDTO>? FichaComDetalhes  { get; set; }
    }

    public class FichaDetalheReadDTO : DTOBase 
    {
        public EnumNota Nota { get; set; }
        public string Justificativa { get; set; }
    }
}
