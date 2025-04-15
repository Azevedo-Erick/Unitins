using A1TopicosIII.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TopicosIII.Data
{
    public class Context:DbContext
    {
        public Context() : base("conn") { }
        public DbSet<Contrato> contratos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<ContatoResponsavelEmpresa> responsaveis { get; set; }
       
        public DbSet<Log> logs { get; set; }
    }
}
