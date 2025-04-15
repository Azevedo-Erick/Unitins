using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TopicosIII.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int id { get; set; }
        public string razaoSocial { get; set; }
        public string nomeFantasia { get; set; }
        public string inscricaoMunicipal { get; set; }
        public string inscricaoEstadual { get; set; }
        public string porteEmpresa { get; set; }
        public string ramoAtividade { get; set; }
        public bool optantePeloSimples { get; set; }
        public ContatoResponsavelEmpresa responsavel { get; set; }

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
