namespace A1TopicosIII.Views.Administrador.Forms
{
    partial class ResponsavelEmpresaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSalvar = new System.Windows.Forms.Button();
            this.tbContato = new System.Windows.Forms.Button();
            this.tbEndereco = new System.Windows.Forms.Button();
            this.tbDetalhes = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.tbSalvar);
            this.panel1.Controls.Add(this.tbContato);
            this.panel1.Controls.Add(this.tbEndereco);
            this.panel1.Controls.Add(this.tbDetalhes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 0;
            // 
            // tbSalvar
            // 
            this.tbSalvar.BackColor = System.Drawing.Color.Green;
            this.tbSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbSalvar.Location = new System.Drawing.Point(718, 0);
            this.tbSalvar.Name = "tbSalvar";
            this.tbSalvar.Size = new System.Drawing.Size(82, 46);
            this.tbSalvar.TabIndex = 3;
            this.tbSalvar.Text = "Salvar";
            this.tbSalvar.UseVisualStyleBackColor = false;
            this.tbSalvar.Click += new System.EventHandler(this.tbSalvar_Click);
            // 
            // tbContato
            // 
            this.tbContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbContato.Location = new System.Drawing.Point(202, 0);
            this.tbContato.Name = "tbContato";
            this.tbContato.Size = new System.Drawing.Size(82, 46);
            this.tbContato.TabIndex = 2;
            this.tbContato.Text = "Contato";
            this.tbContato.UseVisualStyleBackColor = true;
            this.tbContato.Click += new System.EventHandler(this.tbContato_Click);
            // 
            // tbEndereco
            // 
            this.tbEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbEndereco.Location = new System.Drawing.Point(104, 0);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(82, 46);
            this.tbEndereco.TabIndex = 1;
            this.tbEndereco.Text = "Endereco";
            this.tbEndereco.UseVisualStyleBackColor = true;
            this.tbEndereco.Click += new System.EventHandler(this.tbEndereco_Click);
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbDetalhes.Location = new System.Drawing.Point(0, 0);
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Size = new System.Drawing.Size(82, 46);
            this.tbDetalhes.TabIndex = 0;
            this.tbDetalhes.Text = "Detalhes";
            this.tbDetalhes.UseVisualStyleBackColor = true;
            this.tbDetalhes.Click += new System.EventHandler(this.tbDetalhes_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 46);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 404);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btCancelar.Location = new System.Drawing.Point(624, 0);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(77, 46);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ResponsavelEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResponsavelEmpresaForm";
            this.Text = "ResponsavelEmpresaForm";
            this.Load += new System.EventHandler(this.ResponsavelEmpresaForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbSalvar;
        private System.Windows.Forms.Button tbContato;
        private System.Windows.Forms.Button tbEndereco;
        private System.Windows.Forms.Button tbDetalhes;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btCancelar;
    }
}