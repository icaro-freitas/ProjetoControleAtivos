﻿using System;
using MySql.Data.MySqlClient;

namespace ControleAtivos.Model
{
    class Banco
    {
        private const String myConString = "SERVER=localhost;DATABASE=ativos1;UID=root;PASSWORD=12345678";
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
