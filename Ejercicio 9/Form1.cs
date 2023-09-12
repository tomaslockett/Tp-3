using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<int> resultados = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tirada1 = TirarDado();
            int tirada2 = TirarDado();

            int suma = tirada1 + tirada2;

            resultados.Add(suma);

            textBox1.Text =Convert.ToString(tirada1);
            textBox2.Text =Convert.ToString(tirada2);

            ActualizarGrilla();

        }

        private int TirarDado()
        {
            return random.Next(1, 7);
        }
        private void ActualizarGrilla()
        {

            dataGridView1.Rows.Clear();


            Dictionary<int, int> conteoResultados = new Dictionary<int, int>();

            foreach (int resultado in resultados)
            {
                if (conteoResultados.ContainsKey(resultado))
                {
                    conteoResultados[resultado]++;
                }
                else
                {
                    conteoResultados[resultado] = 1;
                }
            }


            int totalTiradas = resultados.Count;


            foreach (var kvp in conteoResultados)
            {
                int resultado = kvp.Key;
                int cantidad = kvp.Value;
                double porcentaje = (double)cantidad / totalTiradas * 100;

                dataGridView1.Rows.Add(resultado, cantidad, porcentaje.ToString("0.00") + "%");
            }
        }
    }
}
