using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Globalization;
using System.Windows.Forms;

namespace TECNAS.Classes
{
    class Locutor
    {
        private Configuracoes EditorConfig = new Configuracoes();
        private SpeechSynthesizer Engine = new SpeechSynthesizer();
        public System.Collections.ObjectModel.ReadOnlyCollection<InstalledVoice> getVozesInstaladas()
        {
            return(Engine.GetInstalledVoices(new CultureInfo("pt-BR")));
        }
        public Locutor()
        {
            try
            {
                Engine.SelectVoice(EditorConfig.Ler("VozSelecionada"));
                Engine.Rate = Int32.Parse(EditorConfig.Ler("VelocidadeVoz"));
                Engine.Volume = Int32.Parse(EditorConfig.Ler("VolumeVoz"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar configurações de voz: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }          
        }
        public String getVozSelecionada()
        {
            return (EditorConfig.Ler("VozSelecionada"));
        }
        public String getVelocidadeVoz()
        {
            return (EditorConfig.Ler("VelocidadeVoz"));
        }
        public Int32 getVolumeVoz()
        {
            String volVoz = EditorConfig.Ler("VolumeVoz");
            if (volVoz != "Não Encontrado" && Int32.Parse(volVoz) > 0)
            {
                return (Convert.ToInt32(volVoz));
            }
            return (0);
        }
        public String getFraseTeste()
        {
            return(EditorConfig.Ler("TextBoxTeste"));
        }
        public void setFraseTeste(String frase)
        {
            EditorConfig.Escrever("TextBoxTeste",frase);
        }
        public void setVozSelecionada(String nomeVoz)
        {
            Engine.SelectVoice(nomeVoz);
            try
            {
                EditorConfig.Escrever("VozSelecionada", nomeVoz);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao configurar a voz: " + ex.Message,"Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void setVelocidadeVoz(Int32 velocidadeVoz)
        {
            Engine.Rate = velocidadeVoz;
            EditorConfig.Escrever("VelocidadeVoz", velocidadeVoz.ToString());
        }
        public void setVolumeVoz(Int32 volumeVoz)
        {
            Engine.Volume = volumeVoz;
            EditorConfig.Escrever("VolumeVoz", volumeVoz.ToString());
        }
        public void Parar()
        {
            Engine.SpeakAsyncCancelAll();
        }
        public void Falar(String frase)
        {
            Engine.SpeakAsyncCancelAll();
            Engine.SpeakAsync(frase);
        }
    }
}
