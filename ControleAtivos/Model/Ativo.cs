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
        private int id_ativos;
        private String descricao;
        private int id_sala;
        private int num_serie;
        private String rfid;
        private DateTime data_ent;
        private DateTime data_saida;
        private Banco banco;

        public Ativo()
        {
            banco = new Banco();
        }

        public Ativo(int id_ativos, string descricao, int id_sala, int num_serie, string rfid, DateTime data_ent, DateTime data_saida)
        {
            this.id_ativos = id_ativos;
            this.descricao = descricao;
            this.id_sala = id_sala;
            this.num_serie = num_serie;
            this.rfid = rfid;
            this.data_ent = data_ent;
            this.data_saida = data_saida;
            banco = new Banco();
        }

        public int Id_ativos  
        {
            get { return id_ativos; }   
            set { id_ativos = value; }  
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

        public DateTime Data_ent
        {
            get { return data_ent; }
            set { data_ent = value; }
        }

        public DateTime Data_saida
        {
            get { return data_saida; }
            set { data_saida = value; }
        }

        public void Save()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();            

            command.CommandText = "INSERT INTO ativos(descricao,id_sala,num_serie,rfid,data_ent,data_saida) VALUES(@1,@2,@3,@4,@5,@6)";
            command.Parameters.AddWithValue("@1",Descricao);
            command.Parameters.AddWithValue("@2", Id_sala);
            command.Parameters.AddWithValue("@3", Num_serie);
            command.Parameters.AddWithValue("@4", Rfid);
            command.Parameters.AddWithValue("@5", Data_ent);
            command.Parameters.AddWithValue("@6", Data_saida);
            //Checar insercao de datas no banco de dados.
            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

    }
}
