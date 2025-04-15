using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TopicosIII.Models
{

    [Table("Logs")]
    public class Log
    {
        [Key]
        public int id { get; set; }
        public DateTime logDateTime { get; set; }
        public string texto { get; set; }
        public string usuario { get; set; }
        public Log(string texto, string usuario)
        {
            this.texto = texto;
            this.usuario = usuario;
        }
    }
}
