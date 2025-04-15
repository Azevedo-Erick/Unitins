namespace A1TopicosIII.Views.Administrador.Forms.FormResponsavelEmpresa
{
    partial class InformacoesDetalhesResponsavelEmpresa
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
            this.label7 = new System.Windows.Forms.Label();
            this.dTPNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbFuncao = new System.Windows.Forms.TextBox();
            this.panelEmail.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nascimento";
            // 
            // dTPNascimento
            // 
            this.dTPNascimento.Location = new System.Drawing.Point(78, 217);
            this.dTPNascimento.Name = "dTPNascimento";
            this.dTPNascimento.Size = new System.Drawing.Size(200, 20);
            this.dTPNascimento.TabIndex = 31;
            this.dTPNascimento.ValueChanged += new System.EventHandler(this.dTPNascimento_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Funcao";
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.Window;
            this.panelEmail.Controls.Add(this.tbNome);
            this.panelEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelEmail.Location = new System.Drawing.Point(78, 88);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(200, 39);
            this.panelEmail.TabIndex = 25;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNome.Location = new System.Drawing.Point(3, 13);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(189, 13);
            this.tbNome.TabIndex = 1;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.tbFuncao);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(78, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 39);
            this.panel4.TabIndex = 28;
            // 
            // tbFuncao
            // 
            this.tbFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFuncao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFuncao.Location = new System.Drawing.Point(3, 13);
            this.tbFuncao.Name = "tbFuncao";
            this.tbFuncao.Size = new System.Drawing.Size(189, 13);
            this.tbFuncao.TabIndex = 1;
            this.tbFuncao.TextChanged += new System.EventHandler(this.tbFuncao_TextChanged);
            // 
            // InformacoesDetalhesResponsavelEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dTPNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panel4);
            this.Name = "InformacoesDetalhesResponsavelEmpresa";
            this.Text = "InformacoesDetalhesResponsavelEmpresa";
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTPNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbFuncao;
    }
}