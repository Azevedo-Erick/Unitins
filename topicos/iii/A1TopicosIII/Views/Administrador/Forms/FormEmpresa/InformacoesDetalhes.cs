using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador.Forms.FormEmpresa
{
    public partial class InformacoesDetalhes : Form
    {
        public string razaoSocial = "";
        public string nomeFantasia = "";
        public string inscricaoMunicipal = "";
        public string inscricaoEstadual = "";
        public string ramoAtividade = "";
        public string porteEmpresa = "";
        public bool optanteSimples = false;
        public InformacoesDetalhes()
        {
            InitializeComponent();
        }

        public void carregaDados()
        {
            tbRazaoSocial.Text = razaoSocial; 
            tbNomeSocial.Text = nomeFantasia;
            tbInscricaoMunicipal.Text = inscricaoMunicipal;
            tbInscricaoEstadual.Text = inscricaoEstadual;
            tbRamoAtividade.Text = ramoAtividade;
        }

        private void tbRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            razaoSocial = tbRazaoSocial.Text;
        }

        private void tbNomeSocial_TextChanged(object sender, EventArgs e)
        {
            nomeFantasia = tbNomeSocial.Text;
        }

        private void tbInscricaoMunicipal_TextChanged(object sender, EventArgs e)
        {
            inscricaoEstadual = tbInscricaoMunicipal.Text;
        }

        private void tbInscricaoEstadual_TextChanged(object sender, EventArgs e)
        {
            inscricaoEstadual = tbInscricaoEstadual.Text;
        }

        private void tbRamoAtividade_TextChanged(object sender, EventArgs e)
        {
            ramoAtividade = tbRamoAtividade.Text;
        }
    }
}
