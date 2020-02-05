using MBR.Classes;
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

namespace MBR
{
    public partial class CatalogoCliente : Form
    {
        public CatalogoCliente()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ConMySql conexao = new ConMySql();
            conexao.ligar();
            DataTable dtCliente = new DataTable();

            try
            {
                string comando = $@"SELECT * FROM  cliente where nome like '%{txtPesquisar.Text}%'";
                //WHERE(SP.PES_NUMERO = {txtPesquisar.Text}) ";
                MySqlDataAdapter Adapter = new MySqlDataAdapter(comando, conexao.con());
                Adapter.Fill(dtCliente);
                dgvCliente.DataSource = dtCliente;

                for (int count = 0; count < dtCliente.Rows.Count; count++)
                {
                    dgvCliente.Rows[count].Cells[1].Value = dtCliente.Rows[count]["NOME"].ToString();
                    dgvCliente.Rows[count].Cells[2].Value = dtCliente.Rows[count]["TELEFONE"].ToString();
                    dgvCliente.Rows[count].Cells[0].Value = dtCliente.Rows[count]["IMAGEM"];
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show("ERRO AO BUSCAR CLIENTES" + "\n" + EX.Message);
            }

        }



        private void CatalogoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();


        }

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            byte[] byteFoto = (byte[])dgvCliente.SelectedRows[0].Cells[0].Value;
            MemoryStream ms = new MemoryStream(byteFoto);

            string nome = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();
            string telefone = dgvCliente.SelectedRows[0].Cells[2].Value.ToString();
            Image foto = Image.FromStream(ms);

            DadosCliente cliente = new DadosCliente(nome, telefone, foto);
            this.Hide();

            if (DialogResult.OK != cliente.ShowDialog()) //verifica se a tela de dados do cliente foi fechada
            {
                this.Show();
            }

        }
    }

}

