using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ControleAtivos
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

               

        private void BtnConectar_Click(object sender, EventArgs e)
        {

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            PortaCom();
        }

        private void PortaCom()
        {
            cboPortaCOM.Items.Clear();
            foreach(string portas in SerialPort.GetPortNames())
            {
                cboPortaCOM.Items.Add(portas);
            }
            try {
                cboPortaCOM.SelectedIndex = 0;
            }
            catch(Exception e)
            {
                
            }            
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            PortaCom();
        }
    }
}
