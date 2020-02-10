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
            this.TÍTULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLICITANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIÇÃO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATENDIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidente)).BeginInit();
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
            this.DESCRIÇÃO,
            this.ATENDIMENTO});
            this.dgvIncidente.Location = new System.Drawing.Point(1, 0);
            this.dgvIncidente.Name = "dgvIncidente";
            this.dgvIncidente.RowHeadersVisible = false;
            this.dgvIncidente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIncidente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidente.ShowCellErrors = false;
            this.dgvIncidente.ShowCellToolTips = false;
            this.dgvIncidente.ShowEditingIcon = false;
            this.dgvIncidente.ShowRowErrors = false;
            this.dgvIncidente.Size = new System.Drawing.Size(817, 487);
            this.dgvIncidente.TabIndex = 0;
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
            // DESCRIÇÃO
            // 
            this.DESCRIÇÃO.HeaderText = "DESCRIÇÃO";
            this.DESCRIÇÃO.Name = "DESCRIÇÃO";
            this.DESCRIÇÃO.Width = 265;
            // 
            // ATENDIMENTO
            // 
            this.ATENDIMENTO.HeaderText = "ATENDIMENTO";
            this.ATENDIMENTO.Name = "ATENDIMENTO";
            // 
            // Lista_Incidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 488);
            this.Controls.Add(this.dgvIncidente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_Incidentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lista_Incidentes_FormClosing);
            this.Load += new System.EventHandler(this.Lista_Incidentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn TÍTULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLICITANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIÇÃO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENDIMENTO;
        public System.Windows.Forms.DataGridView dgvIncidente;
    }
}