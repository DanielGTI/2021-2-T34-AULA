using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //  MessageBox.Show("Apertando o botão do mouse.","Alerta 1"); 
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Soltei o botao do mouse.");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Tchau!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("virus instalado... hahahaha");
            MessageBox.Show("Instalação cancelada.");
        }
    }
}
