
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
            this.comboBoxConsultaSalas = new System.Windows.Forms.ComboBox();
            this.tabGerenciaAtivos = new System.Windows.Forms.TabPage();
            this.btnVizualizarAtivos = new System.Windows.Forms.Button();
            this.btnExcluirAtivos = new System.Windows.Forms.Button();
            this.btnAtualizarAtivos = new System.Windows.Forms.Button();
            this.btnCadastroAtivos = new System.Windows.Forms.Button();
            this.dataGridViewAtivos = new System.Windows.Forms.DataGridView();
            this.lblDataModificacao = new System.Windows.Forms.Label();
            this.dateTimePickerDataModificacao = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoRfId = new System.Windows.Forms.Label();
            this.txtCodigoRfId = new System.Windows.Forms.TextBox();
            this.lblNumeroSerieAtivo = new System.Windows.Forms.Label();
            this.txtNumeroSerieAtivo = new System.Windows.Forms.TextBox();
            this.lblGerenciarAtivosSalas = new System.Windows.Forms.Label();
            this.lblDescricaoAtivo = new System.Windows.Forms.Label();
            this.comboBoxGerenciarAtivosSalas = new System.Windows.Forms.ComboBox();
            this.txtDescricaoAtivo = new System.Windows.Forms.TextBox();
            this.tabGerenciarSalas = new System.Windows.Forms.TabPage();
            this.btnExcluirSala = new System.Windows.Forms.Button();
            this.btnAtualizarSala = new System.Windows.Forms.Button();
            this.btnVizualizarSala = new System.Windows.Forms.Button();
            this.btnCadastrarSala = new System.Windows.Forms.Button();
            this.dataGridViewSalas = new System.Windows.Forms.DataGridView();
            this.lblDescricaoSala = new System.Windows.Forms.Label();
            this.txtDescricaoSala = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtivos)).BeginInit();
            this.tabGerenciarSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).BeginInit();
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
            this.tabConsulta.Controls.Add(this.comboBoxConsultaSalas);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(1045, 666);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta Ativos";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // comboBoxConsultaSalas
            // 
            this.comboBoxConsultaSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConsultaSalas.FormattingEnabled = true;
            this.comboBoxConsultaSalas.Location = new System.Drawing.Point(6, 6);
            this.comboBoxConsultaSalas.Name = "comboBoxConsultaSalas";
            this.comboBoxConsultaSalas.Size = new System.Drawing.Size(121, 24);
            this.comboBoxConsultaSalas.TabIndex = 0;
            // 
            // tabGerenciaAtivos
            // 
            this.tabGerenciaAtivos.Controls.Add(this.btnVizualizarAtivos);
            this.tabGerenciaAtivos.Controls.Add(this.btnExcluirAtivos);
            this.tabGerenciaAtivos.Controls.Add(this.btnAtualizarAtivos);
            this.tabGerenciaAtivos.Controls.Add(this.btnCadastroAtivos);
            this.tabGerenciaAtivos.Controls.Add(this.dataGridViewAtivos);
            this.tabGerenciaAtivos.Controls.Add(this.lblDataModificacao);
            this.tabGerenciaAtivos.Controls.Add(this.dateTimePickerDataModificacao);
            this.tabGerenciaAtivos.Controls.Add(this.lblCodigoRfId);
            this.tabGerenciaAtivos.Controls.Add(this.txtCodigoRfId);
            this.tabGerenciaAtivos.Controls.Add(this.lblNumeroSerieAtivo);
            this.tabGerenciaAtivos.Controls.Add(this.txtNumeroSerieAtivo);
            this.tabGerenciaAtivos.Controls.Add(this.lblGerenciarAtivosSalas);
            this.tabGerenciaAtivos.Controls.Add(this.lblDescricaoAtivo);
            this.tabGerenciaAtivos.Controls.Add(this.comboBoxGerenciarAtivosSalas);
            this.tabGerenciaAtivos.Controls.Add(this.txtDescricaoAtivo);
            this.tabGerenciaAtivos.Location = new System.Drawing.Point(4, 22);
            this.tabGerenciaAtivos.Name = "tabGerenciaAtivos";
            this.tabGerenciaAtivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerenciaAtivos.Size = new System.Drawing.Size(1045, 666);
            this.tabGerenciaAtivos.TabIndex = 2;
            this.tabGerenciaAtivos.Text = "Gerenciar Ativos";
            this.tabGerenciaAtivos.UseVisualStyleBackColor = true;
            // 
            // btnVizualizarAtivos
            // 
            this.btnVizualizarAtivos.Location = new System.Drawing.Point(191, 141);
            this.btnVizualizarAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVizualizarAtivos.Name = "btnVizualizarAtivos";
            this.btnVizualizarAtivos.Size = new System.Drawing.Size(93, 19);
            this.btnVizualizarAtivos.TabIndex = 18;
            this.btnVizualizarAtivos.Text = "Visualizar";
            this.btnVizualizarAtivos.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAtivos
            // 
            this.btnExcluirAtivos.Location = new System.Drawing.Point(710, 141);
            this.btnExcluirAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirAtivos.Name = "btnExcluirAtivos";
            this.btnExcluirAtivos.Size = new System.Drawing.Size(106, 19);
            this.btnExcluirAtivos.TabIndex = 17;
            this.btnExcluirAtivos.Text = "Excluir";
            this.btnExcluirAtivos.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarAtivos
            // 
            this.btnAtualizarAtivos.Location = new System.Drawing.Point(548, 141);
            this.btnAtualizarAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizarAtivos.Name = "btnAtualizarAtivos";
            this.btnAtualizarAtivos.Size = new System.Drawing.Size(93, 19);
            this.btnAtualizarAtivos.TabIndex = 16;
            this.btnAtualizarAtivos.Text = "Atualizar";
            this.btnAtualizarAtivos.UseVisualStyleBackColor = true;
            // 
            // btnCadastroAtivos
            // 
            this.btnCadastroAtivos.Location = new System.Drawing.Point(39, 141);
            this.btnCadastroAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastroAtivos.Name = "btnCadastroAtivos";
            this.btnCadastroAtivos.Size = new System.Drawing.Size(89, 19);
            this.btnCadastroAtivos.TabIndex = 15;
            this.btnCadastroAtivos.Text = "Cadastrar";
            this.btnCadastroAtivos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAtivos
            // 
            this.dataGridViewAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtivos.Location = new System.Drawing.Point(16, 171);
            this.dataGridViewAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAtivos.Name = "dataGridViewAtivos";
            this.dataGridViewAtivos.RowHeadersWidth = 51;
            this.dataGridViewAtivos.RowTemplate.Height = 24;
            this.dataGridViewAtivos.Size = new System.Drawing.Size(1009, 436);
            this.dataGridViewAtivos.TabIndex = 14;
            // 
            // lblDataModificacao
            // 
            this.lblDataModificacao.AutoSize = true;
            this.lblDataModificacao.Location = new System.Drawing.Point(563, 59);
            this.lblDataModificacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataModificacao.Name = "lblDataModificacao";
            this.lblDataModificacao.Size = new System.Drawing.Size(121, 13);
            this.lblDataModificacao.TabIndex = 13;
            this.lblDataModificacao.Text = "Data de Movimentação:";
            this.lblDataModificacao.Click += new System.EventHandler(this.lblDataSaidaAtivo_Click);
            // 
            // dateTimePickerDataModificacao
            // 
            this.dateTimePickerDataModificacao.Location = new System.Drawing.Point(688, 54);
            this.dateTimePickerDataModificacao.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDataModificacao.Name = "dateTimePickerDataModificacao";
            this.dateTimePickerDataModificacao.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDataModificacao.TabIndex = 11;
            this.dateTimePickerDataModificacao.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblCodigoRfId
            // 
            this.lblCodigoRfId.AutoSize = true;
            this.lblCodigoRfId.Location = new System.Drawing.Point(348, 59);
            this.lblCodigoRfId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoRfId.Name = "lblCodigoRfId";
            this.lblCodigoRfId.Size = new System.Drawing.Size(61, 13);
            this.lblCodigoRfId.TabIndex = 9;
            this.lblCodigoRfId.Text = "Código rfId:";
            // 
            // txtCodigoRfId
            // 
            this.txtCodigoRfId.Location = new System.Drawing.Point(409, 57);
            this.txtCodigoRfId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoRfId.Name = "txtCodigoRfId";
            this.txtCodigoRfId.Size = new System.Drawing.Size(107, 20);
            this.txtCodigoRfId.TabIndex = 8;
            // 
            // lblNumeroSerieAtivo
            // 
            this.lblNumeroSerieAtivo.AutoSize = true;
            this.lblNumeroSerieAtivo.Location = new System.Drawing.Point(264, 20);
            this.lblNumeroSerieAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroSerieAtivo.Name = "lblNumeroSerieAtivo";
            this.lblNumeroSerieAtivo.Size = new System.Drawing.Size(87, 13);
            this.lblNumeroSerieAtivo.TabIndex = 5;
            this.lblNumeroSerieAtivo.Text = "Número de série:";
            this.lblNumeroSerieAtivo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNumeroSerieAtivo
            // 
            this.txtNumeroSerieAtivo.Location = new System.Drawing.Point(351, 18);
            this.txtNumeroSerieAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroSerieAtivo.Name = "txtNumeroSerieAtivo";
            this.txtNumeroSerieAtivo.Size = new System.Drawing.Size(159, 20);
            this.txtNumeroSerieAtivo.TabIndex = 4;
            this.txtNumeroSerieAtivo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblGerenciarAtivosSalas
            // 
            this.lblGerenciarAtivosSalas.AutoSize = true;
            this.lblGerenciarAtivosSalas.Location = new System.Drawing.Point(22, 63);
            this.lblGerenciarAtivosSalas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGerenciarAtivosSalas.Name = "lblGerenciarAtivosSalas";
            this.lblGerenciarAtivosSalas.Size = new System.Drawing.Size(31, 13);
            this.lblGerenciarAtivosSalas.TabIndex = 3;
            this.lblGerenciarAtivosSalas.Text = "Sala:";
            // 
            // lblDescricaoAtivo
            // 
            this.lblDescricaoAtivo.AutoSize = true;
            this.lblDescricaoAtivo.Location = new System.Drawing.Point(22, 23);
            this.lblDescricaoAtivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoAtivo.Name = "lblDescricaoAtivo";
            this.lblDescricaoAtivo.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoAtivo.TabIndex = 2;
            this.lblDescricaoAtivo.Text = "Descrição:";
            // 
            // comboBoxGerenciarAtivosSalas
            // 
            this.comboBoxGerenciarAtivosSalas.FormattingEnabled = true;
            this.comboBoxGerenciarAtivosSalas.Location = new System.Drawing.Point(56, 57);
            this.comboBoxGerenciarAtivosSalas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGerenciarAtivosSalas.Name = "comboBoxGerenciarAtivosSalas";
            this.comboBoxGerenciarAtivosSalas.Size = new System.Drawing.Size(185, 21);
            this.comboBoxGerenciarAtivosSalas.TabIndex = 1;
            // 
            // txtDescricaoAtivo
            // 
            this.txtDescricaoAtivo.Location = new System.Drawing.Point(81, 20);
            this.txtDescricaoAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoAtivo.Name = "txtDescricaoAtivo";
            this.txtDescricaoAtivo.Size = new System.Drawing.Size(159, 20);
            this.txtDescricaoAtivo.TabIndex = 0;
            // 
            // tabGerenciarSalas
            // 
            this.tabGerenciarSalas.Controls.Add(this.btnExcluirSala);
            this.tabGerenciarSalas.Controls.Add(this.btnAtualizarSala);
            this.tabGerenciarSalas.Controls.Add(this.btnVizualizarSala);
            this.tabGerenciarSalas.Controls.Add(this.btnCadastrarSala);
            this.tabGerenciarSalas.Controls.Add(this.dataGridViewSalas);
            this.tabGerenciarSalas.Controls.Add(this.lblDescricaoSala);
            this.tabGerenciarSalas.Controls.Add(this.txtDescricaoSala);
            this.tabGerenciarSalas.Location = new System.Drawing.Point(4, 22);
            this.tabGerenciarSalas.Name = "tabGerenciarSalas";
            this.tabGerenciarSalas.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerenciarSalas.Size = new System.Drawing.Size(1045, 666);
            this.tabGerenciarSalas.TabIndex = 3;
            this.tabGerenciarSalas.Text = "Gerenciar Salas";
            this.tabGerenciarSalas.UseVisualStyleBackColor = true;
            // 
            // btnExcluirSala
            // 
            this.btnExcluirSala.Location = new System.Drawing.Point(646, 93);
            this.btnExcluirSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirSala.Name = "btnExcluirSala";
            this.btnExcluirSala.Size = new System.Drawing.Size(93, 19);
            this.btnExcluirSala.TabIndex = 27;
            this.btnExcluirSala.Text = "Excluir";
            this.btnExcluirSala.UseVisualStyleBackColor = true;
            this.btnExcluirSala.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAtualizarSala
            // 
            this.btnAtualizarSala.Location = new System.Drawing.Point(494, 93);
            this.btnAtualizarSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizarSala.Name = "btnAtualizarSala";
            this.btnAtualizarSala.Size = new System.Drawing.Size(89, 19);
            this.btnAtualizarSala.TabIndex = 26;
            this.btnAtualizarSala.Text = "Atualizar";
            this.btnAtualizarSala.UseVisualStyleBackColor = true;
            this.btnAtualizarSala.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnVizualizarSala
            // 
            this.btnVizualizarSala.Location = new System.Drawing.Point(184, 93);
            this.btnVizualizarSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnVizualizarSala.Name = "btnVizualizarSala";
            this.btnVizualizarSala.Size = new System.Drawing.Size(93, 19);
            this.btnVizualizarSala.TabIndex = 25;
            this.btnVizualizarSala.Text = "Visualizar";
            this.btnVizualizarSala.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarSala
            // 
            this.btnCadastrarSala.Location = new System.Drawing.Point(32, 93);
            this.btnCadastrarSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarSala.Name = "btnCadastrarSala";
            this.btnCadastrarSala.Size = new System.Drawing.Size(89, 19);
            this.btnCadastrarSala.TabIndex = 24;
            this.btnCadastrarSala.Text = "Cadastrar";
            this.btnCadastrarSala.UseVisualStyleBackColor = true;
            this.btnCadastrarSala.Click += new System.EventHandler(this.BtnCadastrarSala_Click);
            // 
            // dataGridViewSalas
            // 
            this.dataGridViewSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalas.Location = new System.Drawing.Point(8, 122);
            this.dataGridViewSalas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSalas.Name = "dataGridViewSalas";
            this.dataGridViewSalas.RowHeadersWidth = 51;
            this.dataGridViewSalas.RowTemplate.Height = 24;
            this.dataGridViewSalas.Size = new System.Drawing.Size(1009, 471);
            this.dataGridViewSalas.TabIndex = 23;
            // 
            // lblDescricaoSala
            // 
            this.lblDescricaoSala.AutoSize = true;
            this.lblDescricaoSala.Location = new System.Drawing.Point(26, 44);
            this.lblDescricaoSala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoSala.Name = "lblDescricaoSala";
            this.lblDescricaoSala.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoSala.TabIndex = 21;
            this.lblDescricaoSala.Text = "Descrição:";
            // 
            // txtDescricaoSala
            // 
            this.txtDescricaoSala.Location = new System.Drawing.Point(85, 41);
            this.txtDescricaoSala.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoSala.Name = "txtDescricaoSala";
            this.txtDescricaoSala.Size = new System.Drawing.Size(655, 20);
            this.txtDescricaoSala.TabIndex = 19;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtivos)).EndInit();
            this.tabGerenciarSalas.ResumeLayout(false);
            this.tabGerenciarSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).EndInit();
            this.tabComunicacaoSerial.ResumeLayout(false);
            this.tabComunicacaoSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabComunicacaoSerial;
        private System.Windows.Forms.ComboBox comboBoxConsultaSalas;
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
        private System.Windows.Forms.Label lblNumeroSerieAtivo;
        private System.Windows.Forms.TextBox txtNumeroSerieAtivo;
        private System.Windows.Forms.Label lblGerenciarAtivosSalas;
        private System.Windows.Forms.Label lblDescricaoAtivo;
        private System.Windows.Forms.ComboBox comboBoxGerenciarAtivosSalas;
        private System.Windows.Forms.TextBox txtDescricaoAtivo;
        private System.Windows.Forms.Label lblDataModificacao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataModificacao;
        private System.Windows.Forms.Label lblCodigoRfId;
        private System.Windows.Forms.TextBox txtCodigoRfId;
        private System.Windows.Forms.Button btnVizualizarAtivos;
        private System.Windows.Forms.Button btnExcluirAtivos;
        private System.Windows.Forms.Button btnAtualizarAtivos;
        private System.Windows.Forms.Button btnCadastroAtivos;
        private System.Windows.Forms.DataGridView dataGridViewAtivos;
        private System.Windows.Forms.Button btnExcluirSala;
        private System.Windows.Forms.Button btnAtualizarSala;
        private System.Windows.Forms.Button btnVizualizarSala;
        private System.Windows.Forms.Button btnCadastrarSala;
        private System.Windows.Forms.DataGridView dataGridViewSalas;
        private System.Windows.Forms.Label lblDescricaoSala;
        private System.Windows.Forms.TextBox txtDescricaoSala;
        private System.Windows.Forms.Label lblLeituraDados;
        private System.Windows.Forms.TextBox txtRecepcaoDados;
        private System.Windows.Forms.Button btnClear;
    }
}

