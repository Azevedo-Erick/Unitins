using A1TopicosIII.Data;
using A1TopicosIII.Models;
using A1TopicosIII.Views.Administrador.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador
{
    public partial class GerenciarEmpresas : Form
    {
        public GerenciarEmpresas()
        {
            InitializeComponent();
        }

        private void GerenciarEmpresas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tp3DataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            this.empresasTableAdapter.Fill(this.tp3DataSet.Empresas);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            EmpresaForm form = new EmpresaForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "btSelecionar")
                {
                    Context ctx = new Context();
                
                    int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                    Empresa empresa = ctx.empresas.Include(el=>el.responsavel).Where(el => el.id == id).FirstOrDefault();
                    EmpresaForm.empresa = empresa;
                    EmpresaForm form = new EmpresaForm();
                    form.ShowDialog();
                }
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name.Equals("btDeletar"))
                {
                    Context ctx = new Context();
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
            this.empresasTableAdapter.Fill(this.tp3DataSet.Empresas);

        }
    }
}
