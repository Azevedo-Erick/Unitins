using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A1TopicosIII.Data;
using A1TopicosIII.Models;
using A1TopicosIII.Utils;
using A1TopicosIII.Views.Administrador.Forms.FormUsuario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace A1TopicosIII.Views.Administrador.Forms
{
    public partial class UsuarioForm : Form
    {
        private InformacoesPessoais pessoal = new InformacoesPessoais();
        private InformacoesAcesso acesso = new InformacoesAcesso();
        public static Usuario usuario = new Usuario();
        public UsuarioForm()
        {
            InitializeComponent();
                carregaDadosAcesso();
                carregaDadosPessoal();
                carregaDados();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void atualizaDados()
        {
            usuario.nomeCompleto = pessoal.nome;
            usuario.cpf = pessoal.cpf;
            usuario.rg = pessoal.rg;
            usuario.email = acesso.email;
            usuario.senha = acesso.senha;
        }

        private void atualizaUsuario(Usuario antigo, Usuario novo){
            antigo.nomeCompleto = novo.nomeCompleto;
            antigo.cpf = novo.cpf;
            antigo.rg = novo.rg;
            antigo.email = novo.email;
            antigo.senha = novo.senha;
        }

private void carregaDadosPessoal(){
            pessoal.carregaDados();
            pessoal.nome = usuario.nomeCompleto;
            pessoal.cpf = usuario.cpf;
            pessoal.rg = usuario.rg;
        }
  
        private void carregaDadosAcesso(){
            acesso.carregaDados();
            acesso.email = usuario.email;
            acesso.senha = usuario.senha;
        }
        private void carregaDados(){
            carregaDadosPessoal();
            carregaDadosAcesso();
        }
       
    

        private Form formularioAtivo = null;
        private void abrirFormulario(Form childForm)
        {
            if (formularioAtivo != null)
            {
                formularioAtivo.Hide();
            }
            formularioAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btPessoal_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(pessoal);
        }

     

        private void btAcesso_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(acesso);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbConfirmar_Click(object sender, EventArgs e)
        {
              try
            {
                Context ctx = new Context();
                Usuario usu = ctx.usuarios.Where(el => el.id == usuario.id).FirstOrDefault();

                atualizaDados();
                if (usu == null)
                {
                    ctx.usuarios.Add(usuario);
                    ctx.SaveChanges();
                    Logger.logWrapper("Usuario cadastrado com sucesso", Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Usuario cadastrado com sucesso");
                }
                else
                {
                    atualizaUsuario(usu, usuario);
                    ctx.SaveChanges();
                    Logger.logWrapper("Usuario atualizado com sucesso", Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Usuario atualizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                Logger.logWrapper("Erro ao cadastrar usuario", Login.usuarioLogado.nomeCompleto);
                MessageBox.Show("Erro ao cadastrar usuario");
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
