using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAtivos.Model
{
    class RFIDSala
    {
        private String sala;
        private String rfid;

        public RFIDSala()
        {

        }

        public RFIDSala( string sala, string rfid)
        {
            Sala = sala;
            Rfid = rfid;            
        }

        public String Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public String Rfid
        {
            get { return rfid; }
            set { rfid = value; }
        }
    }
}
