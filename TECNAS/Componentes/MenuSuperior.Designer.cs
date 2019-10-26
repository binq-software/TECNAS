namespace TECNAS.Componentes
{
    partial class MenuSuperior
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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageInterfaces = new System.Windows.Forms.TabPage();
            this.toolStripInterfaces = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNova = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRenomear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemover = new System.Windows.Forms.ToolStripButton();
            this.tabPageDigitação = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDicionario = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTecladoVirtual = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripTela = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlMenu.SuspendLayout();
            this.tabPageInterfaces.SuspendLayout();
            this.toolStripInterfaces.SuspendLayout();
            this.tabPageDigitação.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageInterfaces);
            this.tabControlMenu.Controls.Add(this.tabPageDigitação);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(638, 85);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageInterfaces
            // 
            this.tabPageInterfaces.Controls.Add(this.toolStripInterfaces);
            this.tabPageInterfaces.Location = new System.Drawing.Point(4, 22);
            this.tabPageInterfaces.Name = "tabPageInterfaces";
            this.tabPageInterfaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInterfaces.Size = new System.Drawing.Size(630, 59);
            this.tabPageInterfaces.TabIndex = 0;
            this.tabPageInterfaces.Text = "Interfaces";
            this.tabPageInterfaces.UseVisualStyleBackColor = true;
            // 
            // toolStripInterfaces
            // 
            this.toolStripInterfaces.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripInterfaces.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNova,
            this.toolStripButtonRenomear,
            this.toolStripButtonRemover});
            this.toolStripInterfaces.Location = new System.Drawing.Point(3, 3);
            this.toolStripInterfaces.Name = "toolStripInterfaces";
            this.toolStripInterfaces.Size = new System.Drawing.Size(624, 54);
            this.toolStripInterfaces.TabIndex = 0;
            this.toolStripInterfaces.Text = "toolStrip2";
            this.toolStripInterfaces.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripInterfaces_ItemClicked);
            // 
            // toolStripButtonNova
            // 
            this.toolStripButtonNova.Image = global::TECNAS.Properties.Resources.Adicionar_Interface;
            this.toolStripButtonNova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNova.Name = "toolStripButtonNova";
            this.toolStripButtonNova.Size = new System.Drawing.Size(39, 51);
            this.toolStripButtonNova.Text = "Nova";
            this.toolStripButtonNova.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonNova.Click += new System.EventHandler(this.toolStripButtonNova_Click);
            // 
            // toolStripButtonRenomear
            // 
            this.toolStripButtonRenomear.Image = global::TECNAS.Properties.Resources.Renomear;
            this.toolStripButtonRenomear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRenomear.Name = "toolStripButtonRenomear";
            this.toolStripButtonRenomear.Size = new System.Drawing.Size(65, 51);
            this.toolStripButtonRenomear.Text = "Renomear";
            this.toolStripButtonRenomear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonRenomear.Click += new System.EventHandler(this.toolStripButtonRenomear_Click);
            // 
            // toolStripButtonRemover
            // 
            this.toolStripButtonRemover.Enabled = false;
            this.toolStripButtonRemover.Image = global::TECNAS.Properties.Resources.Remover;
            this.toolStripButtonRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemover.Name = "toolStripButtonRemover";
            this.toolStripButtonRemover.Size = new System.Drawing.Size(58, 51);
            this.toolStripButtonRemover.Text = "Remover";
            this.toolStripButtonRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonRemover.Click += new System.EventHandler(this.toolStripButtonRemover_Click);
            // 
            // tabPageDigitação
            // 
            this.tabPageDigitação.Controls.Add(this.toolStrip1);
            this.tabPageDigitação.Location = new System.Drawing.Point(4, 22);
            this.tabPageDigitação.Name = "tabPageDigitação";
            this.tabPageDigitação.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDigitação.Size = new System.Drawing.Size(630, 59);
            this.tabPageDigitação.TabIndex = 1;
            this.tabPageDigitação.Text = "Digitação";
            this.tabPageDigitação.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDicionario,
            this.toolStripButtonTecladoVirtual});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDicionario
            // 
            this.toolStripButtonDicionario.Image = global::TECNAS.Properties.Resources.Dicionários;
            this.toolStripButtonDicionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDicionario.Name = "toolStripButtonDicionario";
            this.toolStripButtonDicionario.Size = new System.Drawing.Size(70, 51);
            this.toolStripButtonDicionario.Text = "Dicionários";
            this.toolStripButtonDicionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonTecladoVirtual
            // 
            this.toolStripButtonTecladoVirtual.Image = global::TECNAS.Properties.Resources.Teclado;
            this.toolStripButtonTecladoVirtual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTecladoVirtual.Name = "toolStripButtonTecladoVirtual";
            this.toolStripButtonTecladoVirtual.Size = new System.Drawing.Size(89, 51);
            this.toolStripButtonTecladoVirtual.Text = "Teclado Virtual";
            this.toolStripButtonTecladoVirtual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // contextMenuStripTela
            // 
            this.contextMenuStripTela.Name = "contextMenuStripTela";
            this.contextMenuStripTela.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuSuperior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 85);
            this.Controls.Add(this.tabControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSuperior";
            this.Text = "MenuSuperior";
            this.Load += new System.EventHandler(this.MenuSuperior_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageInterfaces.ResumeLayout(false);
            this.tabPageInterfaces.PerformLayout();
            this.toolStripInterfaces.ResumeLayout(false);
            this.toolStripInterfaces.PerformLayout();
            this.tabPageDigitação.ResumeLayout(false);
            this.tabPageDigitação.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageInterfaces;
        private System.Windows.Forms.ToolStrip toolStripInterfaces;
        private System.Windows.Forms.ToolStripButton toolStripButtonNova;
        private System.Windows.Forms.TabPage tabPageDigitação;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDicionario;
        private System.Windows.Forms.ToolStripButton toolStripButtonTecladoVirtual;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTela;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenomear;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemover;
    }
}