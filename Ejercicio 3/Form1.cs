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

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            cantidad = Convert.ToInt32(Interaction.InputBox("ingrese la cantidad de numeros que quiere ingresar:"));
            int[] vector = new int[cantidad];
            for(int i = 0; i < vector.Length; i++) 
            {
                string entrada = Interaction.InputBox($"ingrese el numero {i}");
                if(int.TryParse(entrada, out int numero)) 
                {
                    vector[i] = numero;
                }
                else
                {
                    MessageBox.Show("Flaco pone un numero valido");
                    return;
                }
                
                textBox1.Text=string.Join(", ", vector);

                int suma = 0;
                for(int n =0; n < vector.Length; n++)
                {
                    suma += vector[n];
                }
                label1.Text = $"Suma: {suma}";

            }

        }
    }
}
