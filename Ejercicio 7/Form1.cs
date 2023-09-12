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

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Interaction.InputBox("ingrese el Monto:"), out double monto) &&
                double.TryParse(Interaction.InputBox("ingrese el Tasa:"), out double tasa) &&
                int.TryParse(Interaction.InputBox("ingrese el Dias:"), out int dias))
            {
                double interes = (monto * tasa * dias) / 36500;

                
                dataGridView1.Rows.Add(monto, tasa, dias, interes);
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos en todos los campos.", "Error");
            }
        }
    }
}
