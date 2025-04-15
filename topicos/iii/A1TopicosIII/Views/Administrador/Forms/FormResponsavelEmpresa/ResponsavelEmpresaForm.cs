using A1TopicosIII.Data;
using A1TopicosIII.Models;
using A1TopicosIII.Utils;
using A1TopicosIII.Views.Administrador.Forms.FormEmpresa;
using A1TopicosIII.Views.Administrador.Forms.FormResponsavelEmpresa;
using A1TopicosIII.Views.Administrador.Forms.FormUsuario;
using A1TopicosIII.Views.Administrador.Forms.Shared;
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
    public partial class ResponsavelEmpresaForm : Form
    {
        public static ContatoResponsavelEmpresa responsavelEmpresa = new ContatoResponsavelEmpresa();
        private InformacoesDetalhesResponsavelEmpresa detalhes = new InformacoesDetalhesResponsavelEmpresa();
        InformacoesContato contato = new InformacoesContato();
        InformacoesEndereco endereco = new InformacoesEndereco();
        public ResponsavelEmpresaForm()
        {
            InitializeComponent();
            if (responsavelEmpresa != null) { 
                carregaDadosPessoais();
                carregaDadosEndereco();
                carregaDadosContato();
            }

        }
        private void carregaDadosPessoais() {
            detalhes.nome = responsavelEmpresa.nome;
            detalhes.dataNascimento = responsavelEmpresa.dataNascimento;
            detalhes.funcao = responsavelEmpresa.funcao;
            detalhes.carregaDados();
        }
        private void carregaDadosContato() {

            contato.ddd = responsavelEmpresa.ddd;

            contato.numero = responsavelEmpresa.numero_telefone;
            contato.fax = responsavelEmpresa.fax;
            contato.email = responsavelEmpresa.email;
            contato.carregaDados();
        }

        private void novoResponsavelEmpresa() {
            responsavelEmpresa.nome = detalhes.nome;
            responsavelEmpresa.dataNascimento = detalhes.dataNascimento;
            responsavelEmpresa.funcao = detalhes.funcao ;
            responsavelEmpresa.ddd = contato.ddd;
            responsavelEmpresa.numero_telefone = contato.numero;
            responsavelEmpresa.fax = contato.fax;
            responsavelEmpresa.email = contato.email;
            responsavelEmpresa.numero = endereco.numero;
            responsavelEmpresa.cep = endereco.cep;
            responsavelEmpresa.estado = endereco.estado;
            responsavelEmpresa.cidade = endereco.cidade;
            responsavelEmpresa.bairro = endereco.bairro ;
            responsavelEmpresa.complemento = endereco.endereco;
        }

        private void atualizaDados(ContatoResponsavelEmpresa antigo, ContatoResponsavelEmpresa novo)
        {
            antigo.nome = novo.nome;
            antigo.dataNascimento = novo.dataNascimento;
            antigo.funcao = novo.funcao;
            antigo.ddd = novo.ddd;
            antigo.numero = novo.numero;
            antigo.fax = novo.fax;
            antigo.email = novo.email;
            antigo.numero = novo.numero;
            antigo.cep = novo.cep;
            antigo.estado = novo.estado;
            antigo.cidade = novo.cidade;
            antigo.bairro = novo.bairro;
            antigo.complemento = novo.complemento;
            antigo.numero_telefone = novo.numero_telefone;
        }

        private void carregaDadosEndereco() {

            endereco.numero = responsavelEmpresa.numero;
            endereco.cep = responsavelEmpresa.cep;
            endereco.estado = responsavelEmpresa.estado;
            endereco.cidade = responsavelEmpresa.cidade;
            endereco.bairro = responsavelEmpresa.bairro;
            endereco.endereco = responsavelEmpresa.complemento;
            endereco.numero = responsavelEmpresa.numero;
            endereco.carregaDados();
        }

        private void ResponsavelEmpresaForm_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form formularioAtivo = null;
        private void abrirFormulario(Form childForm)
        {
            if (formularioAtivo != null)
            {
                formularioAtivo.Hide();
            }
            formularioAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tbDetalhes_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(detalhes);
        }

        private void tbEndereco_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(endereco);
        }

        private void tbContato_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(contato);
        }

        private void tbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Context ctx = new Context();
                ContatoResponsavelEmpresa responsavel = ctx.responsaveis.Where(el => el.id == responsavelEmpresa.id).FirstOrDefault();
                Console.WriteLine(responsavel);
                novoResponsavelEmpresa();
                if (responsavel == null)
                {
                    Console.WriteLine("a");
                    ctx.responsaveis.Add(responsavelEmpresa);
                    ctx.SaveChanges();
                    Logger.logWrapper("Responsavel Empresa " + responsavelEmpresa.nome + " adicionado com sucesso", Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Responsável cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    atualizaDados(responsavel, responsavelEmpresa);
                    Console.WriteLine(responsavel.nome);
                    ctx.SaveChanges();
                    Logger.logWrapper("Responsavel Empresa " + responsavelEmpresa.nome + " atualizado com sucesso", Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Responsável atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar responsável: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.logWrapper("Erro ao salvar responsavel empresa: " + ex.Message, Login.usuarioLogado.nomeCompleto);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
