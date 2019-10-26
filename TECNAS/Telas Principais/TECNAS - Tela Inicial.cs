using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using TECNAS.Classes;
using System.IO;

namespace TECNAS.Telas_Principais
{
    public partial class TECNAS___Tela_Inicial : Form
    {

        public TECNAS___Tela_Inicial()
        {
            InitializeComponent();
            InicializaVoz();
        }
        //Boas Vindas
        public void InicializaVoz()
        {
            Global.Recursos.VozVirtual.Falar(labelBoasVindas.Text);
        }
        //Abre configurações
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TECNAS___Configurações config = new TECNAS___Configurações();
            config.Show();
        }
        //Abre Tela Principal
        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            TECNAS___Tela_Principal telaPrincipal = new TECNAS___Tela_Principal();
            telaPrincipal.Show();
        }
        //Ações Iniciais ao abrir o programa
        private void TECNAS___Tela_Inicial_Load(object sender, EventArgs e)
        {
            timerVerificaConexao.Start();
            ObtemDicionario();
            //buscarDispositivo();
        }
        //Realiza a obtenção do dicionário para o recurso autocompletar
        public void ObtemDicionario()
        {
            String[] palavras = File.ReadAllLines(Global.Diretorios.dicionario);
            foreach(String palavra in palavras)
            {
                Global.Recursos.autoCompleteMenuDicionario.AddItem(palavra);
            }
        }
        //Procura algum Arduino Conectado ao PC
        public void buscarDispositivo()
        {
            if(SerialPort.GetPortNames().Count() == 0)
            {
                Global.Recursos.VozVirtual.Falar("Não foram encontrados dispositivos conectados.");
            }
            foreach(string port in SerialPort.GetPortNames())
            {
                if(tentarConexao(port))
                {
                    labelStatus.Text = "CONECTADO";
                }
                else
                {
                    Global.Recursos.VozVirtual.Falar("Houve um problema ao tentar se conectar. Tente novamente.");
                }
            }
        }
        //Tenta se conectar ao arduino e retorna o resultado da tentativa
        private bool tentarConexao(string port)
        {
            bool sucesso = false;
            if(Arduino.IsOpen)
            {
                Arduino.Close();
            }
            Arduino.PortName = port;
            textBoxConsole.AppendText("Buscando a porta " + port + "\n");
            string leitura = "";
            try
            {
                Arduino.Open();
                Arduino.Write("START");
                leitura = Arduino.ReadLine();
                textBoxConsole.AppendText("Resposta: " + leitura + "\n");
            }
            catch (Exception ex)
            {
                leitura = "";
                textBoxConsole.AppendText("Erro de leitura: " + ex.Message + "\n");
                //throw;
            }
            if (leitura == "OK\r")
            {
                sucesso = true;
                textBoxConsole.AppendText("Dispositivo de digitação conectado.\n");
            }
            else
            {
                textBoxConsole.AppendText("Não foi possível se conectar ao dispositivo.\n");
                Arduino.Close();
            }
            return sucesso;
        }
        //Ação do botão "Buscar Dispositivo"
        private void BuscarDispositivo_Click(object sender, EventArgs e)
        {
            if (!Arduino.IsOpen)
            {
                buscarDispositivo();
            }
            else
            {
                textBoxConsole.AppendText("O dispositivo já está conectado!\n");
                Global.Recursos.VozVirtual.Falar("O dispositivo já está conectado.");
            }
        }
        //Ações realizadas no disparo do temporizador
        private void timerVerificaConexao_Tick(object sender, EventArgs e)
        {
            if (Arduino.IsOpen)
            {
                if(labelStatus.Text != "Conectado")
                {
                    Global.Recursos.VozVirtual.Falar("Dispositivo Conectado.");
                }
                labelStatus.Text = "Conectado";
            }
            else
            {
                if (labelStatus.Text != "Desconectado")
                {
                    Global.Recursos.VozVirtual.Falar("Dispositivo Desconectado.");
                }
                labelStatus.Text = "Desconectado";
            }
        }
        //Animação e descrição por áudio do botão
        private void pictureBoxConfig_MouseHover(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.Falar("Configurações");
            atualizaBorda(pictureBoxConfig);
        }
        //Animação e descrição por áudio do botão
        private void pictureBoxBuscar_MouseHover(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.Falar("Buscar Dispositivo");
            atualizaBorda(pictureBoxBuscar);
        }
        //Animação e descrição por áudio do botão
        private void pictureBoxStart_MouseHover(object sender, EventArgs e)
        {
            Global.Recursos.VozVirtual.Falar("Iniciar Software");
            atualizaBorda(pictureBoxStart);
        }
        //Animação dos botões
        private void atualizaBorda(PictureBox picture)
        {
            pictureBoxBuscar.BorderStyle = BorderStyle.None;
            pictureBoxConfig.BorderStyle = BorderStyle.None;
            pictureBoxStart.BorderStyle = BorderStyle.None;
            picture.BorderStyle = BorderStyle.FixedSingle;
        }

    }
}
