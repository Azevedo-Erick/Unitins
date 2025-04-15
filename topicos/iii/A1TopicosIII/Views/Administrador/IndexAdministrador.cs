using A1TopicosIII.Utils;
using A1TopicosIII.Views.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views
{
    public partial class IndexAdministrador : Form
    {
        public IndexAdministrador()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelGerenciarSubMenu.Visible = false;
        }
        private void changeSubMenu(Panel submenu)
        {
            submenu.Visible = !submenu.Visible;
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            changeSubMenu(panelGerenciarSubMenu);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            GerenciarEmpresas gerenciarEmpresas = new GerenciarEmpresas();
            abrirFormulario(gerenciarEmpresas);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            GerenciarUsuarios gerenciarUsuarios = new GerenciarUsuarios();
            abrirFormulario(gerenciarUsuarios);
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            GerenciarContratos gerenciarContratos = new GerenciarContratos();
            abrirFormulario(gerenciarContratos);
        }

        private void IndexAdministrador_Load(object sender, EventArgs e)
        {

        }

        private Form formularioAtivo = null;
        private void abrirFormulario(Form childForm) { 
        if(formularioAtivo != null){
                formularioAtivo.Close();
            }
            formularioAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
        }

       

        private void btResponsaveis_Click(object sender, EventArgs e)
        {
            GerenciarResponsaveisEmpresa gerenciarResponsaveis = new GerenciarResponsaveisEmpresa();
            abrirFormulario(gerenciarResponsaveis);
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Logger.logWrapper("Realizou logout", Login.usuarioLogado.nomeCompleto);
            Application.Exit();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login.usuarioLogado = null;
            Logger.logWrapper("Realizou logout", Login.usuarioLogado.nomeCompleto);
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
