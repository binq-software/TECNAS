namespace TECNAS.Telas_Principais
{
    partial class TECNAS___Configurações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TECNAS___Configurações));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelecionaVoz = new System.Windows.Forms.ComboBox();
            this.tabControlConfig = new System.Windows.Forms.TabControl();
            this.tabPageVoz = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSpeak = new System.Windows.Forms.Button();
            this.textBoxTeste = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarVelocidade = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlConfig.SuspendLayout();
            this.tabPageVoz.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar Voz:";
            // 
            // comboBoxSelecionaVoz
            // 
            this.comboBoxSelecionaVoz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelecionaVoz.FormattingEnabled = true;
            this.comboBoxSelecionaVoz.Location = new System.Drawing.Point(123, 16);
            this.comboBoxSelecionaVoz.Name = "comboBoxSelecionaVoz";
            this.comboBoxSelecionaVoz.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSelecionaVoz.TabIndex = 1;
            this.comboBoxSelecionaVoz.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelecionaVoz_SelectedIndexChanged);
            // 
            // tabControlConfig
            // 
            this.tabControlConfig.Controls.Add(this.tabPageVoz);
            this.tabControlConfig.Location = new System.Drawing.Point(0, 0);
            this.tabControlConfig.Name = "tabControlConfig";
            this.tabControlConfig.SelectedIndex = 0;
            this.tabControlConfig.Size = new System.Drawing.Size(383, 318);
            this.tabControlConfig.TabIndex = 2;
            // 
            // tabPageVoz
            // 
            this.tabPageVoz.BackColor = System.Drawing.Color.White;
            this.tabPageVoz.Controls.Add(this.button1);
            this.tabPageVoz.Controls.Add(this.groupBox1);
            this.tabPageVoz.Controls.Add(this.buttonPlay);
            this.tabPageVoz.Controls.Add(this.trackBarVolume);
            this.tabPageVoz.Controls.Add(this.trackBarVelocidade);
            this.tabPageVoz.Controls.Add(this.label3);
            this.tabPageVoz.Controls.Add(this.label2);
            this.tabPageVoz.Controls.Add(this.comboBoxSelecionaVoz);
            this.tabPageVoz.Controls.Add(this.label1);
            this.tabPageVoz.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoz.Name = "tabPageVoz";
            this.tabPageVoz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVoz.Size = new System.Drawing.Size(375, 292);
            this.tabPageVoz.TabIndex = 0;
            this.tabPageVoz.Text = "Voz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSpeak);
            this.groupBox1.Controls.Add(this.textBoxTeste);
            this.groupBox1.Location = new System.Drawing.Point(4, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teste:";
            // 
            // buttonSpeak
            // 
            this.buttonSpeak.Location = new System.Drawing.Point(287, 94);
            this.buttonSpeak.Name = "buttonSpeak";
            this.buttonSpeak.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeak.TabIndex = 1;
            this.buttonSpeak.Text = "Ler Texto";
            this.buttonSpeak.UseVisualStyleBackColor = true;
            this.buttonSpeak.Click += new System.EventHandler(this.buttonSpeak_Click);
            // 
            // textBoxTeste
            // 
            this.textBoxTeste.Location = new System.Drawing.Point(6, 19);
            this.textBoxTeste.Multiline = true;
            this.textBoxTeste.Name = "textBoxTeste";
            this.textBoxTeste.Size = new System.Drawing.Size(353, 68);
            this.textBoxTeste.TabIndex = 0;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonPlay.Location = new System.Drawing.Point(327, 14);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(25, 25);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "4";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(123, 120);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(197, 45);
            this.trackBarVolume.TabIndex = 3;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // trackBarVelocidade
            // 
            this.trackBarVelocidade.Location = new System.Drawing.Point(123, 76);
            this.trackBarVelocidade.Name = "trackBarVelocidade";
            this.trackBarVelocidade.Size = new System.Drawing.Size(197, 45);
            this.trackBarVelocidade.TabIndex = 3;
            this.trackBarVelocidade.Scroll += new System.EventHandler(this.trackBarVelocidade_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velocidade da Voz:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(293, 324);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Instalar Vozes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TECNAS___Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 362);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControlConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TECNAS___Configurações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECNAS - Configurações";
            this.Load += new System.EventHandler(this.TECNAS___Configurações_Load);
            this.tabControlConfig.ResumeLayout(false);
            this.tabPageVoz.ResumeLayout(false);
            this.tabPageVoz.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelecionaVoz;
        private System.Windows.Forms.TabControl tabControlConfig;
        private System.Windows.Forms.TabPage tabPageVoz;
        private System.Windows.Forms.TrackBar trackBarVelocidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSpeak;
        private System.Windows.Forms.TextBox textBoxTeste;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button button1;
    }
}