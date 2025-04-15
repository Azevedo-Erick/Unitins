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
    public partial class GerenciarUsuarios : Form
    {
        public GerenciarUsuarios()
        {
            InitializeComponent();
        }

        private void GerenciarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tp3DataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter1.Fill(this.tp3DataSet.Usuarios);

        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            UsuarioForm form = new UsuarioForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "btSelecionar")
                {
                    Context ctx = new Context();

                    int id = int.Parse(senderGrid.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                    Usuario usuario = ctx.usuarios.Where(el => el.id == id).FirstOrDefault();
                    UsuarioForm.usuario = usuario;
                    UsuarioForm form = new UsuarioForm();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {

            tp3DataSet.Clear();
            this.usuariosTableAdapter1.Fill(this.tp3DataSet.Usuarios);

        }
    }
}
