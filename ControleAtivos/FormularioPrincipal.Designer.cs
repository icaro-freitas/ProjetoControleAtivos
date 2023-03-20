﻿
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
            this.Consulta = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblStatusComunicacao = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboPortaCOM = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPortaCom = new System.Windows.Forms.Label();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Consulta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Consulta);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.comboBox1);
            this.Consulta.Location = new System.Drawing.Point(4, 22);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta.Size = new System.Drawing.Size(1045, 666);
            this.Consulta.TabIndex = 0;
            this.Consulta.Text = "Consulta Ativos";
            this.Consulta.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnProcurar);
            this.tabPage2.Controls.Add(this.lblStatusComunicacao);
            this.tabPage2.Controls.Add(this.btnDesconectar);
            this.tabPage2.Controls.Add(this.btnConectar);
            this.tabPage2.Controls.Add(this.cboBaudRate);
            this.tabPage2.Controls.Add(this.cboPortaCOM);
            this.tabPage2.Controls.Add(this.lblBaudRate);
            this.tabPage2.Controls.Add(this.lblPortaCom);
            this.tabPage2.Controls.Add(this.lblConfiguracoes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1045, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comunicação Serial";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 654);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormularioPrincipal";
            this.Text = "Controles de Ativos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Consulta.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}

