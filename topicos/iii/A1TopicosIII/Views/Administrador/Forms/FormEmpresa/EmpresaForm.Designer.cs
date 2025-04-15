namespace A1TopicosIII.Views.Administrador.Forms
{
    partial class EmpresaForm
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
            this.responsaveisEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp3DataSet = new A1TopicosIII.tp3DataSet();
            this.responsaveisEmpresaTableAdapter = new A1TopicosIII.tp3DataSetTableAdapters.ResponsaveisEmpresaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btResponsavel = new System.Windows.Forms.Button();
            this.btEndereco = new System.Windows.Forms.Button();
            this.btContato = new System.Windows.Forms.Button();
            this.btDetalhes = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.responsaveisEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // responsaveisEmpresaBindingSource
            // 
            this.responsaveisEmpresaBindingSource.DataMember = "ResponsaveisEmpresa";
            this.responsaveisEmpresaBindingSource.DataSource = this.tp3DataSet;
            // 
            // tp3DataSet
            // 
            this.tp3DataSet.DataSetName = "tp3DataSet";
            this.tp3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsaveisEmpresaTableAdapter
            // 
            this.responsaveisEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btResponsavel);
            this.panel1.Controls.Add(this.btEndereco);
            this.panel1.Controls.Add(this.btContato);
            this.panel1.Controls.Add(this.btDetalhes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Green;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(718, 0);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(82, 42);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btResponsavel
            // 
            this.btResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResponsavel.Location = new System.Drawing.Point(176, 0);
            this.btResponsavel.Name = "btResponsavel";
            this.btResponsavel.Size = new System.Drawing.Size(82, 42);
            this.btResponsavel.TabIndex = 3;
            this.btResponsavel.Text = "Responsavel";
            this.btResponsavel.UseVisualStyleBackColor = true;
            this.btResponsavel.Click += new System.EventHandler(this.btResponsavel_Click);
            // 
            // btEndereco
            // 
            this.btEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEndereco.Location = new System.Drawing.Point(88, 0);
            this.btEndereco.Name = "btEndereco";
            this.btEndereco.Size = new System.Drawing.Size(82, 42);
            this.btEndereco.TabIndex = 2;
            this.btEndereco.Text = "Endereco";
            this.btEndereco.UseVisualStyleBackColor = true;
            this.btEndereco.Click += new System.EventHandler(this.btEndereco_Click);
            // 
            // btContato
            // 
            this.btContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContato.Location = new System.Drawing.Point(264, 0);
            this.btContato.Name = "btContato";
            this.btContato.Size = new System.Drawing.Size(82, 42);
            this.btContato.TabIndex = 1;
            this.btContato.Text = "Contato";
            this.btContato.UseVisualStyleBackColor = true;
            this.btContato.Click += new System.EventHandler(this.btContato_Click);
            // 
            // btDetalhes
            // 
            this.btDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetalhes.Location = new System.Drawing.Point(0, 0);
            this.btDetalhes.Name = "btDetalhes";
            this.btDetalhes.Size = new System.Drawing.Size(82, 42);
            this.btDetalhes.TabIndex = 0;
            this.btDetalhes.Text = "Detalhes";
            this.btDetalhes.UseVisualStyleBackColor = true;
            this.btDetalhes.Click += new System.EventHandler(this.btDetalhes_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 42);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 408);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btCancelar.Location = new System.Drawing.Point(625, 0);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(77, 43);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // EmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpresaForm";
            this.Text = "EmpresaForm";
            this.Load += new System.EventHandler(this.EmpresaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.responsaveisEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp3DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private tp3DataSet tp3DataSet;
        private System.Windows.Forms.BindingSource responsaveisEmpresaBindingSource;
        private tp3DataSetTableAdapters.ResponsaveisEmpresaTableAdapter responsaveisEmpresaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btResponsavel;
        private System.Windows.Forms.Button btEndereco;
        private System.Windows.Forms.Button btContato;
        private System.Windows.Forms.Button btDetalhes;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btCancelar;
    }
}