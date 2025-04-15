using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TopicosIII.Models
{
    [Table("Contratos")]
    public class Contrato
    {
        [Key]
        public int id { get; set; }
        public Empresa contatante { get; set; }
        public Usuario responsavel { get; set; }
        public Empresa contratado { get; set; }
        public int quantificadorVigencia { get; set; }
        public string tipoVigencia { get; set; }
    }
}
