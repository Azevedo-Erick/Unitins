namespace A1TopicosIII.Views.Administrador
{
    partial class GerenciarContratos
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
            this.quantificadorVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatanteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratadoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSelecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp3DataSet = new A1TopicosIII.tp3DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratosTableAdapter = new A1TopicosIII.tp3DataSetTableAdapters.ContratosTableAdapter();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(661, 49);
            this.panel1.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 17);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(113, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Gerencia de Contratos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(586, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 49);
            this.btnAdicionar.TabIndex = 3;
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
            this.quantificadorVigenciaDataGridViewTextBoxColumn,
            this.tipoVigenciaDataGridViewTextBoxColumn,
            this.contatanteidDataGridViewTextBoxColumn,
            this.contratadoidDataGridViewTextBoxColumn,
            this.btSelecionar,
            this.btExcluir});
            this.dataGridView1.DataSource = this.contratosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(661, 370);
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
            // quantificadorVigenciaDataGridViewTextBoxColumn
            // 
            this.quantificadorVigenciaDataGridViewTextBoxColumn.DataPropertyName = "quantificadorVigencia";
            this.quantificadorVigenciaDataGridViewTextBoxColumn.HeaderText = "quantificadorVigencia";
            this.quantificadorVigenciaDataGridViewTextBoxColumn.Name = "quantificadorVigenciaDataGridViewTextBoxColumn";
            this.quantificadorVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoVigenciaDataGridViewTextBoxColumn
            // 
            this.tipoVigenciaDataGridViewTextBoxColumn.DataPropertyName = "tipoVigencia";
            this.tipoVigenciaDataGridViewTextBoxColumn.HeaderText = "tipoVigencia";
            this.tipoVigenciaDataGridViewTextBoxColumn.Name = "tipoVigenciaDataGridViewTextBoxColumn";
            this.tipoVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contatanteidDataGridViewTextBoxColumn
            // 
            this.contatanteidDataGridViewTextBoxColumn.DataPropertyName = "contatante_id";
            this.contatanteidDataGridViewTextBoxColumn.HeaderText = "contatante_id";
            this.contatanteidDataGridViewTextBoxColumn.Name = "contatanteidDataGridViewTextBoxColumn";
            this.contatanteidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contratadoidDataGridViewTextBoxColumn
            // 
            this.contratadoidDataGridViewTextBoxColumn.DataPropertyName = "contratado_id";
            this.contratadoidDataGridViewTextBoxColumn.HeaderText = "contratado_id";
            this.contratadoidDataGridViewTextBoxColumn.Name = "contratadoidDataGridViewTextBoxColumn";
            this.contratadoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btSelecionar
            // 
            this.btSelecionar.HeaderText = "Selecionar";
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.ReadOnly = true;
            this.btSelecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btSelecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btExcluir
            // 
            this.btExcluir.HeaderText = "Excluir";
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.ReadOnly = true;
            this.btExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "Contratos";
            this.contratosBindingSource.DataSource = this.tp3DataSet;
            // 
            // tp3DataSet
            // 
            this.tp3DataSet.DataSetName = "tp3DataSet";
            this.tp3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratosTableAdapter
            // 
            this.contratosTableAdapter.ClearBeforeFill = true;
            // 
            // btRecarregar
            // 
            this.btRecarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.btRecarregar.FlatAppearance.BorderSize = 0;
            this.btRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecarregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRecarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRecarregar.Location = new System.Drawing.Point(491, 3);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btRecarregar.Size = new System.Drawing.Size(89, 45);
            this.btRecarregar.TabIndex = 9;
            this.btRecarregar.Text = "Recarregar Dados";
            this.btRecarregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRecarregar.UseVisualStyleBackColor = false;
            this.btRecarregar.Click += new System.EventHandler(this.btRecarregar_Click);
            // 
            // GerenciarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarContratos";
            this.Text = "GerenciarContratos";
            this.Load += new System.EventHandler(this.GerenciarContratos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
    
        private System.Windows.Forms.DataGridView dataGridView1;
        private tp3DataSet tp3DataSet;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private tp3DataSetTableAdapters.ContratosTableAdapter contratosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantificadorVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatanteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratadoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btSelecionar;
        private System.Windows.Forms.DataGridViewButtonColumn btExcluir;
        private System.Windows.Forms.Button btRecarregar;
    }
}