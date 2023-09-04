namespace Escola_POO_BASE.Telas
{
    partial class TelaLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbProfessor = new System.Windows.Forms.RadioButton();
            this.RdbAluno = new System.Windows.Forms.RadioButton();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Escola_POO_BASE.Properties.Resources.cadeado;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.RdbProfessor);
            this.groupBox1.Controls.Add(this.RdbAluno);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Location = new System.Drawing.Point(227, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // RdbProfessor
            // 
            this.RdbProfessor.AutoSize = true;
            this.RdbProfessor.Location = new System.Drawing.Point(24, 201);
            this.RdbProfessor.Name = "RdbProfessor";
            this.RdbProfessor.Size = new System.Drawing.Size(122, 29);
            this.RdbProfessor.TabIndex = 6;
            this.RdbProfessor.Text = "Professor";
            this.RdbProfessor.UseVisualStyleBackColor = true;
            // 
            // RdbAluno
            // 
            this.RdbAluno.AutoSize = true;
            this.RdbAluno.Checked = true;
            this.RdbAluno.Location = new System.Drawing.Point(24, 173);
            this.RdbAluno.Name = "RdbAluno";
            this.RdbAluno.Size = new System.Drawing.Size(85, 29);
            this.RdbAluno.TabIndex = 5;
            this.RdbAluno.TabStop = true;
            this.RdbAluno.Text = "Aluno";
            this.RdbAluno.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(169, 173);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(139, 57);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(24, 132);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(284, 31);
            this.TxtSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(24, 70);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(284, 31);
            this.TxtEmail.TabIndex = 0;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.RadioButton RdbAluno;
        private System.Windows.Forms.RadioButton RdbProfessor;
    }
}

