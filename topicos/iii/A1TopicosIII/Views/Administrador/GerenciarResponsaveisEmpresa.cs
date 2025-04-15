using A1TopicosIII.Data;
using A1TopicosIII.Models;
using A1TopicosIII.Views.Administrador.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador
{
    public partial class GerenciarResponsaveisEmpresa : Form
    {
        public GerenciarResponsaveisEmpresa()
        {
            InitializeComponent();
        }

        private void GerenciarResponsaveisEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tp3DataSet.ResponsaveisEmpresa'. Você pode movê-la ou removê-la conforme necessário.
            this.responsaveisEmpresaTableAdapter.Fill(this.tp3DataSet.ResponsaveisEmpresa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Context ctx = new Context();
                Console.WriteLine(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                ContatoResponsavelEmpresa responsavel = ctx.responsaveis.Where(el => el.id == id).FirstOrDefault();

                ResponsavelEmpresaForm.responsavelEmpresa = responsavel;
                ResponsavelEmpresaForm form = new ResponsavelEmpresaForm();
                form.Show();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ResponsavelEmpresaForm form = new ResponsavelEmpresaForm();
            form.ShowDialog();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            this.tp3DataSet.Clear();
            this.responsaveisEmpresaTableAdapter.Fill(this.tp3DataSet.ResponsaveisEmpresa);

        }
    }
}
