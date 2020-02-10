﻿using MBR.Classes;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace MBR
{
    public partial class Incidente : Form
    {
        public Incidente()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }



        private void PreencheComboClientes()
        {
            DataTable dt = new DataTable();
            dt = ListarClientes();

            if (dt.Rows.Count > 0)
            {
                cmbCliente.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbCliente.Items.Add(dt.Rows[i]["NOME"].ToString());
                
                }
                cmbCliente.SelectedIndex = 0;
            }
        }


        private DataTable ListarClientes()
        {
            ConMySql conexao = new ConMySql();
            conexao.ligar();
            DataTable dtCliente = new DataTable();

            try
            {
                string comando = "SELECT * FROM  cliente order by nome";               
                MySqlDataAdapter Adapter = new MySqlDataAdapter(comando, conexao.con());
                Adapter.Fill(dtCliente);
            }

            catch (Exception EX)
            {
                MessageBox.Show("ERRO AO BUSCAR CLIENTES" + "\n" + EX.Message);
            }
            return dtCliente;
        }

      
        private void CmbCliente_Click(object sender, EventArgs e)
        {
            PreencheComboClientes();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            byte[] imagem  = System.Convert.FromBase64String(ImageToBase64(txtAnexo.Text));
           
            string tipoIncidente = rbtRemoto.Checked ? tipoIncidente = rbtRemoto.Text : tipoIncidente = rbtVisita.Text;

            try
            {
                DateTime localDate = DateTime.Now;

                MySqlConnection conexao = new MySqlConnection("Persist Security Info = False; server=localhost;database=MBR;uid=root;pwd=root");
                conexao.Open();
                string comando = @"insert into incidente (titulo,cliente,solicitante,descricao,tipo,imagem,status,data_abertura)
                                   VALUES (?titulo, ?cliente, ?solicitante, ?descricao, ?tipo, ?imagem, ?status, current_timestamp() )";
            
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = comando;
                
                

                cmd.Parameters.AddWithValue("titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("cliente", cmbCliente.Text);
                cmd.Parameters.AddWithValue("solicitante", txtSolicitante.Text);
                cmd.Parameters.AddWithValue("descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("tipo", tipoIncidente);
                cmd.Parameters.AddWithValue("imagem", imagem);
                cmd.Parameters.AddWithValue("status", "Pendente");
              



                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Incidente registrado com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Dispose();
                MenuPrincipal menu = new MenuPrincipal();
                menu.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar incidente! " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionaImagem;
            selecionaImagem = new OpenFileDialog()
            {
                FileName = "",
               // Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Title = "Selecione uma Arquivo"
            };

            if (selecionaImagem.ShowDialog() == DialogResult.OK)
            {
                string filePatch = selecionaImagem.FileName;
                //fotoPerfil.Image = Image.FromFile(filePatch);
                txtAnexo.Text = filePatch;
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

        private void Incidente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }
    }
}
