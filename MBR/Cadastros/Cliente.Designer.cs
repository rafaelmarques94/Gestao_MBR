namespace MBR.Cadastros
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(190, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 24);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "      Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(102, 330);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 24);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "  Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(63, 172);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(164, 23);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Escolher Arquivo";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("fotoPerfil.Image")));
            this.fotoPerfil.Location = new System.Drawing.Point(63, 2);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(164, 164);
            this.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPerfil.TabIndex = 16;
            this.fotoPerfil.TabStop = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEndereco.Location = new System.Drawing.Point(23, 241);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(249, 20);
            this.txtEndereco.TabIndex = 12;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.TxtEndereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.TxtEndereco_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(23, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 20);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "mail@example.com";
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelefone.Location = new System.Drawing.Point(23, 293);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(249, 20);
            this.txtTelefone.TabIndex = 14;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.TxtTelefone_Leave);
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(23, 215);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 20);
            this.txtNome.TabIndex = 11;
            this.txtNome.Text = "Nome";
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 408);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox fotoPerfil;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
    }
}