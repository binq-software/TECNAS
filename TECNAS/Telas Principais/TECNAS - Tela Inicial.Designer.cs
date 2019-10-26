namespace TECNAS.Telas_Principais
{
    partial class TECNAS___Tela_Inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TECNAS___Tela_Inicial));
            this.label1 = new System.Windows.Forms.Label();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerVerificaConexao = new System.Windows.Forms.Timer(this.components);
            this.labelBoasVindas = new System.Windows.Forms.Label();
            this.pictureBoxBuscar = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxConfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configurações";
            // 
            // Arduino
            // 
            this.Arduino.ReadTimeout = 200;
            this.Arduino.WriteTimeout = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status do Dispositivo:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(215, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(77, 13);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Desconectado";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(12, 253);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(368, 59);
            this.textBoxConsole.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Console:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Buscar Dispositivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Iniciar Software";
            // 
            // timerVerificaConexao
            // 
            this.timerVerificaConexao.Interval = 500;
            this.timerVerificaConexao.Tick += new System.EventHandler(this.timerVerificaConexao_Tick);
            // 
            // labelBoasVindas
            // 
            this.labelBoasVindas.Location = new System.Drawing.Point(17, 43);
            this.labelBoasVindas.Name = "labelBoasVindas";
            this.labelBoasVindas.Size = new System.Drawing.Size(364, 40);
            this.labelBoasVindas.TabIndex = 9;
            this.labelBoasVindas.Text = "Seja bem vindo ao TECNAS! Para começar a utilizar o software conecte o arduino ao" +
    " computador e selecione buscar dispositivo. Após estabelecer a conexão, clique e" +
    "m Iniciar software.";
            // 
            // pictureBoxBuscar
            // 
            this.pictureBoxBuscar.Image = global::TECNAS.Properties.Resources.USB;
            this.pictureBoxBuscar.Location = new System.Drawing.Point(144, 104);
            this.pictureBoxBuscar.Name = "pictureBoxBuscar";
            this.pictureBoxBuscar.Size = new System.Drawing.Size(102, 92);
            this.pictureBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBuscar.TabIndex = 8;
            this.pictureBoxBuscar.TabStop = false;
            this.pictureBoxBuscar.Click += new System.EventHandler(this.BuscarDispositivo_Click);
            this.pictureBoxBuscar.MouseEnter += new System.EventHandler(this.pictureBoxBuscar_MouseHover);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Image = global::TECNAS.Properties.Resources.Software;
            this.pictureBoxStart.Location = new System.Drawing.Point(277, 104);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(102, 92);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 6;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBoxStart_Click);
            this.pictureBoxStart.MouseEnter += new System.EventHandler(this.pictureBoxStart_MouseHover);
            // 
            // pictureBoxConfig
            // 
            this.pictureBoxConfig.Image = global::TECNAS.Properties.Resources.Configurações;
            this.pictureBoxConfig.Location = new System.Drawing.Point(11, 104);
            this.pictureBoxConfig.Name = "pictureBoxConfig";
            this.pictureBoxConfig.Size = new System.Drawing.Size(102, 92);
            this.pictureBoxConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfig.TabIndex = 0;
            this.pictureBoxConfig.TabStop = false;
            this.pictureBoxConfig.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxConfig.MouseEnter += new System.EventHandler(this.pictureBoxConfig_MouseHover);
            // 
            // TECNAS___Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 324);
            this.Controls.Add(this.labelBoasVindas);
            this.Controls.Add(this.pictureBoxBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TECNAS___Tela_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECNAS - Tela Inicial";
            this.Load += new System.EventHandler(this.TECNAS___Tela_Inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxConfig;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.PictureBox pictureBoxBuscar;
        private System.Windows.Forms.Timer timerVerificaConexao;
        private System.Windows.Forms.Label labelBoasVindas;
    }
}