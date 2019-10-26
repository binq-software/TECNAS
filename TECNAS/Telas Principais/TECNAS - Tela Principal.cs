using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TECNAS.Componentes;

namespace TECNAS.Telas_Principais
{
    public partial class TECNAS___Tela_Principal : Form
    {
        ProgramadorFrases windowProgramadorFrases;
        Gerenciador_de_Textos windowGerenciaTextos;
        EditorTexto windowEditorTexto;
        MenuSuperior MenuSuperior;

        public TECNAS___Tela_Principal()
        {
            InitializeComponent();
        }

        public void setTitulo(String novoTitulo)
        {
            Text = "TECNAS - " + novoTitulo;
        }

        private void TECNAS___Tela_Principal_Load(object sender, EventArgs e)
        {
            windowProgramadorFrases = new ProgramadorFrases();
            windowGerenciaTextos = new Gerenciador_de_Textos();
            windowEditorTexto = new EditorTexto(windowGerenciaTextos);
            MenuSuperior = new MenuSuperior(windowEditorTexto,windowGerenciaTextos,windowProgramadorFrases);
            windowGerenciaTextos.setEditor(windowEditorTexto);
            mostrarJanela(windowProgramadorFrases, splitContainer2.Panel1);
            mostrarJanela(windowEditorTexto, splitContainer4.Panel1);
            mostrarJanela(windowGerenciaTextos, splitContainer4.Panel2);
            mostrarJanela(MenuSuperior, splitContainer1.Panel1);
            MenuSuperior.setParent(this);
            Text = "TECNAS - " + TECNAS.Classes.Global.Diretorios.interfaceAtiva;
        }

        private void mostrarJanela(Form windowForm, SplitterPanel local)
        {
            windowForm.MdiParent = this;
            windowForm.Parent = local;
            windowForm.Dock = DockStyle.Fill;
            windowForm.Show();
        }
    }
}
