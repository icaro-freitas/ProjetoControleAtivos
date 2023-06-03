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
using ControleAtivos.Model;

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

            try
            {
                if (serialPort1.IsOpen) serialPort1.Close();
                else
                {
                    serialPort1.PortName = cboPortaCOM.Text;
                    serialPort1.BaudRate = int.Parse(cboBaudRate.Text);
                }
                serialPort1.Open();
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                cboPortaCOM.Enabled = false;
                cboBaudRate.Enabled = false;
                btnProcurar.Enabled = false;
                lblStatusComunicacao.Text = "A PORTA ESTÁ ABERTA";
                lblStatusComunicacao.ForeColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("ERRO NA INSERÇÃO DOS PARÂMETROS");
                btnConectar.Enabled = true;
                btnDesconectar.Enabled = false;
                cboPortaCOM.Enabled = true;
                cboBaudRate.Enabled = true;
                btnProcurar.Enabled = true;
                //lblStatusComunicacao.Text = "A PORTA ESTÁ ABERTA";
                //lblStatusComunicacao.ForeColor = Color.Green;
            }



        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            ScanCOMPort();
            cboBaudRate.SelectedIndex = 9;
        }

        private void ScanCOMPort()
        {
            cboPortaCOM.Items.Clear();
            foreach (string portas in SerialPort.GetPortNames())
            {
                cboPortaCOM.Items.Add(portas);
            }
            try
            {
                cboPortaCOM.SelectedIndex = 0;
            }
            catch (Exception e)
            {

            }
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            ScanCOMPort();
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnConectar.Enabled = true;
                btnDesconectar.Enabled = false;
                cboPortaCOM.Enabled = true;
                cboBaudRate.Enabled = true;
                btnProcurar.Enabled = true;
                lblStatusComunicacao.Text = "A PORTA ESTÁ FECHADA";
                lblStatusComunicacao.ForeColor = Color.Red;
            }
            catch
            {
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                cboPortaCOM.Enabled = false;
                cboBaudRate.Enabled = false;
                btnProcurar.Enabled = false;
                lblStatusComunicacao.Text = "A PORTA ESTÁ ABERTA";
                lblStatusComunicacao.ForeColor = Color.Green;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(ReceberDados));

        }

        private void ReceberDados(object sender, EventArgs e)
        {

            txtRecepcaoDados.Text += serialPort1.ReadExisting();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtRecepcaoDados.Text = "";
        }

        private void BtnCadastrarSala_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDescricaoSala.Text) && !String.IsNullOrEmpty(txtNomeSala.Text))
            {
                Sala sala = new Sala();
                sala.Descricao = txtDescricaoSala.Text;
                sala.Nome = txtNomeSala.Text;
                if (sala.Save())
                {
                    MessageBox.Show("Sala cadastrada com sucesso!", "Cadastro da sala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha no cadastro!", "Cadastro da sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nome da sala vazio!", "Cadastro da sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void lblDataSaidaAtivo_Click(object sender, EventArgs e)
        {

        }
    }
}
