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
    public partial class EditorTexto : Form
    {
        String arquivoAberto = "";
        private Gerenciador_de_Textos meuGerenciador;

        public EditorTexto(Gerenciador_de_Textos novoGerenciador)
        {
            InitializeComponent();
            meuGerenciador = novoGerenciador;
        }

        private void toolStripButtonFalar_Click(object sender, EventArgs e)
        {
            FalarTexto();
        }

        public void FalarTexto()
        {
            Global.Recursos.VozVirtual.Falar(richTextBox1.Text);
        }

        public void limpaTexto()
        {
            richTextBox1.Text = "";
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            NovoTexto();
        }

        public void NovoTexto()
        {
            PoupUps.PoupUpTexto novoTexto = new PoupUps.PoupUpTexto("Novo Texto", "Nome:");
            if (novoTexto.ShowDialog() == DialogResult.OK)
            {
                arquivoAberto = novoTexto.getTexto() + ".txt";
                richTextBox1.Text = "";
                SalvaTexto();
                meuGerenciador.GetFiles();
            }
        }

        public void SalvaTexto()
        {
            if (arquivoAberto == "")
            {
                MessageBox.Show("Ainda não existe um arquivo de texto. Será aberto a janela para criar um novo", "E necessário criar um texto.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripButtonNovo_Click(toolStripButtonNovo, new EventArgs());
            }
            else
            {
                File.WriteAllText(Global.Diretorios.activePath + "\\" + arquivoAberto, richTextBox1.Text);
            }
            
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            SalvaTexto();
        }

        private void EditorTexto_Load(object sender, EventArgs e)
        {
            autocompleteMenuDicionario.Items = Global.Recursos.autoCompleteMenuDicionario.Items;
        }

        public bool arquivoExiste()
        {
            return (File.Exists(Global.Diretorios.activePath + "\\" + arquivoAberto));
        }

        private void toolStripButtonAbrir_Click(object sender, EventArgs e)
        {

        }

        public void AbrirArquivo(String nome)
        {
            arquivoAberto = nome;
            richTextBox1.Text = File.ReadAllText(Global.Diretorios.activePath + "\\" + arquivoAberto);
        }

        public String getNomeArquivo()
        {
            return (arquivoAberto);
        }

        public void setNomeArquivo(String novoNome)
        {
            arquivoAberto = novoNome;
        }

        private void falarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FalarTexto();
        }
    }
}
