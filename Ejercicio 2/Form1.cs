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

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = 0, valor2 = 0;
            valor1 = Convert.ToInt32(Interaction.InputBox("ingrese el primer numero:"));
            valor2 = Convert.ToInt32(Interaction.InputBox("ingrese el segundo numero:"));
            int resultado = valor1 + valor2;
            string trueresultado = string.Format("Resultado: {0}", resultado);
            
            MessageBox.Show($"{trueresultado}");
        }
    }
}
