using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TECNAS.Classes;
using System.Diagnostics;

namespace TECNAS.PoupUps
{
    public partial class InstalarVozes : Form
    {
        public InstalarVozes()
        {
            InitializeComponent();
        }

        private void InstalarVozes_Load(object sender, EventArgs e)
        {
            tvVozes.Nodes.Clear();
            string[] vozes = Directory.GetFiles(Global.Diretorios.vozes);
            foreach(string voz in vozes)
            {
                FileInfo infoFileVozes = new FileInfo(voz);
                tvVozes.Nodes.Add(infoFileVozes.FullName,infoFileVozes.Name);
            }
        }

        private void btInstalar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deverá reiniciar o programa para que as alterações entrem em vigor.", "Instalar Voz", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Process.Start(tvVozes.SelectedNode.Name);
            }
        }
    }
}
