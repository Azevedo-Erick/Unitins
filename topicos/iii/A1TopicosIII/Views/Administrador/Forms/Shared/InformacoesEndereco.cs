using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1TopicosIII.Views.Administrador.Forms.FormUsuario
{
    public partial class InformacoesEndereco : Form
    {
        public string cep="";
        public  string estado = "";
        public string cidade = "";
        public  string bairro = "";
        public  string rua = "";
        public  string endereco = "";
        public  string numero = "";
        public InformacoesEndereco()
        {
            InitializeComponent();
           


        }
        public void carregaDados() {
            tbNumero.Text = numero;
            tbCep.Text = cep;
            tbEstado.Text = estado;
            tbCidade.Text = cidade;
            tbBairro.Text = bairro;
            tbRua.Text = rua;
            tbEndereco.Text = endereco;
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            numero = tbNumero.Text;
        }

        private void tbCep_TextChanged(object sender, EventArgs e)
        {
            cep = tbCep.Text;

        }

        private void tbEstado_TextChanged(object sender, EventArgs e)
        {
            estado = tbEstado.Text;
        }

        private void tbCidade_TextChanged(object sender, EventArgs e)
        {
            cidade = tbCidade.Text;
        }

        private void tbBairro_TextChanged(object sender, EventArgs e)
        {
            bairro = tbBairro.Text;
        }

        private void tbRua_TextChanged(object sender, EventArgs e)
        {
            rua = tbRua.Text;
        }

        private void tbEndereco_TextChanged(object sender, EventArgs e)
        {
            endereco = tbEndereco.Text;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            var ws = new CorreiosApi.AtendeClienteClient();
            
               try
                {
                    var resultado = ws.consultaCEP(tbCep.Text);
                    tbEndereco.Text = resultado.end;
                    //.Text = resultado.complemento2;
                    tbCidade.Text = resultado.cidade;
                    tbBairro.Text = resultado.bairro;
                    tbEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
