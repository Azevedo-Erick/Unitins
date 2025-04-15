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

namespace A1TopicosIII.Views.Administrador.Forms.FormContrato
{
    public partial class DataTableGerente : Form
    {
        public Usuario gerente = new Usuario();
        public DataTableGerente()
        {
            InitializeComponent();
        }

        private void DataTableGerente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tp3DataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            //
            Context ctx = new Context();
            //(ctx.usuarios.Where(el => el.cargo == Cargo.GESTOR).ToList()
     
            this.usuariosTableAdapter.Fill(this.tp3DataSet.Usuarios);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "btSelecionar")
            {
                Context ctx = new Context();

                int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                Usuario gerente = ctx.usuarios.Where(el => el.id == id).FirstOrDefault();
                ContratoForm.contrato.responsavel = gerente;
                this.Hide();
            }
        }
    }
}
