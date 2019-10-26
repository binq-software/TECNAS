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
namespace TECNAS.Componentes
{
    public partial class ProgramadorFrases : Form
    {

        public ProgramadorFrases()
        {
            InitializeComponent();
        }

        private void ProgramadorFrases_Load(object sender, EventArgs e)
        {
            if (File.Exists(Global.Diretorios.frasesFile))
            {
                CarregaFrases();
            }
            else
            {
                File.Create(Global.Diretorios.frasesFile);
            }
        }

        public void CarregaFrases()
        {
            try
            {
                String[] frases = File.ReadAllLines(Global.Diretorios.frasesFile);
                treeViewFrases.Nodes.Clear();
                foreach (String frase in frases)
                {
                    treeViewFrases.Nodes.Add(frase, frase, 0, 0);
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void treeViewFrases_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Global.Recursos.VozVirtual.Falar(e.Node.Text);
        }

        private void tsbtNovaFrase_click(object sender, EventArgs e)
        {
            PoupUps.PoupUpTexto novaFrase = new PoupUps.PoupUpTexto("Nova Frase","Frase");
            if (novaFrase.ShowDialog() == DialogResult.OK)
            {
                CriaFrase(novaFrase.getTexto());
            }
        }

        private void CriaFrase(String frase)
        {
            treeViewFrases.Nodes.Add(frase,frase,0,0);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            treeViewFrases.SelectedNode.Remove();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SalvarFrases();
        }

        public void SalvarFrases()
        {
            File.WriteAllText(Global.Diretorios.frasesFile, "");
            foreach (TreeNode node in treeViewFrases.Nodes)
            {
                File.AppendAllText(Global.Diretorios.frasesFile, node.Text + "\n");
            }
        }

        private void treeViewFrases_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolStripButton2.Enabled = treeViewFrases.SelectedNode.Index != -1;
            toolStripButtonRenomear.Enabled = toolStripButton2.Enabled;
        }

        private void toolStripButtonFalar_Click(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.Falar(treeViewFrases.SelectedNode.Text);
        }

        private void falarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewFrases.SelectedNode.Index >= 0)
            {
                Global.Recursos.VozVirtual.Falar(treeViewFrases.SelectedNode.Text);
            }
        }

        private void toolStripButtonRenomear_Click(object sender, EventArgs e)
        {
            PoupUps.PoupUpTexto alterarFrase = new PoupUps.PoupUpTexto("Alterar Frase", "Frase:");
            alterarFrase.setTexto(treeViewFrases.SelectedNode.Text);
            if (alterarFrase.ShowDialog() == DialogResult.OK)
            {
                treeViewFrases.SelectedNode.Text = alterarFrase.getTexto();
            }
        }
    }
}
