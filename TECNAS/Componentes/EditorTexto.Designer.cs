namespace TECNAS.Componentes
{
    partial class EditorTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorTexto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFalar = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripEditorDeTextos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocompleteMenuDicionario = new AutocompleteMenuNS.AutocompleteMenu();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStripEditorDeTextos.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNovo,
            this.toolStripButtonSalvar,
            this.toolStripButtonFalar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(747, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStripEditorTexto";
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
            // toolStripButtonSalvar
            // 
            this.toolStripButtonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSalvar.Image = global::TECNAS.Properties.Resources.Salvar;
            this.toolStripButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            this.toolStripButtonSalvar.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonSalvar.Text = "Salvar";
            this.toolStripButtonSalvar.Click += new System.EventHandler(this.toolStripButtonSalvar_Click);
            // 
            // toolStripButtonFalar
            // 
            this.toolStripButtonFalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFalar.Image = global::TECNAS.Properties.Resources.Falar;
            this.toolStripButtonFalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFalar.Name = "toolStripButtonFalar";
            this.toolStripButtonFalar.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonFalar.Text = "Falar (F3)";
            this.toolStripButtonFalar.Click += new System.EventHandler(this.toolStripButtonFalar_Click);
            // 
            // richTextBox1
            // 
            this.autocompleteMenuDicionario.SetAutocompleteMenu(this.richTextBox1, this.autocompleteMenuDicionario);
            this.richTextBox1.ContextMenuStrip = this.contextMenuStripEditorDeTextos;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 39);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(747, 367);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStripEditorDeTextos
            // 
            this.contextMenuStripEditorDeTextos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.falarTextoToolStripMenuItem});
            this.contextMenuStripEditorDeTextos.Name = "contextMenuStripEditorDeTextos";
            this.contextMenuStripEditorDeTextos.Size = new System.Drawing.Size(181, 92);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = global::TECNAS.Properties.Resources.Adicionar;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = global::TECNAS.Properties.Resources.Salvar;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // falarTextoToolStripMenuItem
            // 
            this.falarTextoToolStripMenuItem.Image = global::TECNAS.Properties.Resources.Falar;
            this.falarTextoToolStripMenuItem.Name = "falarTextoToolStripMenuItem";
            this.falarTextoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.falarTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.falarTextoToolStripMenuItem.Text = "Falar Texto";
            this.falarTextoToolStripMenuItem.Click += new System.EventHandler(this.falarTextoToolStripMenuItem_Click);
            // 
            // autocompleteMenuDicionario
            // 
            this.autocompleteMenuDicionario.AppearInterval = 100;
            this.autocompleteMenuDicionario.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenuDicionario.Colors")));
            this.autocompleteMenuDicionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenuDicionario.ImageList = null;
            this.autocompleteMenuDicionario.Items = new string[0];
            this.autocompleteMenuDicionario.TargetControlWrapper = null;
            // 
            // EditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditorTexto";
            this.Text = "Editor de Textos";
            this.Load += new System.EventHandler(this.EditorTexto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStripEditorDeTextos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNovo;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalvar;
        private System.Windows.Forms.ToolStripButton toolStripButtonFalar;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenuDicionario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditorDeTextos;
        private System.Windows.Forms.ToolStripMenuItem falarTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
    }
}