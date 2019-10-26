using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TECNAS.Classes;
using System.IO;

namespace TECNAS.Componentes
{
    public partial class Gerenciador_de_Textos : Form
    {
        EditorTexto meuEditor;
        public Gerenciador_de_Textos()
        {
            InitializeComponent();
        }

        public void setEditor(EditorTexto editorTexto)
        {
            meuEditor = editorTexto;
        }
        private void Gerenciador_de_Textos_Load(object sender, EventArgs e)
        {
            GetFiles();
        }

        public void GetFiles()
        {
            treeViewTextList.Nodes.Clear();
            String[] fileList = Directory.GetFiles(Global.Diretorios.activePath);
            foreach(String file in fileList)
            {
                String fileName = Path.GetFileName(file);
                if (fileName != "Frases.txt")
                {
                    AddFile(fileName);
                }
            }
        }

        private void AddFile(String file)
        {
            if (file.Contains(".txt"))
            {
                treeViewTextList.Nodes.Add(file, file, 0, 0);
            }
            if (file.Contains(".rtf"))
            {
                treeViewTextList.Nodes.Add(file, file, 1, 1);
            }
        }

        private void treeViewTextList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
        }

        private void toolStripButtonDeletar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja remover o arquivo?","Deletar Texto",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(Global.Diretorios.activePath + "\\" + treeViewTextList.SelectedNode.Text);
                    meuEditor.setNomeArquivo("");
                    GetFiles(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }

        private void treeViewTextList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(meuEditor.getNomeArquivo() != "")
            {
                meuEditor.SalvaTexto();
            }
            toolStripButtonDeletar.Enabled = treeViewTextList.SelectedNode.Index != -1;
            toolStripButtonRenomear.Enabled = toolStripButtonDeletar.Enabled;
            meuEditor.AbrirArquivo(treeViewTextList.SelectedNode.Text);
            meuEditor.Text = "Editor de Texto - " + treeViewTextList.SelectedNode.Text;
            //meuEditor.FalarTexto();
        }

        private void toolStripButtonRenomear_Click(object sender, EventArgs e)
        {
            PoupUps.PoupUpTexto novoTexto = new PoupUps.PoupUpTexto("Renomear Arquivo", "Nome:");
            novoTexto.setTexto(treeViewTextList.SelectedNode.Text);
            if (novoTexto.ShowDialog() == DialogResult.OK)
            {
                RenomearArquivo(novoTexto.getTexto());
            }
        }

        private void RenomearArquivo(String novoNome)
        {
            try
            {
                String caminho = Global.Diretorios.activePath + "\\";
                File.Move(caminho + treeViewTextList.SelectedNode.Text, caminho + novoNome + ".txt");
                GetFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            meuEditor.NovoTexto();
        }
    }
}
