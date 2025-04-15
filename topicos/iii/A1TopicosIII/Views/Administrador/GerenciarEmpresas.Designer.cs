namespace A1TopicosIII.Views.Administrador
{
    partial class GerenciarEmpresas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoMunicipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoEstadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porteEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramoAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optantePeloSimplesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp3DataSet = new A1TopicosIII.tp3DataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new A1TopicosIII.tp3DataSetTableAdapters.UsuariosTableAdapter();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new A1TopicosIII.tp3DataSetTableAdapters.EmpresasTableAdapter();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRecarregar);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 44);
            this.panel1.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 21);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(113, 13);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Gerencia de empresas";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(586, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 44);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn,
            this.inscricaoMunicipalDataGridViewTextBoxColumn,
            this.inscricaoEstadualDataGridViewTextBoxColumn,
            this.porteEmpresaDataGridViewTextBoxColumn,
            this.ramoAtividadeDataGridViewTextBoxColumn,
            this.optantePeloSimplesDataGridViewCheckBoxColumn,
            this.btSelecionar,
            this.btDeletar});
            this.dataGridView1.DataSource = this.empresasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(661, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "razaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "razaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "nomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "nomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            this.nomeFantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscricaoMunicipalDataGridViewTextBoxColumn
            // 
            this.inscricaoMunicipalDataGridViewTextBoxColumn.DataPropertyName = "inscricaoMunicipal";
            this.inscricaoMunicipalDataGridViewTextBoxColumn.HeaderText = "inscricaoMunicipal";
            this.inscricaoMunicipalDataGridViewTextBoxColumn.Name = "inscricaoMunicipalDataGridViewTextBoxColumn";
            this.inscricaoMunicipalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscricaoEstadualDataGridViewTextBoxColumn
            // 
            this.inscricaoEstadualDataGridViewTextBoxColumn.DataPropertyName = "inscricaoEstadual";
            this.inscricaoEstadualDataGridViewTextBoxColumn.HeaderText = "inscricaoEstadual";
            this.inscricaoEstadualDataGridViewTextBoxColumn.Name = "inscricaoEstadualDataGridViewTextBoxColumn";
            this.inscricaoEstadualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porteEmpresaDataGridViewTextBoxColumn
            // 
            this.porteEmpresaDataGridViewTextBoxColumn.DataPropertyName = "porteEmpresa";
            this.porteEmpresaDataGridViewTextBoxColumn.HeaderText = "porteEmpresa";
            this.porteEmpresaDataGridViewTextBoxColumn.Name = "porteEmpresaDataGridViewTextBoxColumn";
            this.porteEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ramoAtividadeDataGridViewTextBoxColumn
            // 
            this.ramoAtividadeDataGridViewTextBoxColumn.DataPropertyName = "ramoAtividade";
            this.ramoAtividadeDataGridViewTextBoxColumn.HeaderText = "ramoAtividade";
            this.ramoAtividadeDataGridViewTextBoxColumn.Name = "ramoAtividadeDataGridViewTextBoxColumn";
            this.ramoAtividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optantePeloSimplesDataGridViewCheckBoxColumn
            // 
            this.optantePeloSimplesDataGridViewCheckBoxColumn.DataPropertyName = "optantePeloSimples";
            this.optantePeloSimplesDataGridViewCheckBoxColumn.HeaderText = "optantePeloSimples";
            this.optantePeloSimplesDataGridViewCheckBoxColumn.Name = "optantePeloSimplesDataGridViewCheckBoxColumn";
            this.optantePeloSimplesDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // btSelecionar
            // 
            this.btSelecionar.HeaderText = "Selecionar";
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.ReadOnly = true;
            this.btSelecionar.Text = "Selecionar";
            // 
            // btDeletar
            // 
            this.btDeletar.HeaderText = "Deletar";
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.ReadOnly = true;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.tp3DataSet;
            // 
            // tp3DataSet
            // 
            this.tp3DataSet.DataSetName = "tp3DataSet";
            this.tp3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.tp3DataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.tp3DataSet;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // btRecarregar
            // 
            this.btRecarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.btRecarregar.FlatAppearance.BorderSize = 0;
            this.btRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecarregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRecarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRecarregar.Location = new System.Drawing.Point(491, -1);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btRecarregar.Size = new System.Drawing.Size(89, 45);
            this.btRecarregar.TabIndex = 8;
            this.btRecarregar.Text = "Recarregar Dados";
            this.btRecarregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRecarregar.UseVisualStyleBackColor = false;
            this.btRecarregar.Click += new System.EventHandler(this.btRecarregar_Click);
            // 
            // GerenciarEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarEmpresas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GerenciarEmpresas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lbNome;
        private tp3DataSet tp3DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private tp3DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private tp3DataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoMunicipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoEstadualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porteEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramoAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn optantePeloSimplesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btSelecionar;
        private System.Windows.Forms.DataGridViewButtonColumn btDeletar;
        private System.Windows.Forms.Button btRecarregar;
    }
}