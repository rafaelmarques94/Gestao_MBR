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
    public partial class Lista_Incidentes : Form
    {
        public Lista_Incidentes()
        {
            InitializeComponent();
                    
        }


        public void CarregarGrid()
        {

            ConMySql conexao = new ConMySql();
            conexao.ligar();
            DataTable dtIncidente = new DataTable();

            try
            {
                string comando = @"select * from incidente order by data_abertura";

                MySqlDataAdapter Adapter = new MySqlDataAdapter(comando, conexao.con());
                Adapter.Fill(dtIncidente);
                dgvIncidente.DataSource = dtIncidente;
              

                for (int count = 0; count < dtIncidente.Rows.Count; count++)
                {
                    dgvIncidente.Rows[count].Cells[0].Value = dtIncidente.Rows[count]["titulo"];
                    dgvIncidente.Rows[count].Cells[1].Value = dtIncidente.Rows[count]["cliente"].ToString();
                    dgvIncidente.Rows[count].Cells[2].Value = dtIncidente.Rows[count]["Solicitante"].ToString();                   
                    dgvIncidente.Rows[count].Cells[3].Value = dtIncidente.Rows[count]["tipo"].ToString();
                    dgvIncidente.Rows[count].Cells[4].Value = dtIncidente.Rows[count]["usuario_atendente"].ToString();
                }

                dgvIncidente.ClearSelection();
            }

            catch (Exception EX)
            {
                MessageBox.Show("ERRO AO BUSCAR CLIENTES" + "\n" + EX.Message);
            }


        }

        private void Lista_Incidentes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void Lista_Incidentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }
    }
}
