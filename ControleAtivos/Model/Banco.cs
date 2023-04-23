using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControleAtivos.Model
{
    class Banco
    {
        private const String myConString = "SERVER=localhost;DATABASE=Ativos;UID=root;PASSWORD=12345678";
        private readonly MySqlConnection connection;

        public Banco()
        {
            connection = new MySqlConnection(myConString);                      
        }

        public MySqlConnection Connection
        {
            get { return connection; }           
        }

        
    }
}
