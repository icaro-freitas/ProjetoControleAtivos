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
            command.Parameters.Add("@1",MySqlDbType.VarChar,50).Value = Descricao;
            
            //Checar insercao de datas no banco de dados.
            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public void  Update()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();

            command.CommandText = "UPDATE sala SET descricao = @1 WHERE sala.id_sala = @2";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 50).Value =Descricao;
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = Id_sala;

           
            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public void Delete()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();

            command.CommandText = "DELETE FROM sala WHERE sala.id_sala = @1";
            command.Parameters.Add("@1", MySqlDbType.Int32).Value = Id_sala;


            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public Sala GetByDesc() {

            MySqlCommand command = this.banco.Connection.CreateCommand();
            MySqlDataReader reader;

            command.CommandText = "SELECT * FROM sala WHERE sala.descricao = @1";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 50).Value = Descricao;

            banco.Connection.Open();
            reader = command.ExecuteReader();
            this.Id_sala = reader.GetInt32("id_sala");
            this.Descricao = reader.GetString("descricao");           

            banco.Connection.Close();
            return this;

        }

        public List<Sala> GetAll()
        {

            MySqlCommand command = this.banco.Connection.CreateCommand();
            MySqlDataReader reader;

            command.CommandText = "SELECT * FROM sala";           
            
            banco.Connection.Open();
            reader = command.ExecuteReader();

            List<Sala> salas = new List<Sala>();

            while (reader.Read())
            {
                //bool isEmpty = Leitor.HasRows;
                Sala sala = new Sala();
                sala.Id_sala = reader.GetInt32("id_sala");
                sala.Descricao = reader.GetString("descricao");
                salas.Add(sala);
            } 

            banco.Connection.Close();
            return salas;

        }


    }
}
