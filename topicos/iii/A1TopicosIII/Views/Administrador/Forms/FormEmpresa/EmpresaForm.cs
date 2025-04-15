using A1TopicosIII.Data;
using A1TopicosIII.Models;
using A1TopicosIII.Utils;
using A1TopicosIII.Views.Administrador.Forms.FormEmpresa;
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
    public partial class EmpresaForm : Form
    {
        public static Empresa empresa;
        public InformacoesDetalhes detalhes = new InformacoesDetalhes();
        public InformacoesEndereco endereco = new InformacoesEndereco();
        public InformacoesResponsavelEmpresa responsavel = new InformacoesResponsavelEmpresa();
        public InformacoesContato contato = new InformacoesContato();


        public EmpresaForm()
        {
            InitializeComponent();
            if (empresa != null)
            {
                this.carregaDadosDetalhes();
                this.carregaDadosEndereco();
                this.carregaDadosResponsavel();
                this.carregaDadosContato();
            }
        }

        private void EmpresaForm_Load(object sender, EventArgs e)
        {
            this.responsaveisEmpresaTableAdapter.Fill(this.tp3DataSet.ResponsaveisEmpresa);

        }

        private void carregaDadosDetalhes()
        {

            detalhes.razaoSocial = empresa.razaoSocial;
            detalhes.nomeFantasia = empresa.nomeFantasia;
            detalhes.inscricaoMunicipal = empresa.inscricaoMunicipal;
            detalhes.inscricaoEstadual = empresa.inscricaoEstadual;
            detalhes.porteEmpresa = empresa.porteEmpresa;
            detalhes.ramoAtividade = empresa.ramoAtividade;
            detalhes.carregaDados();
        }

        private void carregaDadosEndereco()
        {

            endereco.cep = empresa.cep;
            endereco.cidade = empresa.cidade;
            endereco.estado = empresa.estado;
            endereco.bairro = empresa.bairro;
            endereco.endereco = empresa.complemento;
            endereco.numero = empresa.numero;
            endereco.carregaDados();
        }
        private void carregaDadosResponsavel()
        {
            if (empresa.responsavel != null)
            {

            responsavel.responsavelEmpresa.id = empresa.responsavel.id;
            responsavel.responsavelEmpresa.nome = empresa.responsavel.nome;
            responsavel.responsavelEmpresa.funcao = empresa.responsavel.funcao;
            responsavel.responsavelEmpresa.dataNascimento = empresa.responsavel.dataNascimento;
            responsavel.responsavelEmpresa.fax = empresa.responsavel.fax;
            responsavel.responsavelEmpresa.email = empresa.responsavel.email;
            responsavel.responsavelEmpresa.cep = empresa.responsavel.cep;
            responsavel.responsavelEmpresa.cidade = empresa.responsavel.cidade;
            responsavel.responsavelEmpresa.estado = empresa.responsavel.estado;
            responsavel.responsavelEmpresa.bairro = empresa.responsavel.bairro;
            responsavel.responsavelEmpresa.complemento = empresa.responsavel.complemento;
            responsavel.responsavelEmpresa.numero = empresa.responsavel.numero;
            responsavel.responsavelEmpresa.ddd = empresa.responsavel.ddd;
            responsavel.responsavelEmpresa.numero_telefone = empresa.responsavel.numero_telefone;
            responsavel.carregaDados();
            }

        }

        private void carregaDadosContato()
        {
            contato.fax = empresa.fax;
            contato.email = empresa.email;
            contato.ddd = empresa.ddd;
            contato.numero = empresa.numero_telefone;
            contato.carregaDados();
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
        private void atualizaDados(Empresa antigo, Empresa novo)
        {
            antigo.razaoSocial = novo.razaoSocial;
            antigo.nomeFantasia = novo.nomeFantasia;
            antigo.inscricaoMunicipal = novo.inscricaoMunicipal;
            antigo.inscricaoEstadual = novo.inscricaoEstadual;
            antigo.porteEmpresa = novo.porteEmpresa;
            antigo.ramoAtividade = novo.ramoAtividade;
            antigo.cep = novo.cep;
            antigo.cidade = novo.cidade;
            antigo.estado = novo.estado;
            antigo.bairro = novo.bairro;
            antigo.complemento = novo.complemento;
            antigo.numero = novo.numero;
            antigo.responsavel = novo.responsavel;
            antigo.fax = novo.fax;
            antigo.email = novo.email;
            antigo.ddd = novo.ddd;
            antigo.numero_telefone = novo.numero_telefone;
        }

        private void carregaDadosFormularios()
        {
            empresa.nomeFantasia = detalhes.nomeFantasia;
            empresa.razaoSocial = detalhes.razaoSocial;
            empresa.inscricaoMunicipal = detalhes.inscricaoMunicipal;
            empresa.inscricaoEstadual = detalhes.inscricaoEstadual;
            empresa.porteEmpresa = detalhes.porteEmpresa;
            empresa.ramoAtividade = detalhes.ramoAtividade;
            empresa.cep = endereco.cep;
            empresa.cidade = endereco.cidade;
            empresa.estado = endereco.estado;
            empresa.bairro = endereco.bairro;
            empresa.complemento = endereco.endereco;
            empresa.numero = endereco.numero;
            empresa.responsavel = responsavel.responsavelEmpresa;
            empresa.fax = contato.fax;
            empresa.email = contato.email;
            empresa.ddd = contato.ddd;
            empresa.numero_telefone = contato.numero;

        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDetalhes_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(detalhes);
        }

        private void btEndereco_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(endereco);
        }

        private void btResponsavel_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(responsavel);
        }

        private void btContato_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(contato);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Context ctx = new Context();
                if (empresa == null) {
                    empresa = new Empresa();

                }
                int id = empresa.id;
                Empresa emp = ctx.empresas.Where(el => el.id == id).FirstOrDefault();
                
                carregaDadosFormularios();
                if (emp == null)
                {

                    ctx.empresas.Add(empresa);
                    Logger.logWrapper("Empresa cadastrada com sucesso" + empresa.nomeFantasia, Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    atualizaDados(emp, empresa);
                    Console.WriteLine(emp);

                    Logger.logWrapper("Empresa atualizada com sucesso" + empresa.nomeFantasia, Login.usuarioLogado.nomeCompleto);
                    MessageBox.Show("Empresa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.logWrapper("Erro ao salvar empresa" + ex.Message, Login.usuarioLogado.nomeCompleto);
                MessageBox.Show("Erro ao salvar empresa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
