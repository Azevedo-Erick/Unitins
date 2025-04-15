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
    public partial class GerenciarContratos : Form
    {
        public GerenciarContratos()
        {
            InitializeComponent();
        }

        private void GerenciarContratos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tp3DataSet.Contratos'. Você pode movê-la ou removê-la conforme necessário.
            this.contratosTableAdapter.Fill(this.tp3DataSet.Contratos);
           

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ContratoForm form = new ContratoForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

try{

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "btSelecionar")
            {
                Context ctx = new Context();

                int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                Contrato contrato = ctx.contratos.Include("contratado").Include("contatante").Include("responsavel").Where(el => el.id == id).FirstOrDefault();
                Console.WriteLine(contrato.contratado.id);
                ContratoForm.contrato = contrato;
                ContratoForm form = new ContratoForm();
                form.ShowDialog();
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name.Equals("btExcluir"))
            {
                Context ctx = new Context();
                Console.WriteLine("teste");
                int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                Empresa empresa = ctx.empresas.Where(el => el.id == id).FirstOrDefault();
                ctx.empresas.Remove(empresa);
                ctx.SaveChanges();
            }
}catch(Exception ex){
    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            this.tp3DataSet.Clear();
            this.contratosTableAdapter.Fill(this.tp3DataSet.Contratos);

        }
    }
}
