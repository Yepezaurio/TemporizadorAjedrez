using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemporizadorAjedrez
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
                cbMinutos.Items.Add(i);
                cbSegundos.Items.Add(i);
                if (i < 24)
                {
                    cbHoras.Items.Add(i);
                }
            }
            cbSegundos.SelectedIndex = 0;
            cbMinutos.SelectedIndex = 0;
            cbHoras.SelectedIndex = 0;
            
        }

        int iHora1, iHora2;
        int iMinuto1, iMinuto2;
        int iSegundo1, iSegundo2;

        

        private void btIniciar_Click(object sender, EventArgs e)
        {
        }

        private void btJugador1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ( btJugador1.Text == "Iniciar")
            {
                iHora1 = cbHoras.SelectedIndex;
                iMinuto1 = cbMinutos.SelectedIndex;
                iSegundo1 = cbSegundos.SelectedIndex;
                iHora2 = cbHoras.SelectedIndex;
                iMinuto2 = cbMinutos.SelectedIndex;
                iSegundo2 = cbSegundos.SelectedIndex;
                btJugador1.Text = "Esperando";
                btJugador2.Select();
                timer2.Start();
                btJugador2.Text = "Tu turno";
                button1.Enabled = false;
                btPausar.Enabled = true;
            }
            if ( btJugador1.Text == "Jugador Blancas")
            {
                iHora1 = cbHoras.SelectedIndex;
                iMinuto1 = cbMinutos.SelectedIndex;
                iSegundo1 = cbSegundos.SelectedIndex;
            }
            if (e.KeyChar == Convert.ToChar("z"))
            {
              if (btJugador1.Text == "Tu turno")
                {
                    timer1.Stop();
                    btJugador1.Text = "Esperando";
                    btJugador2.Select();
                    timer2.Start();
                    btJugador2.Text = "Tu turno";
                }
                else
                {
                    timer1.Stop();
                }
                
            }
        }

        private void btJugador2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (btJugador2.Text == "Iniciar")
            {
                iHora2 = cbHoras.SelectedIndex;
                iMinuto2 = cbMinutos.SelectedIndex;
                iSegundo2 = cbSegundos.SelectedIndex;
                iHora1 = cbHoras.SelectedIndex;
                iMinuto1 = cbMinutos.SelectedIndex;
                iSegundo1 = cbSegundos.SelectedIndex;
                btJugador2.Text = "Esperando";
                btJugador1.Select();
                timer1.Start();
                btJugador1.Text = "Tu turno";
                button1.Enabled = false;
                btPausar.Enabled = true;
            }
            if (btJugador2.Text == "Jugador Negras")
            {
                iHora2 = cbHoras.SelectedIndex;
                iMinuto2 = cbMinutos.SelectedIndex;
                iSegundo2 = cbSegundos.SelectedIndex;
                btJugador2.Text = "Esperando";
                btJugador1.Select();
                timer1.Start();
                btJugador1.Text = "Tu turno";
                timer2.Stop();
            }
            
            if (e.KeyChar == Convert.ToChar("l"))
            {

                if (btJugador2.Text == "Tu turno")
                {
                    timer2.Stop();
                    btJugador2.Text = "Esperando";
                    btJugador1.Select();
                    timer1.Start();
                    btJugador1.Text = "Tu turno";
                }
                else
                {
                    timer2.Stop();
                }

            }
        }

        private void Z(object sender, EventArgs e)
        {
            if (btJugador2.Text == "Tu turno")
            {
                timer2.Stop();
                btJugador2.Text = "Esperando";
                btJugador1.Select();
                timer1.Start();
                btJugador1.Text = "Tu turno";
            }
            else
            {
                timer2.Stop();
            }
        }

        private void btJugador2_Click(object sender, EventArgs e)
        {
            if (btJugador1.Text == "Tu turno")
            {
                timer1.Stop();
                btJugador1.Text = "Esperando";
                btJugador2.Select();
                timer2.Start();
                btJugador2.Text = "Tu turno";
            }
            else
            {
                timer1.Stop();
            }
        }

        private void cbHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHoras.Text != "0")
            {
                if(btJugador1.Text == "Iniciar")
                {
                    btJugador1.Select();
                }
                else
                {
                    btJugador2.Select();
                }
            }
        }

        private void cbMinutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMinutos.Text != "0")
            {
                if (btJugador1.Text == "Iniciar")
                {
                    btJugador1.Select();
                }
                else
                {
                    btJugador2.Select();
                }
            }
        }

        private void cbSegundos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSegundos.Text != "0")
            {
                if (btJugador1.Text == "Iniciar")
                {
                    btJugador1.Select();
                }
                else
                {
                    btJugador2.Select();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "Blancas --->")
            {
                button1.Text = "<--- Blancas";
                btJugador2.Text = "Iniciar";
                btJugador1.Text = "Jugador Blancas";
                pictureBox1.Image = TemporizadorAjedrez.Properties.Resources.piezas_de_ajedres;
                pictureBox2.Image = TemporizadorAjedrez.Properties.Resources.blanca;
                
            }
            else
            {
                button1.Text = "Blancas --->";
                btJugador1.Text = "Iniciar";
                btJugador2.Text = "Jugador Negras";
                pictureBox1.Image = TemporizadorAjedrez.Properties.Resources.blanca;
                pictureBox2.Image = TemporizadorAjedrez.Properties.Resources.piezas_de_ajedres;
                
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {

            lbTemporizadorjg1.Text = "00:00:00";
            lbTemporizadorjg2.Text = "00:00:00";
            iHora1 = 0;
            iHora2 = 0;
            iMinuto1 = 0;
            iMinuto2 = 0;
            iSegundo1 = 0;
            iSegundo2 = 0;
            pictureBox1.Image = TemporizadorAjedrez.Properties.Resources.blanca;
            pictureBox2.Image = TemporizadorAjedrez.Properties.Resources.piezas_de_ajedres;
            btJugador1.Text = "Iniciar";
            btJugador2.Text = "Jugador Negras";
            button1.Enabled = true;
            btPausar.Enabled = false;
            btPausar.Text = "Pausar";
            btJugador2.BackColor = Color.Empty;
            btJugador1.BackColor = Color.Empty;
            cbHoras.SelectedIndex = 0;
            cbMinutos.SelectedIndex = 0;
            cbSegundos.SelectedIndex = 0;
            button1.Text = "Blancas --->";

        }

        private void btPausar_Click(object sender, EventArgs e)
        {
            if (btPausar.Text == "Pausar")
            {
                timer1.Stop();
                timer2.Stop();
                btPausar.Text = "Reanudar";
            }
            else
            {
                timer1.Start();
                timer2.Start();
                btPausar.ForeColor = Color.RoyalBlue;
                btPausar.Text = "Pausar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Me va ir restando los segundos.
            
           
            /*
             * Son variables String para que pueda mostrar los numeros
             en los labels de donde  esta el Temporizador.
            */
            
            string sMinuto1 = iMinuto1.ToString();
            string sSegundo1 = iSegundo1.ToString();
            string sHora1 = iHora1.ToString();
           

            /* Condiciones Para Cuando sea menor el tiempo de 10 
               Y se vea como un temporizador normal 00:00:00 En caso
               de no tener estas condiciones al poner el segundo nueve 
               se ve de la sig manera 00:00:90 <- Segundo nueve
               y al hacer estas condiciones afuerza tiene que dar 00:00:09
            */
            if (iHora1 < 10)
            {
                sHora1 = "0" + iHora1.ToString();
            }
            if (iMinuto1 < 10)
            {
                sMinuto1 = "0" + iMinuto1.ToString();
            }
            if (iSegundo1 < 10)
            {
                sSegundo1 = "0" + iSegundo1.ToString();
            }
            // Este codigo es para descontar Minutos
            if (iSegundo1 == 0 && iMinuto1 > 0)
            {
                iSegundo1 = 60;
                iMinuto1 -= 1;
            }
            
            // Este codigo es para descontar Horas
            if ( iMinuto1 == 0 && iHora1 > 0 && iSegundo1 == 0)
            {
                iSegundo1 = 60;
                iMinuto1 = 59;
                iHora1 -= 1;
            }
            

            if ( iMinuto1 == 0 && iHora1 == 0 && iSegundo1 == 0)
            {

                timer1.Stop();
                if (button1.Enabled == false)
                {
                    btJugador1.Text = "Perdiste";
                    btJugador1.BackColor = Color.Red;
                    btJugador2.Text = "Ganaste";
                    btJugador2.BackColor = Color.Green;
                    btPausar.Enabled = false;
                    

                }
                
            }
            iSegundo1 -= 1;
            lbTemporizadorjg1.Text = sHora1 + ":" + sMinuto1 + ":" + sSegundo1;

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            

            string sMinuto2 = iMinuto2.ToString();
            string sSegundo2 = iSegundo2.ToString();
            string sHora2 = iHora2.ToString();

            if (iHora2 < 10)
            {
                sHora2 = "0" + iHora2.ToString();
            }
            if (iMinuto2 < 10)
            {
                sMinuto2 = "0" + iMinuto2.ToString();
            }
            if (iSegundo2 < 10)
            {
                sSegundo2 = "0" + iSegundo2.ToString();
            }

            if (iSegundo2 == 0 && iMinuto2 > 0)
            {
                iSegundo2 = 60;
                iMinuto2 -= 1;
            }

            if (iMinuto2 == 0 && iHora2 > 0 && iSegundo2 == 0)
            {
                iSegundo2 = 60;
                iMinuto2 = 59;
                iHora2 -= 1;
            }
            
            if (iMinuto2 == 0 && iHora2 == 0 && iSegundo2 == 0)
            {
                timer2.Stop();
                if(button1.Enabled == false)
                {
                    btJugador2.Text = "Perdiste";
                    btJugador2.BackColor = Color.Red;
                    btJugador1.Text = "Ganaste";
                    btJugador1.BackColor = Color.Green;
                    
                }
               
                
                btPausar.Enabled = false;
            }
            iSegundo2 -= 1;
            lbTemporizadorjg2.Text = sHora2 + ":" + sMinuto2 + ":" + sSegundo2;
        }
    }
}
