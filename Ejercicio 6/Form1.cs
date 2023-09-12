using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int numero))
            {
                if (numero >= 1)
                {
                    textBox2.Clear();

                    long a = 0;
                    long b = 1;
                    for (int i = 0; i < numero; i++)
                    {
                        textBox2.AppendText(a.ToString() + " ");
                        long temp = a;
                        a = b;
                        b = temp + b;
                    }
                }
                else
                {
                    MessageBox.Show("El número debe ser mayor o igual a 1.", "Error");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error");
            }
        }
    }
}
