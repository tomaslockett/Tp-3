using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

            
            DialogResult resultado = openFileDialog.ShowDialog();

            
            if (resultado == DialogResult.OK)
            {
                try
                {
                    
                    string rutaImagen = openFileDialog.FileName;

                    
                    Image imagen = Image.FromFile(rutaImagen);
                    pictureBox1.Image = imagen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
