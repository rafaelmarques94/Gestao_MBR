using MBR.Classes;
using MySql.Data.MySqlClient;
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
    }
}
