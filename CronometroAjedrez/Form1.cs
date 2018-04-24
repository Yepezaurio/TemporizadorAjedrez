using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronometroAjedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                minutos.Items.Add(i);
                segundos.Items.Add(i);
                if (i < 24)
                horas.Items.Add(i); 
            }
            minutos.SelectedIndex = 0;
            segundos.SelectedIndex = 0;
            horas.SelectedIndex = 0; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int hora;
        int min;
        int seg;
        private void button1_Click(object sender, EventArgs e)
        {
            if(btIniciar.Text == "Iniciar")
            {
                timer1.Start();
                btIniciar.ForeColor = Color.Green;
                btDetener.Enabled = true;
                hora = horas.SelectedIndex;
                min = minutos.SelectedIndex;
                seg = segundos.SelectedIndex;
                btIniciar.Text = "Restablecer";
            }
            else
            {
                timer1.Stop();
                hora = 0;
                seg = 0;
                min = 0;
                lbTiempo.Text = "00:00:00";
                btIniciar.ForeColor = Color.ForestGreen;
                btDetener.Enabled = false;
                btDetener.ForeColor = Color.RoyalBlue;
                btDetener.Text = "Pausar";
                btIniciar.Text = "Iniciar";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btDetener.Text  == "Pausar")
            {
                timer1.Stop();
                btDetener.ForeColor = Color.DarkOrange;
                btDetener.Text = "Reanudar";
            }
            else
            {
                timer1.Start();
                btDetener.ForeColor = Color.RoyalBlue;
                btDetener.Text = "Pausar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg -= 1;
            
            
            string minutos = min.ToString();
            string horas = hora.ToString();
            string segundos = seg.ToString();

            if (hora < 10)
            {
                horas = "0" + hora.ToString();
            }
            if (min < 10)
            {
                minutos = "0" + min.ToString();
            }
            if (seg < 10)
            {
                segundos = "0" + seg.ToString();
            }

            if ( seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }
            if ( min == 0 && hora > 0 && seg == 0)
            {
                seg = 60;
                hora -= 1;
                min = 59;
            }
            if (min == 0 && hora == 0 && seg == 0)
            {
                timer1.Stop();
                btIniciar.ForeColor = Color.ForestGreen;
                btDetener.Enabled = false;
                btDetener.ForeColor = Color.RoyalBlue;
                btDetener.Text = "Pausar";
                btIniciar.Text = "Iniciar";

            }
            lbTiempo.Text = horas + ":" + minutos + ":" + segundos; 
        }

        private void segundos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
