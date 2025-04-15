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
    public partial class InformacoesPessoais : Form
    {
        public string nome = "";
        public string cpf = "";
        public string rg = "";
        public InformacoesPessoais()
        {
            InitializeComponent();
           
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            nome = tbNome.Text;
            Console.WriteLine(nome);
        }

        private void tbCPF_TextChanged(object sender, EventArgs e)
        {
            cpf = tbCPF.Text;
        }

        private void tbRg_TextChanged(object sender, EventArgs e)
        {
            rg = tbRg.Text;
        }
        public void carregaDados()
        {
            tbNome.Text = nome;
            tbCPF.Text = cpf;
            tbRg.Text = rg;
        }
    }
}
