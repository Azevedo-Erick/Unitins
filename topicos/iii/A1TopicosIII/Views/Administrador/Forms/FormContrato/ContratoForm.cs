using A1TopicosIII.Data;
using A1TopicosIII.Models;
using A1TopicosIII.Utils;
using A1TopicosIII.Views.Administrador.Forms.FormContrato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador.Forms
{
    public partial class ContratoForm : Form
    {
        public static Contrato contrato = new Contrato();
        DataTableEmpresa dataTableContratante = new DataTableEmpresa("Contratante");
        DataTableEmpresa dataTableContratado = new DataTableEmpresa("Contratado");
        DataTableGerente dataTableGerente = new DataTableGerente();
  
        public ContratoForm()
        {
            InitializeComponent();
            
                recarregarForm();
            
        }
        private void atualizaDados(Contrato antigo, Contrato novo)
        {
            antigo.contatante = novo.contatante;
            antigo.contratado = novo.contratado;
            antigo.responsavel = novo.responsavel;

        }
        private void tbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Context ctx = new Context();
                if (contrato == null) {
                    contrato = new Contrato();
                }
                int id = contrato.id;
                Contrato cont = ctx.contratos.Where(el => el.id == id).FirstOrDefault();

                if (cont == null)
                {
                    ctx.contratos.Add(contrato);
                    ctx.SaveChanges();
                    Logger.logWrapper("Contrato adicionado com sucesso", Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Contrato adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    atualizaDados(cont, contrato);
                    Console.WriteLine(cont);
                    ctx.SaveChanges();
                    Logger.logWrapper("Contrato atualizado com sucesso", Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Contrato atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.logWrapper(ex.Message, Login.usuarioLogado.nomeCompleto);
                MessageBox.Show("Erro ao adicionar contrato", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        private void btBuscarContratado_Click(object sender, EventArgs e)
        {
            dataTableContratado.Show();
        }

        private void btBuscarContratante_Click(object sender, EventArgs e)
        {
            dataTableContratante.Show();
        }

        private void btbuscarGerente_Click(object sender, EventArgs e)
        {
            dataTableGerente.Show();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            recarregarForm();
        }
        private void recarregarForm()
        {
            if(contrato.contratado != null && contrato.contatante != null)
            {

            lbContratado.Text = contrato.contratado.nomeFantasia;
            lbContratante.Text = contrato.contatante.nomeFantasia;
            lbGerente.Text = contrato.responsavel.nomeCompleto;
            }
        }
        private void lbContratante_Click(object sender, EventArgs e)
        {

        }

        private void lbContratado_Click(object sender, EventArgs e)
        {

        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                contrato.quantificadorVigencia = int.Parse(tbQuantidade.Text);
            }
            catch (Exception ex) {
                Console.WriteLine("erro");
            }
        }

        private void rbAnos_CheckedChanged(object sender, EventArgs e)
        {
            contrato.tipoVigencia = "Anos";
        }

        private void rbMeses_CheckedChanged(object sender, EventArgs e)
        {
            contrato.tipoVigencia = "Meses";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
