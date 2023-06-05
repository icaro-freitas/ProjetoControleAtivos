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
using System.Web;
using Newtonsoft.Json;

namespace ControleAtivos
{

    public partial class FormularioPrincipal : Form
    {
        private List<Sala> salas;
        private List<Ativo> ativos;
        private List<AtivoSala>  ativosSala;
        private List<AtivoSala> historico;

        private void LoadSalas()
        {
            cboConsultaSalas.Items.Clear();
            dataGridViewSalas.Rows.Clear();
            Sala pegarSalas = new Sala();
            this.salas = pegarSalas.GetAll();
            foreach (Sala sala in salas)
            {
                dataGridViewSalas.Rows.Add(sala.Nome, sala.Descricao);
                cboConsultaSalas.Items.Add(sala.Nome);
            }
            try
            {
                cboConsultaSalas.SelectedIndex = 0;
            }
            catch (Exception e)
            {

            }
        }

        private void LoadAtivos()
        {
            
            dataGridViewAtivos.Rows.Clear();
            Ativo pegarAtivos = new Ativo();
            this.ativos = pegarAtivos.GetAll();
            foreach (Ativo ativo in ativos)
            {
                dataGridViewAtivos.Rows.Add(ativo.Descricao, ativo.Num_serie, ativo.Rfid, ativo.Data_cadastro.ToString("dd/MM/yyyy HH:mm:ss"));
            }

        }

        private void LoadAtivosSala()
        {

            dataGridViewAtivosSala.Rows.Clear();
            AtivoSala pegarAtivosSala = new AtivoSala();
            Sala sala = new Sala();
            sala.Nome = cboConsultaSalas.Text;
            pegarAtivosSala.Sala = sala;
            this.ativosSala = pegarAtivosSala.GetAll();
            foreach (AtivoSala ativoSala in ativosSala)
            {
                dataGridViewAtivosSala.Rows.Add(ativoSala.Ativo.Descricao, ativoSala.Ativo.Num_serie, ativoSala.Ativo.Rfid, ativoSala.Ativo.Data_cadastro.ToString("dd/MM/yyyy HH:mm:ss"), ativoSala.Data_movimentacao.ToString("dd/MM/yyyy HH:mm:ss"));
            }

        }

        private void LoadHistorico()
        {

            dataGridViewHistorico.Rows.Clear();
            AtivoSala pegarAtivosSala = new AtivoSala();             
            this.historico = pegarAtivosSala.GetHistorico();
            foreach (AtivoSala ativoSala in this.historico)
            {
                dataGridViewHistorico.Rows.Add(ativoSala.Sala.Nome,ativoSala.Ativo.Descricao, ativoSala.Ativo.Num_serie, ativoSala.Ativo.Rfid, ativoSala.Ativo.Data_cadastro.ToString("dd/MM/yyyy HH:mm:ss"), ativoSala.Data_movimentacao.ToString("dd/MM/yyyy HH:mm:ss"));
            }

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
            LoadSalas();
            LoadAtivos();
            LoadAtivosSala();
            LoadHistorico();
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

        private void ButtonAtualizarSala_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtDescricaoSala.Text) && !String.IsNullOrEmpty(txtNomeSala.Text))
            {
                Int32 selectedRowCount = dataGridViewSalas.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount <= 1)
                    {

                        int index = dataGridViewSalas.SelectedRows[0].Index;
                        Sala sala = salas[index];
                        sala.Descricao = txtDescricaoSala.Text;
                        sala.Nome = txtNomeSala.Text;
                        if (sala.Update())
                        {
                            MessageBox.Show("Sala atualizada com sucesso!", "Atualizar sala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSalas();
                        }
                        else
                        {
                            MessageBox.Show("Falha na atualização!", "Atualizar sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mais de uma linha selecionada", "Atualizar sala");
                    }
                }
            }
            else
            {
                MessageBox.Show("Campos da sala vazios!", "Atualizar sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ButtonDeletarSala_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = dataGridViewSalas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (selectedRowCount <= 1)
                {
                    DialogResult result = MessageBox.Show("Você deseja realmente deletar o dado?", "Deletar sala", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int index = dataGridViewSalas.SelectedRows[0].Index;
                        Sala sala = salas[index];

                        if (sala.Delete())
                        {
                            MessageBox.Show("Sala deletada com sucesso!", "Deletar sala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSalas();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao deletar!", "Deletar sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Mais de uma linha selecionada", "Deletar sala");
                }
            }

        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(ReceberDados));
        }

        private void ReceberDados(object sender, EventArgs e)
        {
            String data = serialPort1.ReadLine();

            txtRecepcaoDados.Text += data;

            RFIDSala rfidSala = JsonConvert.DeserializeObject<RFIDSala>(data);
            String rfid = rfidSala.Rfid;
            String nomeSala = rfidSala.Sala;
            txtCodigoRfId.Text = rfid;

            Ativo ativo = new Ativo();
            ativo.Rfid = rfid;
            
            if (ativo.CheckByRFIDIfExists())
            {
                Sala sala = new Sala();
                sala.Nome = nomeSala;
                AtivoSala ativoSala = new AtivoSala();
                ativoSala.Ativo = ativo;
                ativoSala.Sala = sala;

                if (ativoSala.CheckByRFIDIfItHasRelation()) {
                    ativoSala.DeleteRelation();
                    LoadAtivosSala();
                    LoadHistorico();
                } else
                {
                    ativoSala.SaveRelation();
                    LoadAtivosSala();
                }               
            } 

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
                    LoadSalas();
                }
                else
                {
                    MessageBox.Show("Falha no cadastro!", "Cadastro da sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campos da sala vazios!", "Cadastro da sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCarregarSalas_Click(object sender, EventArgs e)
        {
            LoadSalas();
        }

        private void dataGridViewSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCadastroAtivos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigoRfId.Text) && !String.IsNullOrEmpty(txtDescricaoAtivo.Text) && !String.IsNullOrEmpty(txtNumeroSerieAtivo.Text))
            {
                Ativo ativo = new Ativo();
                ativo.Descricao = txtDescricaoAtivo.Text;
                ativo.Num_serie = txtNumeroSerieAtivo.Text;
                ativo.Rfid = txtCodigoRfId.Text;

                if (ativo.Save())
                {
                    MessageBox.Show("Ativo cadastrado com sucesso!", "Cadastro do ativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAtivos();
                }
                else
                {
                    MessageBox.Show("Falha no cadastro!", "Cadastro do ativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campos do ativo vazios!", "Cadastro do ativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewAtivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCarregarAtivos_Click(object sender, EventArgs e)
        {
            LoadAtivos();
        }

        private void BtnAtualizarAtivos_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigoRfId.Text) && !String.IsNullOrEmpty(txtDescricaoAtivo.Text) && !String.IsNullOrEmpty(txtNumeroSerieAtivo.Text))
            {
                Int32 selectedRowCount = dataGridViewAtivos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    if (selectedRowCount <= 1)
                    {

                        int index = dataGridViewAtivos.SelectedRows[0].Index;
                        Ativo ativo = ativos[index];
                        ativo.Descricao = txtDescricaoAtivo.Text;
                        ativo.Num_serie = txtNumeroSerieAtivo.Text;
                        ativo.Rfid = txtCodigoRfId.Text;
                        if (ativo.Update())
                        {
                            MessageBox.Show("Ativo atualizado com sucesso!", "Atualizar Ativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAtivos();
                        }
                        else
                        {
                            MessageBox.Show("Falha na atualização!", "Atualizar Ativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mais de uma linha selecionada", "Atualizar Ativo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Campos do ativo vazios!", "Atualizar Ativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExcluirAtivos_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridViewAtivos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (selectedRowCount <= 1)
                {
                    DialogResult result = MessageBox.Show("Você deseja realmente deletar o dado?", "Deletar ativo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int index = dataGridViewAtivos.SelectedRows[0].Index;
                        Ativo ativo = ativos[index];

                        if (ativo.Delete())
                        {
                            MessageBox.Show("Ativo deletado com sucesso!", "Deletar ativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAtivos();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao deletar!", "Deletar ativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Mais de uma linha selecionada", "Deletar ativo");
                }
            }

        }

        private void btnCarregarHistorico_Click(object sender, EventArgs e)
        {
            LoadHistorico();
        }

        private void cboConsultaSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAtivosSala();
        }
    }
}
