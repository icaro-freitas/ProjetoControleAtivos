
namespace ControleAtivos
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabGerenciaAtivos = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabGerenciarSalas = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabComunicacaoSerial = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLeituraDados = new System.Windows.Forms.Label();
            this.txtRecepcaoDados = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblStatusComunicacao = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboPortaCOM = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPortaCom = new System.Windows.Forms.Label();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabGerenciaAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabGerenciarSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabComunicacaoSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Controls.Add(this.tabGerenciaAtivos);
            this.tabControl1.Controls.Add(this.tabGerenciarSalas);
            this.tabControl1.Controls.Add(this.tabComunicacaoSerial);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.comboBox1);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(1045, 666);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta Ativos";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // tabGerenciaAtivos
            // 
            this.tabGerenciaAtivos.Controls.Add(this.button4);
            this.tabGerenciaAtivos.Controls.Add(this.button3);
            this.tabGerenciaAtivos.Controls.Add(this.button2);
            this.tabGerenciaAtivos.Controls.Add(this.button1);
            this.tabGerenciaAtivos.Controls.Add(this.dataGridView1);
            this.tabGerenciaAtivos.Controls.Add(this.label7);
            this.tabGerenciaAtivos.Controls.Add(this.label6);
            this.tabGerenciaAtivos.Controls.Add(this.dateTimePicker2);
            this.tabGerenciaAtivos.Controls.Add(this.dateTimePicker1);
            this.tabGerenciaAtivos.Controls.Add(this.label5);
            this.tabGerenciaAtivos.Controls.Add(this.textBox4);
            this.tabGerenciaAtivos.Controls.Add(this.label4);
            this.tabGerenciaAtivos.Controls.Add(this.textBox3);
            this.tabGerenciaAtivos.Controls.Add(this.label3);
            this.tabGerenciaAtivos.Controls.Add(this.textBox2);
            this.tabGerenciaAtivos.Controls.Add(this.label2);
            this.tabGerenciaAtivos.Controls.Add(this.label1);
            this.tabGerenciaAtivos.Controls.Add(this.comboBox2);
            this.tabGerenciaAtivos.Controls.Add(this.textBox1);
            this.tabGerenciaAtivos.Location = new System.Drawing.Point(4, 22);
            this.tabGerenciaAtivos.Name = "tabGerenciaAtivos";
            this.tabGerenciaAtivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerenciaAtivos.Size = new System.Drawing.Size(1045, 666);
            this.tabGerenciaAtivos.TabIndex = 2;
            this.tabGerenciaAtivos.Text = "Gerenciar Ativos";
            this.tabGerenciaAtivos.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 141);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 19);
            this.button4.TabIndex = 18;
            this.button4.Text = "Visualizar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(710, 141);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 19);
            this.button3.TabIndex = 17;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 141);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 19);
            this.button2.TabIndex = 16;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 436);
            this.dataGridView1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Saída:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Entrada:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(600, 57);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código rfId:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(436, 57);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(107, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id rfId:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(307, 58);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de série:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 18);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(56, 57);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabGerenciarSalas
            // 
            this.tabGerenciarSalas.Controls.Add(this.button7);
            this.tabGerenciarSalas.Controls.Add(this.button8);
            this.tabGerenciarSalas.Controls.Add(this.button5);
            this.tabGerenciarSalas.Controls.Add(this.button6);
            this.tabGerenciarSalas.Controls.Add(this.dataGridView2);
            this.tabGerenciarSalas.Controls.Add(this.label9);
            this.tabGerenciarSalas.Controls.Add(this.textBox5);
            this.tabGerenciarSalas.Location = new System.Drawing.Point(4, 22);
            this.tabGerenciarSalas.Name = "tabGerenciarSalas";
            this.tabGerenciarSalas.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerenciarSalas.Size = new System.Drawing.Size(1045, 666);
            this.tabGerenciarSalas.TabIndex = 3;
            this.tabGerenciarSalas.Text = "Gerenciar Salas";
            this.tabGerenciarSalas.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(646, 93);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 19);
            this.button7.TabIndex = 27;
            this.button7.Text = "Excluir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(494, 93);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 19);
            this.button8.TabIndex = 26;
            this.button8.Text = "Editar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(184, 93);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 19);
            this.button5.TabIndex = 25;
            this.button5.Text = "Visualizar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(32, 93);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 19);
            this.button6.TabIndex = 24;
            this.button6.Text = "Cadastrar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 122);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1009, 471);
            this.dataGridView2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descrição:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 41);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(655, 20);
            this.textBox5.TabIndex = 19;
            // 
            // tabComunicacaoSerial
            // 
            this.tabComunicacaoSerial.Controls.Add(this.btnClear);
            this.tabComunicacaoSerial.Controls.Add(this.lblLeituraDados);
            this.tabComunicacaoSerial.Controls.Add(this.txtRecepcaoDados);
            this.tabComunicacaoSerial.Controls.Add(this.btnProcurar);
            this.tabComunicacaoSerial.Controls.Add(this.lblStatusComunicacao);
            this.tabComunicacaoSerial.Controls.Add(this.btnDesconectar);
            this.tabComunicacaoSerial.Controls.Add(this.btnConectar);
            this.tabComunicacaoSerial.Controls.Add(this.cboBaudRate);
            this.tabComunicacaoSerial.Controls.Add(this.cboPortaCOM);
            this.tabComunicacaoSerial.Controls.Add(this.lblBaudRate);
            this.tabComunicacaoSerial.Controls.Add(this.lblPortaCom);
            this.tabComunicacaoSerial.Controls.Add(this.lblConfiguracoes);
            this.tabComunicacaoSerial.Location = new System.Drawing.Point(4, 22);
            this.tabComunicacaoSerial.Name = "tabComunicacaoSerial";
            this.tabComunicacaoSerial.Padding = new System.Windows.Forms.Padding(3);
            this.tabComunicacaoSerial.Size = new System.Drawing.Size(1045, 666);
            this.tabComunicacaoSerial.TabIndex = 1;
            this.tabComunicacaoSerial.Text = "Comunicação Serial";
            this.tabComunicacaoSerial.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(470, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblLeituraDados
            // 
            this.lblLeituraDados.AutoSize = true;
            this.lblLeituraDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeituraDados.Location = new System.Drawing.Point(473, 17);
            this.lblLeituraDados.Name = "lblLeituraDados";
            this.lblLeituraDados.Size = new System.Drawing.Size(196, 31);
            this.lblLeituraDados.TabIndex = 10;
            this.lblLeituraDados.Text = "Leitura Dados";
            // 
            // txtRecepcaoDados
            // 
            this.txtRecepcaoDados.Enabled = false;
            this.txtRecepcaoDados.Location = new System.Drawing.Point(470, 71);
            this.txtRecepcaoDados.Multiline = true;
            this.txtRecepcaoDados.Name = "txtRecepcaoDados";
            this.txtRecepcaoDados.Size = new System.Drawing.Size(363, 176);
            this.txtRecepcaoDados.TabIndex = 9;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(333, 71);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 8;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // lblStatusComunicacao
            // 
            this.lblStatusComunicacao.AutoSize = true;
            this.lblStatusComunicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusComunicacao.ForeColor = System.Drawing.Color.Red;
            this.lblStatusComunicacao.Location = new System.Drawing.Point(22, 278);
            this.lblStatusComunicacao.Name = "lblStatusComunicacao";
            this.lblStatusComunicacao.Size = new System.Drawing.Size(185, 20);
            this.lblStatusComunicacao.TabIndex = 7;
            this.lblStatusComunicacao.Text = "ESP32 Desconectado";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(25, 216);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(176, 49);
            this.btnDesconectar.TabIndex = 6;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(25, 152);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(176, 49);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(193, 112);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cboBaudRate.TabIndex = 4;
            // 
            // cboPortaCOM
            // 
            this.cboPortaCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPortaCOM.FormattingEnabled = true;
            this.cboPortaCOM.Location = new System.Drawing.Point(193, 73);
            this.cboPortaCOM.Name = "cboPortaCOM";
            this.cboPortaCOM.Size = new System.Drawing.Size(121, 24);
            this.cboPortaCOM.TabIndex = 3;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.Location = new System.Drawing.Point(20, 103);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(141, 29);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // lblPortaCom
            // 
            this.lblPortaCom.AutoSize = true;
            this.lblPortaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortaCom.Location = new System.Drawing.Point(20, 65);
            this.lblPortaCom.Name = "lblPortaCom";
            this.lblPortaCom.Size = new System.Drawing.Size(148, 29);
            this.lblPortaCom.TabIndex = 1;
            this.lblPortaCom.Text = "Porta COM:";
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.Location = new System.Drawing.Point(20, 17);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(203, 31);
            this.lblConfiguracoes.TabIndex = 0;
            this.lblConfiguracoes.Text = "Configurações";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormularioPrincipal";
            this.Text = "Controles de Ativos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabGerenciaAtivos.ResumeLayout(false);
            this.tabGerenciaAtivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabGerenciarSalas.ResumeLayout(false);
            this.tabGerenciarSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabComunicacaoSerial.ResumeLayout(false);
            this.tabComunicacaoSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabComunicacaoSerial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Label lblPortaCom;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboPortaCOM;
        private System.Windows.Forms.Label lblStatusComunicacao;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TabPage tabGerenciaAtivos;
        private System.Windows.Forms.TabPage tabGerenciarSalas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblLeituraDados;
        private System.Windows.Forms.TextBox txtRecepcaoDados;
        private System.Windows.Forms.Button btnClear;
    }
}

