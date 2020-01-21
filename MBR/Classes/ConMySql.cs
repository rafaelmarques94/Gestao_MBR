using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    class ConMySql
    {
       
        private MySqlConnection conexao;
        private MySqlDataAdapter mAdapter;


        public void concrud()
        {
            

        }

        public void executa(String _query)
        {
            conexao = new MySqlConnection("Persist Security Info=False; server=fdb24.awardspace.net; database=3263913_viabela; uid =3263913_viabela; password =r14011994");
            conexao.Open();
            MySqlCommand command = new MySqlCommand(_query, conexao);
            command.ExecuteNonQuery();
            conexao.Close();
        }



        public void ligar ()
        {
            conexao = new MySqlConnection("Persist Security Info=False; server=localhost;database=crud;uid=root");
            conexao.Open();
        }


        public void desligar()
        {
              conexao.Close();
        }

    }

 
}
