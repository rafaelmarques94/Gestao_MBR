using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MBR
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tabelalogin(txtnome.Text, txtsenha.Text);
        }


        #region placeholder campos login
        private void txtnome_enter(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtnome.ForeColor = Color.Black;
        }

        private void txtnome_Leave(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                txtnome.Text = "Nome";
                txtnome.ForeColor = Color.Silver;
            }
        }

        private void txtsenha_Enter(object sender, EventArgs e)
        {
            txtsenha.ForeColor = Color.Black;
            txtsenha.Text = "";
            txtsenha.PasswordChar = '*';
        }

        private void txtsenha_Leave(object sender, EventArgs e)
        {
            if(txtsenha.Text == "")
            {
                txtsenha.Text = "Senha";
                txtsenha.ForeColor = Color.Silver;
                txtsenha.PasswordChar = default;
            }
        }
        #endregion

      
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;


        public DataTable tabelalogin(String usuario, String senha)
        {

            DataTable dt = new DataTable();

            MySqlConnection mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=crud;uid=root");
            mConn.Open();
            mAdapter = new MySqlDataAdapter($"SELECT `nome`, `senha` FROM `login` where nome = '{usuario}' and senha = '{senha}'", mConn);
            mAdapter.Fill(dt);

            return dt;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            DataTable dt_login = tabelalogin(txtnome.Text, txtsenha.Text);

            if (dt_login.Rows.Count > 0)
            {
                MessageBox.Show("Login efetuado com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loading loading = new Loading();
                this.Hide();
                loading.ShowDialog();

            }

            else
            {
                MessageBox.Show("Login ou senha incorretos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
