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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionaImagem;
            selecionaImagem = new OpenFileDialog()
            {
                FileName = "",
                //Filter = "Arquivos de Imagem (*.jpg)|*.jpg",
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

        private void Button1_Click(object sender, EventArgs e)
        {
            byte[] imagem = System.Convert.FromBase64String(ImageToBase64(fotoPerfil.ImageLocation));

            MySqlConnection mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=MBR;uid=root;pwd=root");
            mConn.Open();

            string comando = "";
                try
                {
                
                    comando += $"insert into usuario (nome,login,senha,email,telefone,imagem) VALUES (?nome, ?login, md5(?senha), ?email,?telefone,?imagem)";
                    // OracleDataAdapter Adapter = new OracleDataAdapter(comando, _conexao._conn);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = mConn;
                    cmd.CommandText = comando;

                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("imagem", imagem);
                    cmd.ExecuteNonQuery();
                    mConn.Close();

                    MessageBox.Show("Usuário Cadastrado com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário! " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.ForeColor = Color.Black;
        }

        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtLogin.ForeColor = Color.Black;
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.ForeColor = Color.Black;
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
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

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Silver;
                txtSenha.PasswordChar = default;
            }
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                txtNome.ForeColor = Color.Silver;
            }
        }

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Login";
                txtLogin.ForeColor = Color.Silver;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
