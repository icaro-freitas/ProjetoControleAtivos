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

        public Ativo(int id_ativo, string descricao,  int num_serie, string rfid, DateTime data_cadastro)
        {
            this.id_ativo = id_ativo;
            this.descricao = descricao;            
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

            command.CommandText = "INSERT INTO ativos(descricao,num_serie,rfid,data_cadastro) VALUES(@1,@2,@3,@4)";
            command.Parameters.Add("@1",MySqlDbType.VarChar,50).Value = Descricao;            
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
                "num_serie = @2," +
                "rfid = @3," +                
                "data_saida = @4 WHERE ativos.id_sala = @5";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 50).Value = Descricao;            
            command.Parameters.Add("@2", MySqlDbType.Int32).Value = Num_serie;
            command.Parameters.Add("@3", MySqlDbType.VarChar, 10).Value = Rfid;
            command.Parameters.Add("@4", MySqlDbType.DateTime).Value = Data_cadastro;            
            command.Parameters.Add("@5", MySqlDbType.Int32).Value = Id_ativo;

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
            this.Num_serie = reader.GetInt32("num_serie");
            this.Rfid = reader.GetString("rfid");
            this.Data_cadastro = reader.GetDateTime("data_cadastro");          

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
                ativo.Num_serie = reader.GetInt32("num_serie");
                ativo.Rfid = reader.GetString("rfid");
                ativo.Data_cadastro = reader.GetDateTime("data_cadastro");               
                ativos.Add(ativo);
            }

            banco.Connection.Close();
            return ativos;

        }


    }
}
