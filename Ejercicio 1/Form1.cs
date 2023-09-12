using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valores1 = 0, valores2 = 0;
            valores1 = Convert.ToInt32(Interaction.InputBox("Ingrese el primer numero:"));
            valores2 = Convert.ToInt32(Interaction.InputBox("Ingrese el Segundo numero:"));
            int resultado= valores1 + valores2;
            string trueResultado = resultado.ToString();
            string TextoCreado = string.Format("Resultado: {0}",trueResultado);
            label2.Text = TextoCreado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
