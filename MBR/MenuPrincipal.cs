using MBR.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

      

        private void BtnCadastroUsuario_Click(object sender, EventArgs e)
        {
            Cadastros.Usuario usuario = new Cadastros.Usuario();
            this.Hide();
            usuario.ShowDialog();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema ?","LogOff",MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
                Login login = new Login();
                login.ShowDialog();

            }
        
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
    
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Hide();
            cliente.ShowDialog();
        }

        private void btnCatalogoCliente_Click(object sender, EventArgs e)
        {
            CatalogoCliente catalogo = new CatalogoCliente();
            this.Hide();
            catalogo.ShowDialog();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            Incidente incidente = new Incidente();
            this.Dispose();
            incidente.ShowDialog();
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            string url = "https://mbrsolucoes.com.br";
            Process.Start("chrome.exe", url);
        }

        private void BtnLista_Incidentes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Lista_Incidentes incidentes = new Lista_Incidentes();
            incidentes.ShowDialog();
        }
    }
}
