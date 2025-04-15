namespace A1TopicosIII
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.linkLabelCriarConta = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelSenha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelEmail);
            this.groupBox1.Controls.Add(this.panelSenha);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.linkLabelCriarConta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(445, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.SystemColors.Window;
            this.panelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmail.Controls.Add(this.tbEmail);
            this.panelEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelEmail.Location = new System.Drawing.Point(132, 115);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(200, 39);
            this.panelEmail.TabIndex = 0;
            this.panelEmail.Click += new System.EventHandler(this.panelEmail_Click);
            this.panelEmail.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmail_Paint);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Location = new System.Drawing.Point(3, 13);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(187, 13);
            this.tbEmail.TabIndex = 1;
            // 
            // panelSenha
            // 
            this.panelSenha.BackColor = System.Drawing.SystemColors.Window;
            this.panelSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSenha.Controls.Add(this.tbSenha);
            this.panelSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelSenha.Location = new System.Drawing.Point(132, 173);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(200, 39);
            this.panelSenha.TabIndex = 0;
            this.panelSenha.Click += new System.EventHandler(this.panelSenha_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Location = new System.Drawing.Point(3, 13);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(187, 13);
            this.tbSenha.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btFechar);
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 70);
            this.panel1.TabIndex = 7;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Transparent;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.btFechar.Location = new System.Drawing.Point(391, 3);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(51, 37);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "X";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLogin.Location = new System.Drawing.Point(189, 9);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(99, 45);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            this.lbLogin.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabelCriarConta
            // 
            this.linkLabelCriarConta.AutoSize = true;
            this.linkLabelCriarConta.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCriarConta.LinkColor = System.Drawing.Color.Black;
            this.linkLabelCriarConta.Location = new System.Drawing.Point(129, 291);
            this.linkLabelCriarConta.Name = "linkLabelCriarConta";
            this.linkLabelCriarConta.Size = new System.Drawing.Size(94, 13);
            this.linkLabelCriarConta.TabIndex = 4;
            this.linkLabelCriarConta.TabStop = true;
            this.linkLabelCriarConta.Text = "Não possuo conta";
            this.linkLabelCriarConta.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCriarConta_LinkClicked);
            this.linkLabelCriarConta.Paint += new System.Windows.Forms.PaintEventHandler(this.linkLabelCriarConta_LinkPaint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.Window;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Location = new System.Drawing.Point(197, 227);
            this.btLogin.Name = "btLogin";
            this.btLogin.Padding = new System.Windows.Forms.Padding(5);
            this.btLogin.Size = new System.Drawing.Size(69, 39);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 365);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.LinkLabel linkLabelCriarConta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btFechar;
    }
}

