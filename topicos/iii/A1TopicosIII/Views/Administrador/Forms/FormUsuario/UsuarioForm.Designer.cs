namespace A1TopicosIII.Views.Administrador.Forms
{
    partial class UsuarioForm
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
            this.tbConfirmar = new System.Windows.Forms.Button();
            this.btAcesso = new System.Windows.Forms.Button();
            this.btEndereco = new System.Windows.Forms.Button();
            this.btPessoal = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.enderecosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.tbConfirmar);
            this.panel1.Controls.Add(this.btAcesso);
            this.panel1.Controls.Add(this.btEndereco);
            this.panel1.Controls.Add(this.btPessoal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 0;
            // 
            // tbConfirmar
            // 
            this.tbConfirmar.BackColor = System.Drawing.Color.Green;
            this.tbConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbConfirmar.Location = new System.Drawing.Point(723, 0);
            this.tbConfirmar.Name = "tbConfirmar";
            this.tbConfirmar.Size = new System.Drawing.Size(77, 43);
            this.tbConfirmar.TabIndex = 3;
            this.tbConfirmar.Text = "Confirmar";
            this.tbConfirmar.UseVisualStyleBackColor = false;
            this.tbConfirmar.Click += new System.EventHandler(this.tbConfirmar_Click);
            // 
            // btAcesso
            // 
            this.btAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcesso.Location = new System.Drawing.Point(166, 0);
            this.btAcesso.Name = "btAcesso";
            this.btAcesso.Size = new System.Drawing.Size(77, 43);
            this.btAcesso.TabIndex = 2;
            this.btAcesso.Text = "Acesso";
            this.btAcesso.UseVisualStyleBackColor = true;
            this.btAcesso.Click += new System.EventHandler(this.btAcesso_Click);
            // 
            // btEndereco
            // 
            this.btEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEndereco.Location = new System.Drawing.Point(83, 0);
            this.btEndereco.Name = "btEndereco";
            this.btEndereco.Size = new System.Drawing.Size(77, 43);
            this.btEndereco.TabIndex = 1;
            this.btEndereco.Text = "Endereco";
            this.btEndereco.UseVisualStyleBackColor = true;
            // 
            // btPessoal
            // 
            this.btPessoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPessoal.Location = new System.Drawing.Point(0, 0);
            this.btPessoal.Name = "btPessoal";
            this.btPessoal.Size = new System.Drawing.Size(77, 43);
            this.btPessoal.TabIndex = 0;
            this.btPessoal.Text = "Informacoes Pessoais";
            this.btPessoal.UseVisualStyleBackColor = true;
            this.btPessoal.Click += new System.EventHandler(this.btPessoal_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 43);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 407);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // enderecosBindingSource
            // 
            this.enderecosBindingSource.DataMember = "Enderecos";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(34)))), ((int)(((byte)(51)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btCancelar.Location = new System.Drawing.Point(640, 0);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(77, 43);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioForm";
            this.Text = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enderecosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource enderecosBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbConfirmar;
        private System.Windows.Forms.Button btAcesso;
        private System.Windows.Forms.Button btEndereco;
        private System.Windows.Forms.Button btPessoal;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btCancelar;
    }
}