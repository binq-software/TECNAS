using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;
using TECNAS.Classes;
using TECNAS.PoupUps;

namespace TECNAS.Telas_Principais
{ 
    public partial class TECNAS___Configurações : Form
    {
        //private Locutor VozVirtual = new Locutor();
        //private Configuracoes EditorConfig = new Configuracoes();
        public TECNAS___Configurações()
        {
            InitializeComponent();
        }
        private void TECNAS___Configurações_Load(object sender, EventArgs e)
        {
            comboBoxSelecionaVoz.Items.Clear();
            foreach (InstalledVoice voice in Global.Recursos.VozVirtual.getVozesInstaladas())
            {
                comboBoxSelecionaVoz.Items.Add(voice.VoiceInfo.Name);
            }
            carregaVelocidadeVoz();
            carregaVolumeVoz();
            carregaVoz();
            textBoxTeste.Text = Global.Recursos.VozVirtual.getFraseTeste();
        }
        private void comboBoxSelecionaVoz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.setVozSelecionada(comboBoxSelecionaVoz.SelectedItem.ToString());
            Global.Recursos.VozVirtual.Falar("Você selecionou " + comboBoxSelecionaVoz.SelectedItem.ToString() + " como sua voz padrão");
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.Falar("Você selecionou " + comboBoxSelecionaVoz.SelectedItem.ToString() + " como sua voz padrão");
        }
        private void trackBarVelocidade_Scroll(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.setVelocidadeVoz(trackBarVelocidade.Value);
        }
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.setVolumeVoz(trackBarVolume.Value);
        }
        private void carregaVoz()
        {
            String vozSelecionada = Global.Recursos.VozVirtual.getVozSelecionada();
            if (vozSelecionada != null)
            {
                if (comboBoxSelecionaVoz.Items.Contains(vozSelecionada))
                {
                    comboBoxSelecionaVoz.SelectedItem = vozSelecionada;
                }
            }
        }
        private void carregaVelocidadeVoz()
        {
            String velVoz = Global.Recursos.VozVirtual.getVelocidadeVoz();
            if (velVoz != "Não Encontrado" && Int32.Parse(velVoz) > 0)
            {
                trackBarVelocidade.Value = Convert.ToInt32(velVoz);
                Global.Recursos.VozVirtual.setVelocidadeVoz(Convert.ToInt32(velVoz));
            }
        }
        private void carregaVolumeVoz()
        {
            int volVoz = Global.Recursos.VozVirtual.getVolumeVoz();
            trackBarVolume.Value = Convert.ToInt32(volVoz);
        }

        private void buttonSpeak_Click(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.Falar(textBoxTeste.Text);
            Global.Recursos.VozVirtual.setFraseTeste(textBoxTeste.Text);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstalarVozes janelaInstalarvozes = new InstalarVozes();
            janelaInstalarvozes.Show();
        }
    }
}
