using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECNAS.PoupUps
{
    public partial class PoupUpTexto : Form
    {
        public PoupUpTexto(String titulo, String rotulo)
        {
            InitializeComponent();
            Text = titulo;
            label1.Text = rotulo;
        }

        private void PoupUpTexto_Load(object sender, EventArgs e)
        {

        }

        public String getTexto()
        {
            return (textBox1.Text);
        }

        public void setTexto(String texto)
        {
            textBox1.Text = texto;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                buttonOK_Click(sender, e);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
