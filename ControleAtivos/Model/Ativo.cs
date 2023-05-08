using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ControleAtivos.Model
{
    class Ativo
    {
        private int id_ativo;
        private String descricao;
        private int id_sala;
        private int num_serie;
        private String rfid;
        private DateTime data_cadastro;        
        private Banco banco;

        public Ativo()
        {
            banco = new Banco();
        }

        public Ativo(int id_ativo, string descricao, int id_sala, int num_serie, string rfid, DateTime data_cadastro)
        {
            this.id_ativo = id_ativo;
            this.descricao = descricao;
            this.id_sala = id_sala;
            this.num_serie = num_serie;
            this.rfid = rfid;
            this.data_cadastro = data_cadastro;
            banco = new Banco();
        }

        public int Id_ativo
        {
            get { return id_ativo; }   
            set { id_ativo = value; }  
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Id_sala
        {
            get { return id_sala; }
            set { id_sala = value; }
        }

        public int Num_serie
        {
            get { return num_serie; }
            set { num_serie = value; }
        }

        public String Rfid
        {
            get { return rfid; }
            set { rfid = value; }
        }

        public DateTime Data_cadastro
        {
            get { return data_cadastro; }
            set { data_cadastro = value; }
        }
       
        public void Save()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();            

            command.CommandText = "INSERT INTO ativos(descricao,id_sala,num_serie,rfid,data_cadastro) VALUES(@1,@2,@3,@4,@5)";
            command.Parameters.Add("@1",MySqlDbType.VarChar,50).Value = Descricao;
            command.Parameters.Add("@2",MySqlDbType.Int32).Value =  Id_sala;
            command.Parameters.Add("@3", MySqlDbType.Int32).Value = Num_serie;
            command.Parameters.Add("@4", MySqlDbType.VarChar, 20).Value = Rfid;
            command.Parameters.Add("@5", MySqlDbType.DateTime).Value = Data_cadastro;           
            //Checar insercao de datas no banco de dados.
            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public void Update()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();

            command.CommandText = "UPDATE ativos SET descricao = @1," +
                " id_sala = @2, " +
                "num_serie = @3," +
                "rfid = @4," +
                "data_ent = @5," +
                "data_saida = @6 WHERE sala.id_sala = @7";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 50).Value = Descricao;
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = Id_sala;
            command.Parameters.Add("@3", MySqlDbType.Int32).Value = Num_serie;
            command.Parameters.Add("@4", MySqlDbType.VarChar, 10).Value = Rfid;
            command.Parameters.Add("@5", MySqlDbType.Date).Value = Data_ent;
            command.Parameters.Add("@6", MySqlDbType.Date).Value = Data_saida;
            command.Parameters.Add("@7", MySqlDbType.Int32).Value = Id_ativo;

            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public void Delete()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();

            command.CommandText = "DELETE FROM ativos WHERE ativos.id_ativo = @1";
            command.Parameters.Add("@1", MySqlDbType.Int32).Value = Id_ativo;

            
            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public Ativo GetByDesc()
        {

            MySqlCommand command = this.banco.Connection.CreateCommand();
            MySqlDataReader reader;

            command.CommandText = "SELECT * FROM ativos WHERE ativos.descricao = @1";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 50).Value = Descricao;

            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            reader = command.ExecuteReader();
            this.Id_ativo = reader.GetInt32("id_ativo");            
            this.Descricao = reader.GetString("descricao");
            this.Id_sala = reader.GetInt32("id_sala");
            this.Num_serie = reader.GetInt32("num_serie");
            this.Rfid = reader.GetString("rfid");
            this.Data_ent = reader.GetDateTime("data_ent");
            this.Data_saida = reader.GetDateTime("data_saida");

            banco.Connection.Close();
            return this;

        }

        public List<Ativo> GetAll()
        {

            MySqlCommand command = this.banco.Connection.CreateCommand();
            MySqlDataReader reader;

            command.CommandText = "SELECT * FROM ativos";

            banco.Connection.Open();
            reader = command.ExecuteReader();

            List<Ativo> ativos = new List<Ativo>();

            while (reader.Read())
            {
                //bool isEmpty = Leitor.HasRows;
                Ativo ativo = new Ativo();
                ativo.Id_ativo = reader.GetInt32("id_ativo");
                ativo.Descricao = reader.GetString("descricao");
                ativo.Id_sala = reader.GetInt32("id_sala");
                ativo.Num_serie = reader.GetInt32("num_serie");
                ativo.Rfid = reader.GetString("rfid");
                ativo.Data_ent = reader.GetDateTime("data_ent");
                ativo.Data_saida = reader.GetDateTime("data_saida");
                ativos.Add(ativo);
            }

            banco.Connection.Close();
            return ativos;

        }


    }
}
