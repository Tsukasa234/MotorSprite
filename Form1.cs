using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorSprite
{
    public partial class Form1 : Form
    {
        private Bitmap resultante;
        private int anchoVentana, altoVentana;

        private NCEngine motor;

        //Variables para el double buffer y evitar el flicker
        private Bitmap dBufferBMP;
        private Graphics dBufferDC; //Es una superficie de dibujo del GDI

        //Variables para el ejemplo
        private int cx = 100, cy = 0;

        private NCSprite uno = new NCSprite(100, 100, 80, 60, "Sprite0.png", 0, 0, true, true);
        private NCSprite dos = new NCSprite(250, 200, 80, 60, "Sprite0.png", 0, 0, true, true);

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (simulaToolStripMenuItem.Checked == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por Tsukasa234");
        }

        private void procesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
