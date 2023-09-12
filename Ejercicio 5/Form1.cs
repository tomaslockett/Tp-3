using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Primonumero(int numero)
        {
            if (numero <= 1)
            { return false; }
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int minimo) && int.TryParse(textBox2.Text, out int maximo))
            {
                if (minimo <= maximo)
                {
                    listBox1.Items.Clear();
                    for (int numero = minimo; numero <= maximo; numero++)
                        if (Primonumero(numero))
                        {
                            listBox1.Items.Add(numero);
                        }
                }

            }
        }
    }
}
