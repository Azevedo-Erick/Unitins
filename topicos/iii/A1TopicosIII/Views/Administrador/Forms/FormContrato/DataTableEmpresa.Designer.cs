namespace A1TopicosIII.Views.Administrador.Forms.FormContrato
{
    partial class DataTableEmpresa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp3DataSet = new A1TopicosIII.tp3DataSet();
            this.empresasTableAdapter = new A1TopicosIII.tp3DataSetTableAdapters.EmpresasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoMunicipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoEstadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porteEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramoAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optantePeloSimplesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).BeginInit();
            this.SuspendLayout();
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
            this.btSelecionar});
            this.dataGridView1.DataSource = this.empresasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
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
            this.btSelecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btSelecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DataTableEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataTableEmpresa";
            this.Text = "DataTableEmpresa";
            this.Load += new System.EventHandler(this.DataTableEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tp3DataSet tp3DataSet;
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
    }
}