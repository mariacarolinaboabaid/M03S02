using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaCadastroAPI.DTO.Ficha
{
    public class FichaUpdateDTO
    {
         public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}