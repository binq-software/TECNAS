namespace TECNAS.Componentes
{
    partial class ProgramadorFrases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramadorFrases));
            this.toolStripProgramador = new System.Windows.Forms.ToolStrip();
            this.tsbtNovaFrase = new System.Windows.Forms.ToolStripButton();
            this.tsbtSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtFalar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRenomear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.treeViewFrases = new System.Windows.Forms.TreeView();
            this.contextMenuStripEditorFrases = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.falarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListFalas = new System.Windows.Forms.ImageList(this.components);
            this.toolStripProgramador.SuspendLayout();
            this.contextMenuStripEditorFrases.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripProgramador
            // 
            this.toolStripProgramador.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripProgramador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtNovaFrase,
            this.tsbtSave,
            this.tsbtFalar,
            this.toolStripButtonRenomear,
            this.toolStripButton2});
            this.toolStripProgramador.Location = new System.Drawing.Point(0, 0);
            this.toolStripProgramador.Name = "toolStripProgramador";
            this.toolStripProgramador.Size = new System.Drawing.Size(216, 39);
            this.toolStripProgramador.TabIndex = 0;
            this.toolStripProgramador.Text = "toolStrip1";
            // 
            // tsbtNovaFrase
            // 
            this.tsbtNovaFrase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtNovaFrase.Image = global::TECNAS.Properties.Resources.Adicionar;
            this.tsbtNovaFrase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtNovaFrase.Name = "tsbtNovaFrase";
            this.tsbtNovaFrase.Size = new System.Drawing.Size(36, 36);
            this.tsbtNovaFrase.Text = "toolStripButtonNovo";
            this.tsbtNovaFrase.ToolTipText = "Nova Frase";
            this.tsbtNovaFrase.Click += new System.EventHandler(this.tsbtNovaFrase_click);
            // 
            // tsbtSave
            // 
            this.tsbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtSave.Image = global::TECNAS.Properties.Resources.Salvar;
            this.tsbtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtSave.Name = "tsbtSave";
            this.tsbtSave.Size = new System.Drawing.Size(36, 36);
            this.tsbtSave.Text = "toolStripButtonSalvar";
            this.tsbtSave.ToolTipText = "Salvar Frases";
            this.tsbtSave.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsbtFalar
            // 
            this.tsbtFalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtFalar.Image = global::TECNAS.Properties.Resources.Falar;
            this.tsbtFalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtFalar.Name = "tsbtFalar";
            this.tsbtFalar.Size = new System.Drawing.Size(36, 36);
            this.tsbtFalar.Text = "Falar (F3)";
            this.tsbtFalar.Click += new System.EventHandler(this.toolStripButtonFalar_Click);
            // 
            // toolStripButtonRenomear
            // 
            this.toolStripButtonRenomear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRenomear.Enabled = false;
            this.toolStripButtonRenomear.Image = global::TECNAS.Properties.Resources.Renomear;
            this.toolStripButtonRenomear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRenomear.Name = "toolStripButtonRenomear";
            this.toolStripButtonRenomear.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonRenomear.Text = "toolStripButton1";
            this.toolStripButtonRenomear.Click += new System.EventHandler(this.toolStripButtonRenomear_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = global::TECNAS.Properties.Resources.Remover;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButtonDeletar";
            this.toolStripButton2.ToolTipText = "Deletar Frase Selecionada";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // treeViewFrases
            // 
            this.treeViewFrases.ContextMenuStrip = this.contextMenuStripEditorFrases;
            this.treeViewFrases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFrases.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFrases.ImageIndex = 0;
            this.treeViewFrases.ImageList = this.imageListFalas;
            this.treeViewFrases.Location = new System.Drawing.Point(0, 39);
            this.treeViewFrases.Name = "treeViewFrases";
            this.treeViewFrases.SelectedImageIndex = 0;
            this.treeViewFrases.Size = new System.Drawing.Size(216, 325);
            this.treeViewFrases.TabIndex = 1;
            this.treeViewFrases.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFrases_AfterSelect);
            this.treeViewFrases.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFrases_NodeMouseDoubleClick);
            // 
            // contextMenuStripEditorFrases
            // 
            this.contextMenuStripEditorFrases.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.falarToolStripMenuItem});
            this.contextMenuStripEditorFrases.Name = "contextMenuStripEditorFrases";
            this.contextMenuStripEditorFrases.Size = new System.Drawing.Size(119, 26);
            // 
            // falarToolStripMenuItem
            // 
            this.falarToolStripMenuItem.Image = global::TECNAS.Properties.Resources.Falar;
            this.falarToolStripMenuItem.Name = "falarToolStripMenuItem";
            this.falarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.falarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.falarToolStripMenuItem.Text = "Falar";
            this.falarToolStripMenuItem.Click += new System.EventHandler(this.falarToolStripMenuItem_Click);
            // 
            // imageListFalas
            // 
            this.imageListFalas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFalas.ImageStream")));
            this.imageListFalas.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFalas.Images.SetKeyName(0, "balao.png");
            // 
            // ProgramadorFrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 364);
            this.Controls.Add(this.treeViewFrases);
            this.Controls.Add(this.toolStripProgramador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProgramadorFrases";
            this.Text = "Frases Pré-Programadas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProgramadorFrases_Load);
            this.toolStripProgramador.ResumeLayout(false);
            this.toolStripProgramador.PerformLayout();
            this.contextMenuStripEditorFrases.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripProgramador;
        private System.Windows.Forms.TreeView treeViewFrases;
        private System.Windows.Forms.ToolStripButton tsbtNovaFrase;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbtSave;
        private System.Windows.Forms.ImageList imageListFalas;
        private System.Windows.Forms.ToolStripButton tsbtFalar;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenomear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditorFrases;
        private System.Windows.Forms.ToolStripMenuItem falarToolStripMenuItem;
    }
}