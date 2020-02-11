namespace MBR
{
    partial class Lista_Incidentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Incidentes));
            this.dgvIncidente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TÍTULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLICITANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATENDIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATENDENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncidente
            // 
            this.dgvIncidente.AllowUserToAddRows = false;
            this.dgvIncidente.AllowUserToDeleteRows = false;
            this.dgvIncidente.AllowUserToResizeColumns = false;
            this.dgvIncidente.AllowUserToResizeRows = false;
            this.dgvIncidente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvIncidente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncidente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIncidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TÍTULO,
            this.CLIENTE,
            this.SOLICITANTE,
            this.ATENDIMENTO,
            this.ATENDENTE});
            this.dgvIncidente.Location = new System.Drawing.Point(227, -1);
            this.dgvIncidente.Name = "dgvIncidente";
            this.dgvIncidente.RowHeadersVisible = false;
            this.dgvIncidente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIncidente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidente.ShowCellErrors = false;
            this.dgvIncidente.ShowCellToolTips = false;
            this.dgvIncidente.ShowEditingIcon = false;
            this.dgvIncidente.ShowRowErrors = false;
            this.dgvIncidente.Size = new System.Drawing.Size(655, 487);
            this.dgvIncidente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(102, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "      Assumir          Incidente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "      Vizualizar        Incidente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TÍTULO
            // 
            this.TÍTULO.HeaderText = "TÍTULO";
            this.TÍTULO.Name = "TÍTULO";
            this.TÍTULO.Width = 150;
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 150;
            // 
            // SOLICITANTE
            // 
            this.SOLICITANTE.HeaderText = "SOLICITANTE";
            this.SOLICITANTE.Name = "SOLICITANTE";
            this.SOLICITANTE.Width = 150;
            // 
            // ATENDIMENTO
            // 
            this.ATENDIMENTO.HeaderText = "ATENDIMENTO";
            this.ATENDIMENTO.Name = "ATENDIMENTO";
            // 
            // ATENDENTE
            // 
            this.ATENDENTE.HeaderText = "ATENDENTE";
            this.ATENDENTE.Name = "ATENDENTE";
            // 
            // Lista_Incidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvIncidente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_Incidentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lista_Incidentes_FormClosing);
            this.Load += new System.EventHandler(this.Lista_Incidentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvIncidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TÍTULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLICITANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENDIMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENDENTE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}