using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Propiedades> propiedades = new List<Propiedades>();
        List<Propietarios> propietarios = new List<Propietarios>();
        List<Datos> datos = new List<Datos>();

        private void button1_Click(object sender, EventArgs e)
        {
            String fileName = "Propiedades.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propiedades propiedadess = new Propiedades();
                propiedadess.NoCasa = Convert.ToInt32(reader.ReadLine());
                propiedadess.CuotaMant = Convert.ToInt32(reader.ReadLine());
                
            }


        }



        public void MostrarDatos()
        {

            //mostrar la lista de empleados en el gridview 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

    }
}
