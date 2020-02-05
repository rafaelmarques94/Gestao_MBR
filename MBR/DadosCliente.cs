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
    public partial class DadosCliente : Form
    {
        public DadosCliente()
        {
           
        }

        public DadosCliente(string nome, string telefone, Image perfil)
        {

            InitializeComponent();

            this.Text = nome;
            pictureCliente.Image = perfil;
            lblNome.Text = nome;
            //lblEmail.Text = email;
            lblTelefone.Text = telefone;
            //lblEndereco.Text = endereco;

        }
    }
}
