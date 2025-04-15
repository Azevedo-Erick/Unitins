using A1TopicosIII.Data;
using A1TopicosIII.Models;
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
    public partial class InformacoesResponsavelEmpresa : Form
    {
        public ContatoResponsavelEmpresa responsavelEmpresa = new ContatoResponsavelEmpresa();
    
        public InformacoesResponsavelEmpresa()
        {
            InitializeComponent();
        }

        public void carregaDados()
        {
            lbCep.Text = responsavelEmpresa.cep;
            lbNome.Text = responsavelEmpresa.nome;
            lbCargo.Text = responsavelEmpresa.funcao;
            lbTelefone.Text = $"({responsavelEmpresa.ddd}) {responsavelEmpresa.numero_telefone})"; 
            lbFax.Text = responsavelEmpresa.fax;
            lbEmail.Text = responsavelEmpresa.email;
            lbCidade.Text = responsavelEmpresa.cidade;
            lbEstado.Text = responsavelEmpresa.estado;
            lbComplemento.Text = responsavelEmpresa.complemento;
            lbNascimento.Text = responsavelEmpresa.dataNascimento.ToString();
            lbNumero.Text = responsavelEmpresa.numero;
            lbBairro.Text = responsavelEmpresa.bairro;

        }

      

        private void InformacoesResponsavelEmpresa_Load(object sender, EventArgs e)
        {

            this.responsaveisEmpresaTableAdapter.Fill(this.tp3DataSet.ResponsaveisEmpresa);
        }

        private void lbCep_Click(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void lbCargo_Click(object sender, EventArgs e)
        {

        }

        private void lbTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lbFax_Click(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lbCidade_Click(object sender, EventArgs e)
        {

        }

        private void lbEstado_Click(object sender, EventArgs e)
        {

        }

        private void lbComplemento_Click(object sender, EventArgs e)
        {

        }

        private void lbNumero_Click(object sender, EventArgs e)
        {

        }

        private void lbRua_Click(object sender, EventArgs e)
        {

        }

        private void lbBairro_Click(object sender, EventArgs e)
        {

        }

     

        private void CloseListener(object sender, EventArgs e, string test)
        {
            this.carregaDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Context ctx = new Context();
                int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                ContatoResponsavelEmpresa responsavel = ctx.responsaveis.Where(el => el.id == id).FirstOrDefault();
                responsavelEmpresa = responsavel;
                carregaDados();
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
