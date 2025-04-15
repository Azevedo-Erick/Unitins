using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TopicosIII.Models
{
    [Table("ResponsaveisEmpresa")]
    public class ContatoResponsavelEmpresa
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string funcao { get; set; }
        public DateTime dataNascimento { get; set; }
      
       
        public string fax { get; set; }
        public string email { get; set; }

        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }

        public string ddd { get; set; }
        public string numero_telefone { get; set; }
    }
}
