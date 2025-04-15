namespace A1TopicosIII.Views.Administrador.Forms.FormUsuario
{
    partial class InformacoesPessoais
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.lbRg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbRg = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nascimento";
            // 
            // dTPNascimento
            // 
            this.dTPNascimento.Location = new System.Drawing.Point(305, 166);
            this.dTPNascimento.Name = "dTPNascimento";
            this.dTPNascimento.Size = new System.Drawing.Size(200, 20);
            this.dTPNascimento.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Status";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rbAtivo);
            this.panel6.Controls.Add(this.rbInativo);
            this.panel6.Location = new System.Drawing.Point(305, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 47);
            this.panel6.TabIndex = 21;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(24, 17);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 8;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(139, 17);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 9;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(71, 189);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(23, 13);
            this.lbRg.TabIndex = 16;
            this.lbRg.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "CPF";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.tbRg);
            this.panel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel3.Location = new System.Drawing.Point(71, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 39);
            this.panel3.TabIndex = 19;
            // 
            // tbRg
            // 
            this.tbRg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRg.Location = new System.Drawing.Point(3, 12);
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(189, 13);
            this.tbRg.TabIndex = 1;
            this.tbRg.TextChanged += new System.EventHandler(this.tbRg_TextChanged);
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.Window;
            this.panelEmail.Controls.Add(this.tbNome);
            this.panelEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelEmail.Location = new System.Drawing.Point(71, 89);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(200, 39);
            this.panelEmail.TabIndex = 15;
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
            this.panel4.Controls.Add(this.tbCPF);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(71, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 39);
            this.panel4.TabIndex = 20;
            // 
            // tbCPF
            // 
            this.tbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCPF.Location = new System.Drawing.Point(3, 13);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(189, 13);
            this.tbCPF.TabIndex = 1;
            this.tbCPF.TextChanged += new System.EventHandler(this.tbCPF_TextChanged);
            // 
            // InformacoesPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dTPNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformacoesPessoais";
            this.Text = "InformacoesPessoais";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbRg;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCPF;
    }
}