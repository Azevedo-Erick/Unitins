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

  

    public partial class DataTableEmpresa : Form
    {
        private string tipo;
        public  DataTableEmpresa(string tipo="")
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void DataTableEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tp3DataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            this.empresasTableAdapter.Fill(this.tp3DataSet.Empresas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "btSelecionar")
            {
                Context ctx = new Context();
                
                int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                
                Empresa empresa = ctx.empresas.Where(el => el.id == id).FirstOrDefault();

                if (tipo == "Contratante") {
                    ContratoForm.contrato.contatante = empresa;
                    Console.WriteLine(ContratoForm.contrato.contatante.nomeFantasia);
                }
                if(tipo == "Contratado")
                {

                    ContratoForm.contrato.contratado = empresa;
                    Console.WriteLine(ContratoForm.contrato.contatante.nomeFantasia);
                }
                this.Hide();
            }
        }

    }
}
