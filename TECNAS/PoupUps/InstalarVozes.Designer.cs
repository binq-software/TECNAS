namespace TECNAS.PoupUps
{
    partial class InstalarVozes
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
            this.tvVozes = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btInstalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvVozes
            // 
            this.tvVozes.Location = new System.Drawing.Point(18, 38);
            this.tvVozes.Name = "tvVozes";
            this.tvVozes.Size = new System.Drawing.Size(257, 182);
            this.tvVozes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione uma das vozes abaixo e clique em instalar";
            // 
            // btInstalar
            // 
            this.btInstalar.Location = new System.Drawing.Point(201, 231);
            this.btInstalar.Name = "btInstalar";
            this.btInstalar.Size = new System.Drawing.Size(75, 23);
            this.btInstalar.TabIndex = 2;
            this.btInstalar.Text = "Instalar";
            this.btInstalar.UseVisualStyleBackColor = true;
            this.btInstalar.Click += new System.EventHandler(this.btInstalar_Click);
            // 
            // InstalarVozes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 264);
            this.Controls.Add(this.btInstalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvVozes);
            this.Name = "InstalarVozes";
            this.Text = "InstalarVozes";
            this.Load += new System.EventHandler(this.InstalarVozes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvVozes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInstalar;
    }
}