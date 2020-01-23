namespace MBR.Cadastros
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(12, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "mail@example.com";
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSenha.Location = new System.Drawing.Point(12, 85);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(249, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.TxtSenha_Leave);
            // 
            // txtLogin
            // 
            this.txtLogin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLogin.Location = new System.Drawing.Point(12, 48);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(249, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.Text = "Login";
            this.txtLogin.Enter += new System.EventHandler(this.TxtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.TxtLogin_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelefone.Location = new System.Drawing.Point(12, 156);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(249, 20);
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.TxtTelefone_Leave);
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fotoPerfil.BackgroundImage")));
            this.fotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoPerfil.Location = new System.Drawing.Point(286, 12);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(151, 164);
            this.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPerfil.TabIndex = 6;
            this.fotoPerfil.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(286, 182);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(151, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Escolher Arquivo";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "  Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(100, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "      Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 216);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.PictureBox fotoPerfil;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}