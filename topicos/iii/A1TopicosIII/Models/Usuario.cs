using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TopicosIII.Models
{

    public enum Cargo
    {
        USUARIO,ADMINISTRADOR,GESTOR
    }
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public string nomeCompleto { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public Cargo cargo { get; set; } // usuario, gestor, administrador
        public bool ativo { get; set; }
        public DateTime dataNascimento { get; set; }
        public string rg;
        public string cpf;
    }
}
