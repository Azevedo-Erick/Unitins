using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador.Forms.FormUsuario
{
    public partial class InformacoesAcesso : Form
    {
        public string email;
        public string senha;
        public InformacoesAcesso()
        {
            InitializeComponent();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            email = tbEmail.Text;
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            senha = tbSenha.Text;
        }

        private void InformacoesAcesso_Load(object sender, EventArgs e)
        {

        }

        public void carregaDados()
        {
            tbEmail.Text = email;
            tbSenha.Text = senha;
        }
    }
}
