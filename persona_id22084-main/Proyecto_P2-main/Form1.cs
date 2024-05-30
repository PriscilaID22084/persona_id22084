using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDOS");
        } // Guardar
        private void validar_Click(object sender, EventArgs e)
        {
            // Obtiene la ruta del directorio base del proyecto
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            // Imprimimos la ruta, para conocer donde se encuentra nuestro directorio
            Console.WriteLine("Ruta base: " + directorioBase);


            string rutaImagenRelativa = "";

            if (btn_radio_empleado.Checked)
            {
                // Cuando seleccionamos el perfil de empleado habilitamos el campo de sueldo
             

                // Convinamos la dos rutas en donde tenemos nuestro proyecto y donde tenemos guardado nuestras imagenes
                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\empleado.jpg");
            }
            if (btn_radio_alumno.Checked)
            {
                // Cuando seleccionamos el perfil de alumno desabilitamos el campo de sueldo
               
                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\estudiante.png");
            }
            if (btn_radio_docente.Checked)
            {
                // Cuando seleccionamos el perfil de empleado habilitamos el campo de sueldo
               

                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\docente.jpg");
            }


            // Optenemos la ruta completa, desde la ubicacion del disco hasta donde se encuentra nuestra imagen para mostrar la imagen en el picturebox
            string rutaImagenAbsoluta = Path.GetFullPath(rutaImagenRelativa);
            Console.WriteLine(rutaImagenAbsoluta);


            if (System.IO.File.Exists(rutaImagenAbsoluta))
            {
                // Carga la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(rutaImagenAbsoluta);
            }




        } // Validad

        private void guardar_Click_1(object sender, EventArgs e)
        {
            if (btn_radio_alumno.Checked)
            {

                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
            }
            else
            {
                if (btn_radio_empleado.Checked)
                {

                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else if (btn_radio_docente.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Docente docente = new Docente(nom, edad, fech, puesto, sueldo);
                }
                else
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                }
            }
        } // Guardar

        private void guardar_Click_2(object sender, EventArgs e)
        {
            // Enviamos un messagebox, para mostrar informacion al usuario que sus datos han sido guardados
            MessageBox.Show("Datos del usuario guardado con exito", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de borrar las cajas de texto

            // Llamamos al nombre de nuestro textbox y llamando a su metodo Clear(), para poder limpiar el textbox
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            // Llamamos al nombre del radio button y colocamos su propiedad Checked en false
            btn_radio_alumno.Checked = false;
            btn_radio_docente.Checked = false;
            btn_radio_empleado.Checked = false;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            // this hace referencia a la ventana  actuala, llamamos su metodo close para cerrar la ventana
            this.Close();
        }
    } // FORM

} // namespace
