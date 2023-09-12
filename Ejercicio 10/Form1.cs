using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        private char jugadorActual = 'X';
        private Button[] botones;

        public Form1()
        {
            InitializeComponent();
            InicializarTablero();
        }
        private void InicializarTablero()
        {
            botones = new Button[9];
            int x = 10, y = 10;

            for (int i = 0; i < 9; i++)
            {
                botones[i] = new Button();
                botones[i].Size = new System.Drawing.Size(50, 50);
                botones[i].Location = new System.Drawing.Point(x, y);
                botones[i].Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                botones[i].Tag = i;
                botones[i].Click += new System.EventHandler(this.Casilla_Click);
                this.Controls.Add(botones[i]);

                x += 60;
                if (i == 2 || i == 5)
                {
                    x = 10;
                    y += 60;
                }
            }
        }
        private void CambiarJugador()
        {
            jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
            label1.Text = $"Turno del jugador: {jugadorActual}";
        }
        private void Casilla_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int indice = (int)boton.Tag;

            if (boton.Text == "")
            {
                boton.Text = jugadorActual.ToString();
                CambiarJugador();
            }



        }
    }
}
