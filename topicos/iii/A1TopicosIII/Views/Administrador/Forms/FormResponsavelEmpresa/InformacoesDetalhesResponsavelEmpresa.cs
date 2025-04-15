using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador.Forms.FormResponsavelEmpresa
{
    public partial class InformacoesDetalhesResponsavelEmpresa : Form
    {
        public DateTime dataNascimento = DateTime.Now;
        public string nome = "";
        public string funcao = "";
        public InformacoesDetalhesResponsavelEmpresa()
        {
            InitializeComponent();
             
        }

        public void carregaDados() {
            tbNome.Text = nome;
            tbFuncao.Text = funcao;
        }

        private void dTPNascimento_ValueChanged(object sender, EventArgs e)
        {
            dataNascimento = DateTime.Now;// formataDateTime(dTPNascimento.Text);
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            nome = tbNome.Text;
        }

        private void tbFuncao_TextChanged(object sender, EventArgs e)
        {
            funcao = tbFuncao.Text;
        }

        private DateTime formataDateTime(string dateStr) {
            var data = dateStr.Split('/');
            var dia = Convert.ToInt16(data[0]);
            var mes = Convert.ToInt16(data[1]);
            var ano = Convert.ToInt16(data[2]);
            return new DateTime(ano, mes, dia);
        }

    }
}
