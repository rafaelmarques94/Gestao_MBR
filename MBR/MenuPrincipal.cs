﻿using MBR.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBR
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ToolStripButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Cadastros.Usuario usuario = new Cadastros.Usuario();
            this.Hide();
            usuario.ShowDialog();
        }

        private void ToolStripButton8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void ToolStripButton9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Hide();
            cliente.ShowDialog();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            CatalogoCliente catalogo = new CatalogoCliente();
            this.Hide();
            catalogo.ShowDialog();
        }
    }
}
