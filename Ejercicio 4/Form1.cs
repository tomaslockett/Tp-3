using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero1) && int.TryParse(textBox2.Text, out int numero2))
            {
                double resultado = 0;
                resultado = numero1 + numero2;
                textBox3.Text = resultado.ToString();
                resultado = 0;
                resultado = numero1 - numero2;
                textBox4.Text = resultado.ToString();
                resultado = 0;
                resultado = numero1 * numero2;
                textBox5.Text = resultado.ToString();
                resultado = 0;
                if (numero2 != 0) 
                {
                    resultado = numero1 / numero2;
                    textBox6.Text = resultado.ToString();
                }
                else
                {
                    textBox6.Text = "No se puede calcular";
                }
                resultado = 0;
                resultado = Math.Pow(numero1,numero2);
                textBox7.Text = resultado.ToString();
                if (numero1 >= 0)
                {
                    resultado = Math.Sqrt(numero1);
                    textBox8.Text = resultado.ToString();
                }
                else
                {
                    textBox8.Text = "No se puede calcular";
                    return;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
