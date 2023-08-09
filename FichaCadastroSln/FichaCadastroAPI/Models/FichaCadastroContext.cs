using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FichaCadastroAPI.Models
{
    public class FichaCadastroContext : DbContext
    {
        // Construtor
        public FichaCadastroContext (DbContextOptions options) : base (options) 
        {

        }

        // Criação dos modelos 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}