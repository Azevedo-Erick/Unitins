using A1TopicosIII.Data;
using A1TopicosIII.Migrations;
using A1TopicosIII.Models;
using A1TopicosIII.Utils;
using A1TopicosIII.Views;
using A1TopicosIII.Views.Gerente;
using A1TopicosIII.Views.UsuarioComum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII
{
    public partial class Login : Form
    {
        public static Usuario usuarioLogado = null;
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabelCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void linkLabelCriarConta_LinkPaint(object sender, PaintEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
               
            string email = tbEmail.Text;
            string senha = tbSenha.Text;

            try {
                Context ctx = new Context();
                Usuario usuario = ctx.usuarios.Where(u => u.email == email).FirstOrDefault();
                if (usuario == null) {
                    MessageBox.Show("Usuário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (usuario.senha.Equals(senha)) {
                    if (usuario.ativo == false) {
                         MessageBox.Show("Login inativo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Logger.logWrapper("Login realizado",usuario.nomeCompleto);
                    usuarioLogado = usuario;
                    if (usuario.cargo == Cargo.ADMINISTRADOR)
                    {
                        IndexAdministrador index = new IndexAdministrador();
                        index.Show();

                    }
                    else if (usuario.cargo == Cargo.GESTOR) {
                        IndexGerente index = new IndexGerente();
                        index.Show();
                    }
                    else {
                        IndexUsuarioComum index = new IndexUsuarioComum();
                        index.Show();
                    }
                    this.Hide();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
            
        }

        private void panelEmail_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelEmail_Click(object sender, EventArgs e)
        {
            tbEmail.Select();
        }

        private void panelSenha_Click(object sender, EventArgs e)
        {
            tbSenha.Select();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }
    }
}
