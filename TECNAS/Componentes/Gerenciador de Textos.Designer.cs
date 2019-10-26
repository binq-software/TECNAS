namespace TECNAS.Componentes
{
    partial class Gerenciador_de_Textos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciador_de_Textos));
            this.treeViewTextList = new System.Windows.Forms.TreeView();
            this.imageListFiles = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeletar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRenomear = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewTextList
            // 
            this.treeViewTextList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTextList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewTextList.ImageIndex = 0;
            this.treeViewTextList.ImageList = this.imageListFiles;
            this.treeViewTextList.Location = new System.Drawing.Point(0, 39);
            this.treeViewTextList.Name = "treeViewTextList";
            this.treeViewTextList.SelectedImageIndex = 0;
            this.treeViewTextList.Size = new System.Drawing.Size(209, 411);
            this.treeViewTextList.TabIndex = 2;
            this.treeViewTextList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTextList_AfterSelect);
            this.treeViewTextList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewTextList_NodeMouseClick);
            // 
            // imageListFiles
            // 
            this.imageListFiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFiles.ImageStream")));
            this.imageListFiles.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFiles.Images.SetKeyName(0, "txt.png");
            this.imageListFiles.Images.SetKeyName(1, "Rtf.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNovo,
            this.toolStripButtonRenomear,
            this.toolStripButtonDeletar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(209, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            this.toolStripButtonNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNovo.Image = global::TECNAS.Properties.Resources.Adicionar;
            this.toolStripButtonNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNovo.Name = "toolStripButtonNovo";
            this.toolStripButtonNovo.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonNovo.Text = "Novo";
            this.toolStripButtonNovo.Click += new System.EventHandler(this.toolStripButtonNovo_Click);
            // 
            // toolStripButtonDeletar
            // 
            this.toolStripButtonDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeletar.Enabled = false;
            this.toolStripButtonDeletar.Image = global::TECNAS.Properties.Resources.Remover;
            this.toolStripButtonDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeletar.Name = "toolStripButtonDeletar";
            this.toolStripButtonDeletar.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonDeletar.Text = "toolStripButton1";
            this.toolStripButtonDeletar.Click += new System.EventHandler(this.toolStripButtonDeletar_Click);
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
            // Gerenciador_de_Textos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 450);
            this.Controls.Add(this.treeViewTextList);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Gerenciador_de_Textos";
            this.Text = "Gerenciador de Textos";
            this.Load += new System.EventHandler(this.Gerenciador_de_Textos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewTextList;
        private System.Windows.Forms.ImageList imageListFiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeletar;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenomear;
        private System.Windows.Forms.ToolStripButton toolStripButtonNovo;
    }
}