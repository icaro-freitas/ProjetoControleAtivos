using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ControleAtivos.Model
{

    class AtivoSala
    {
        private Ativo ativo;
        private Sala sala;
        private DateTime data_movimentacao;
        private Banco banco;

        public AtivoSala()
        {
            banco = new Banco();
        }

        public AtivoSala(Ativo ativo, Sala sala, DateTime data_movimentacao, Banco banco)
        {
            this.ativo = ativo;
            this.sala = sala;
            this.data_movimentacao = data_movimentacao;
            this.banco = banco;
        }

        public Sala Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public Ativo Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public DateTime Data_movimentacao
        {
            get { return data_movimentacao; }
            set { data_movimentacao = value; }
        }

        public bool CheckByRFIDIfItHasRelation()
        {

            MySqlCommand command = this.banco.Connection.CreateCommand();
            MySqlDataReader reader;

            command.CommandText = "SELECT EXISTS(SELECT 1 FROM ativo_sala INNER JOIN ativos ON ativo_sala.id_ativo = ativos.id_ativo WHERE ativos.rfid =@1 LIMIT 1) as count";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 20).Value = ativo.Rfid;

            banco.Connection.Open();
            reader = command.ExecuteReader();

            int quantity = 0;
            if (reader.Read())
            {
                quantity = reader.GetInt32("count");
            }

            banco.Connection.Close();

            return quantity > 0;

        }

        public void DeleteRelation()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();

            command.CommandText = "DELETE FROM Ativo_sala WHERE id_ativo = (SELECT id_ativo FROM Ativos WHERE rfid = @1)";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 20).Value = ativo.Rfid;


            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public void SaveRelation()
        {
            MySqlCommand command = this.banco.Connection.CreateCommand();

            command.CommandText = "INSERT INTO Ativo_sala (id_sala, id_ativo, data_movimentacao) VALUES ((SELECT id_sala FROM Sala WHERE nome = @1), (SELECT id_ativo FROM Ativos WHERE rfid = @2), NOW())";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 50).Value = sala.Nome;
            command.Parameters.Add("@2", MySqlDbType.VarChar, 20).Value = ativo.Rfid;


            //int quantidadeTuplasAfetadas =  command.ExecuteNonQuery();
            banco.Connection.Open();
            command.ExecuteNonQuery();
            banco.Connection.Close();

        }

        public List<AtivoSala> GetAll()
        {

            MySqlCommand command = this.banco.Connection.CreateCommand();
            MySqlDataReader reader;

            command.CommandText = "SELECT A.descricao, A.num_serie, A.rfid, A.data_cadastro, A_S.data_movimentacao FROM Ativos A INNER JOIN Ativo_sala A_S ON A.id_ativo = A_S.id_ativo WHERE A_S.id_sala = (select id_sala FROM sala WHERE nome = @1)";
            command.Parameters.Add("@1", MySqlDbType.VarChar, 50).Value = sala.Nome;

            banco.Connection.Open();
            reader = command.ExecuteReader();

            List<AtivoSala> ativosSala = new List<AtivoSala>();

            while (reader.Read())
            {
                //bool isEmpty = Leitor.HasRows;
                AtivoSala ativoSala = new AtivoSala();

                Ativo ativo = new Ativo();            
                ativo.Descricao = reader.GetString("descricao");
                ativo.Num_serie = reader.GetString("num_serie");
                ativo.Rfid = reader.GetString("rfid");
                ativo.Data_cadastro = reader.GetDateTime("data_cadastro");

                ativoSala.Data_movimentacao = reader.GetDateTime("data_movimentacao");
                ativoSala.Ativo = ativo;
                ativoSala.Sala = this.sala;
                

                ativosSala.Add(ativoSala);
            }

            banco.Connection.Close();
            return ativosSala;

        }

        public List<AtivoSala> GetHistorico()
        {

            MySqlCommand command = this.banco.Connection.CreateCommand();
            MySqlDataReader reader;

            command.CommandText = "SELECT S.nome, A.descricao, A.num_serie, A.rfid, A.data_cadastro, H.data_movimentacao FROM Ativos A INNER JOIN historico H ON A.id_ativo = H.id_ativo INNER JOIN sala S ON S.id_sala = H.id_sala_antiga";
            
            banco.Connection.Open();
            reader = command.ExecuteReader();

            List<AtivoSala> ativosSala = new List<AtivoSala>();

            while (reader.Read())
            {
                //bool isEmpty = Leitor.HasRows;
                AtivoSala ativoSala = new AtivoSala();

                Ativo ativo = new Ativo();
                ativo.Descricao = reader.GetString("descricao");
                ativo.Num_serie = reader.GetString("num_serie");
                ativo.Rfid = reader.GetString("rfid");
                ativo.Data_cadastro = reader.GetDateTime("data_cadastro");

                ativoSala.Data_movimentacao = reader.GetDateTime("data_movimentacao");
                ativoSala.Ativo = ativo;

                Sala sala = new Sala();
                sala.Nome = reader.GetString("nome");
                ativoSala.Sala = sala;

                ativosSala.Add(ativoSala);
            }

            banco.Connection.Close();
            return ativosSala;

        }

    }
}
