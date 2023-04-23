using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControleAtivos.Model
{
    class Sala
    {
        private int id_sala;
        private String descricao;
        private Banco banco;

        public Sala()
        {
            banco = new Banco();
        }

        public Sala(int id_sala, string descricao)
        {
            this.id_sala = id_sala;
            this.descricao = descricao;
            banco = new Banco();
        }

        public int Id_sala
        {
            get { return id_sala; }
            set { id_sala = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public void Save()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();

            command.CommandText = "INSERT INTO sala(descricao) VALUES(@1)";
            command.Parameters.AddWithValue("@1", Descricao);
            
            //Checar insercao de datas no banco de dados.
            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }
        
    }
}
