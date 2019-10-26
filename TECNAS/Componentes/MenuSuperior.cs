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
using TECNAS.Componentes;
namespace TECNAS.Componentes
{
    
    public partial class MenuSuperior : Form
    {
        EditorTexto meuEditorTexto;
        Gerenciador_de_Textos meuGerenciadorTextos;
        ProgramadorFrases meuPogramadorFrases;
        Telas_Principais.TECNAS___Tela_Principal meuParent;

        public void setParent(Telas_Principais.TECNAS___Tela_Principal novoParent)
        {
            meuParent = novoParent;
        }

        public MenuSuperior(EditorTexto novoEditor, Gerenciador_de_Textos novoGerenciador, ProgramadorFrases novoProgramador)
        {
            InitializeComponent();
            meuEditorTexto = novoEditor;
            meuPogramadorFrases = novoProgramador;
            meuGerenciadorTextos = novoGerenciador;
        }

        private void MenuSuperior_Load(object sender, EventArgs e)
        {
            CarregaInterfaces();
        }

        private void CarregaInterfaces()
        {
            String[] interfaces = File.ReadAllLines(Global.Diretorios.interfacesFile);
            foreach(String interfaceName in interfaces)
            {
                AddBtInterface(interfaceName);
            }
        }

        private void AddBtInterface(String Nome)
        {
            ToolStripButton novoBotao = new ToolStripButton(Nome, Properties.Resources.Software);
            novoBotao.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            novoBotao.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripInterfaces.Items.Add(novoBotao);
        }

        private void toolStripButtonNova_Click(object sender, EventArgs e)
        {
            PoupUps.PoupUpTexto novaInterface = new PoupUps.PoupUpTexto("Nova Interface", "Nome:");
            if(novaInterface.ShowDialog() == DialogResult.OK)
            {
                CriarNovaInterface(novaInterface.getTexto());
            }
        }

        private void CriarNovaInterface(String nome)
        {
            String newPath = Global.Diretorios.myRoot + "\\" + nome;
            Directory.CreateDirectory(newPath);
            File.Create(newPath + "\\Frases.txt");
            File.AppendAllText(Global.Diretorios.interfacesFile, nome + "\n");
            AddBtInterface(nome);
        }

        private void toolStripInterfaces_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Nova" || e.ClickedItem.Text == "Renomear" || e.ClickedItem.Text == "Remover")
            {
                return;
            }
            AbrirInterface(e.ClickedItem.Text);
        }

        private void SalvarInterfaceAberta()
        {
            if(meuEditorTexto.arquivoExiste())
            {
                meuEditorTexto.SalvaTexto();
            }
            meuPogramadorFrases.SalvarFrases();
        }

        private void AbrirInterface(String nome)
        {
            AtualizaReferencia(nome);
            meuEditorTexto.limpaTexto();
            meuGerenciadorTextos.GetFiles();
            meuPogramadorFrases.CarregaFrases();
            meuParent.setTitulo(nome);
        }

        private static void AtualizaReferencia(string nome)
        {
            Global.Diretorios.interfaceAtiva = nome;
            Global.Diretorios.activePath = Global.Diretorios.myRoot + "\\" + nome;
            Global.Diretorios.frasesFile = Global.Diretorios.activePath + "\\Frases.txt";
            //meuParent.Text = "TECNAS - " + nome;
        }

        private void toolStripButtonRenomear_Click(object sender, EventArgs e)
        {
            PoupUps.PoupUpTexto novaInterface = new PoupUps.PoupUpTexto("Renomear Interface", "Nome:");
            if (novaInterface.ShowDialog() == DialogResult.OK)
            {
                RenomearInterface(novaInterface.getTexto());
            }
        }

        private void RenomearInterface(String novoNome)
        {
            Directory.Move(Global.Diretorios.activePath, Global.Diretorios.myRoot + "\\" + novoNome);
            String[] telasAtuais = File.ReadAllLines(Global.Diretorios.interfacesFile);
            RenomearArquivo(novoNome, telasAtuais);
            RenomearBotao(novoNome);
            AtualizaReferencia(novoNome);
        }

        private void RenomearBotao(string novoNome)
        {
            foreach (ToolStripButton button in toolStripInterfaces.Items)
            {
                if (button.Text == Global.Diretorios.interfaceAtiva)
                {
                    button.Text = novoNome;
                }
            }
        }

        private static void RenomearArquivo(string novoNome, string[] telasAtuais)
        {
            for (int i = 0; i < telasAtuais.Length; i++)
            {
                string nomeTela = telasAtuais[i];
                if (nomeTela == Global.Diretorios.interfaceAtiva)
                {
                    telasAtuais[i] = novoNome;
                }
            }
            File.WriteAllLines(Global.Diretorios.interfacesFile, telasAtuais);
        }

        private void toolStripButtonRemover_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja remover o perfil: " + Global.Diretorios.interfaceAtiva, "Remover Perfil",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveBt(Global.Diretorios.interfaceAtiva);
                RemoveFromList(Global.Diretorios.interfaceAtiva);
                Directory.Delete(Global.Diretorios.activePath);
            }
        }

        private void RemoveBt(String nome)
        {
            foreach (ToolStripButton button in toolStripInterfaces.Items)
            {
                if (button.Text == nome)
                {
                    toolStripInterfaces.Items.Remove(button);
                    break;
                }
            }
        }

        private void RemoveFromList(String nome)
        {
            String[] telasAtuais = File.ReadAllLines(Global.Diretorios.interfacesFile);
            for (int i = 0; i < telasAtuais.Length; i++)
            {
                string nomeTela = telasAtuais[i];
                if (nomeTela != nome)
                {
                    File.WriteAllText(Global.Diretorios.interfacesFile, nomeTela + "\n");
                }
            }
            
        }
    }
}
