using A1TopicosIII.Data;
using A1TopicosIII.Models;
using A1TopicosIII.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string confirmarSenha = tbConfirmarSenha.Text;
            string senha = tbSenha.Text;
            string email = tbEmail.Text;

            bool termosAceitos = checkBoxTermos.Checked;
            string nome = tbNome.Text;

            if (confirmarSenha.Equals("") || senha.Equals("") || email.Equals("") || !confirmarSenha.Equals(senha)) {
                 MessageBox.Show("Os dados nao batem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                Context ctx = new Context();
                 Usuario em =  ctx.usuarios.Where(b => b.email == email).FirstOrDefault();
                Console.WriteLine(em);
                if(em!= null)
                {
                     MessageBox.Show("O usuario ja esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Usuario usuario = new Usuario();
                usuario.email = email;
                usuario.senha = senha;
                usuario.rg = "";
                usuario.dataNascimento = DateTime.Now;
                usuario.cpf = "";
                usuario.nomeCompleto = nome;
                usuario.ativo = true;
                usuario.cargo = Cargo.USUARIO;
                ctx.usuarios.Add(usuario);
                ctx.SaveChanges();
                Logger.logWrapper("Cadastro realizado",usuario.nomeCompleto);
                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limparCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ocorreu um erro ao realizar o cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxTermos_CheckedChanged(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = checkBoxTermos.Checked;
        }

        private void limparCampos()
        {
            tbNome.Text = "";
            tbEmail.Text = "";
            tbSenha.Text = "";
            tbConfirmarSenha.Text = "";
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("O Naruto pode ser um pouco duro às vezes\r\nTalvez você não saiba disso\r\nMas o Naruto também\r\nCresceu sem pai\r\n\r\nNa verdade, ele nunca conheceu nenhum de seus pais\r\nE nunca teve nenhum amigo em nossa aldeia\r\nMesmo assim, eu nunca vi ele chorar\r\nFicar zangado ou se dar por vencido\r\n\r\nEle está sempre disposto a melhorar\r\nEle quer ser respeitado, é o sonho dele\r\nE o Naruto daria a vida por isso sem hesitar\r\nMeu palpite é que ele se cansou de chorar\r\nE decidiu fazer alguma coisa a respeito");
        }
    }
}
