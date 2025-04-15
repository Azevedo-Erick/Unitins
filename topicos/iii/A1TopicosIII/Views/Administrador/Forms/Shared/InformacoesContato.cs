using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador.Forms.Shared
{
    public partial class InformacoesContato : Form
    {
        public string email= "";
        public string ddd = "";
        public string fax = "";
        public string numero = "";
        public InformacoesContato()
        {
            InitializeComponent();
            
        }

        public void carregaDados() {
            tbEmail.Text = email;
            tbDdd.Text = ddd;
            tbTelefone.Text = numero;
            tbFax.Text = fax;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            email = tbEmail.Text;
        }

        private void tbDdd_TextChanged(object sender, EventArgs e)
        {
            ddd = tbDdd.Text;
        }

        private void tbTelefone_TextChanged(object sender, EventArgs e)
        {
            numero = tbTelefone.Text;
        }

        private void tbFax_TextChanged(object sender, EventArgs e)
        {
            fax = tbFax.Text;
        }
    }
}
