using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string escalaInicial = comboBox1.SelectedItem.ToString();
            string escalaFinal = comboBox2.SelectedItem.ToString();
            double cantidad = double.Parse(textBox1.Text);


            double resultado = ConvertirTemperatura(escalaInicial, escalaFinal, cantidad);


            dataGridView1.Rows.Add(escalaInicial, escalaFinal, cantidad, resultado);
        }
        
        private double ConvertirTemperatura(string escalaInicial, string escalaFinal, double cantidad)
        {
            
            switch (escalaInicial)
            {
                case "Celsius":
                    switch (escalaFinal)
                    {
                        case "Fahrenheit":
                            return (cantidad * 9 / 5) + 32;
                        case "Kelvin":
                            return cantidad + 273.15;
                        case "Rankine":
                            return (cantidad + 273.15) * 9 / 5;
                        default:
                            return cantidad;
                    }

                case "Fahrenheit":
                    switch (escalaFinal)
                    {
                        case "Celsius":
                            return (cantidad - 32) * 5 / 9;
                        case "Kelvin":
                            return (cantidad + 459.67) * 5 / 9;
                        case "Rankine":
                            return cantidad + 459.67;
                        default:
                            return cantidad;
                    }

                case "Kelvin":
                    switch (escalaFinal)
                    {
                        case "Celsius":
                            return cantidad - 273.15;
                        case "Fahrenheit":
                            return (cantidad * 9 / 5) - 459.67;
                        case "Rankine":
                            return cantidad * 9 / 5;
                        default:
                            return cantidad;
                    }

                case "Rankine":
                    switch (escalaFinal)
                    {
                        case "Celsius":
                            return (cantidad - 491.67) * 5 / 9;
                        case "Fahrenheit":
                            return cantidad - 459.67;
                        case "Kelvin":
                            return cantidad * 5 / 9;
                        default:
                            return cantidad;
                    }

                default:
                    return cantidad;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
