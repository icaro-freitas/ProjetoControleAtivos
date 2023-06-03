using System;

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





    }
}
