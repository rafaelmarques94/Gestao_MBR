using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBR.Cadastros
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionaImagem;
            selecionaImagem = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",             
                Title = "Selecione uma imagem"
            };

            if (selecionaImagem.ShowDialog() == DialogResult.OK)
            {
                string filePatch = selecionaImagem.FileName;
                //fotoPerfil.Image = Image.FromFile(filePatch);
                fotoPerfil.ImageLocation = filePatch;
            }
        }

        public string ImageToBase64(string caminho)
        {
            String base64String;
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(caminho))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            byte[] imagem = System.Convert.FromBase64String(ImageToBase64(fotoPerfil.ImageLocation));

            MySqlConnection mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=MBR;uid=root;pwd=root");
            mConn.Open();

            string comando = "";
            try
            {

                comando += $"insert into cliente (nome,endereco,email,telefone,imagem) VALUES (?nome,?endereco,?email,?telefone,?imagem)";
                // OracleDataAdapter Adapter = new OracleDataAdapter(comando, _conexao._conn);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = mConn;
                cmd.CommandText = comando;

                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("endereco", txtEndereco.Text);            
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("imagem", imagem);
                cmd.ExecuteNonQuery();
                mConn.Close();

                MessageBox.Show("Cliente Cadastrado com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar cadastro do cliente ! " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region PlaceHolder dos campos
        private void TxtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.ForeColor = Color.Black;
        }

        private void TxtEndereco_Enter(object sender, EventArgs e)
        {
            txtEndereco.Text = "";
            txtEndereco.ForeColor = Color.Black;
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.ForeColor = Color.Black;
        }

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.Text = "";
            txtTelefone.ForeColor = Color.Black;
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                txtNome.ForeColor = Color.Silver;
            }
        }

        private void TxtEndereco_Leave(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                txtEndereco.Text = "Endereço";
                txtEndereco.ForeColor = Color.Silver;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "mail@example.com";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "Telefone";
                txtTelefone.ForeColor = Color.Silver;
            }
        }

        #endregion

    }
}
