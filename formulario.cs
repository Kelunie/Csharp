using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // esto es para usar el writer

namespace windowsForm
{
    public partial class formulario : Form
    {
        // listas para almacenar los datos
        List<string> names = new List<string>();
        List<string> first = new List<string>();
        List<string> second = new List<string>();
        List<string> prov = new List<string>();
        public formulario()
        {
            InitializeComponent();
        }

        private void formulario_Load(object sender, EventArgs e)
        {
            
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            // agregamos los datos
            string nombre = GetName();
            string fname = getFLname();
            string sname = getSLname();
            string provin = getProvincia();

            // agregamos a la lista
            names.Add(nombre);
            first.Add(fname);
            second.Add(sname);
            prov.Add(provin);

            // limpiamos las casillas
            FLnametxt.Text = "";
            SLnametxt.Text = "";
            nametxt.Text = "";
            provinciacombobox.SelectedItem = null;
        }

        // agregamos los get de los formularios, para usarlos despues
        public string GetName()
        {
            return nametxt.Text;
        }
        public string getFLname()
        {
            return FLnametxt.Text;
        }
        public string getSLname()
        {
            return SLnametxt.Text;
        }
        public string getProvincia()
        {
            // condicional si el combobox no es selecionado
            if (provinciacombobox.SelectedItem != null)
            {
                return provinciacombobox.SelectedItem.ToString();
            }
            else
            {
                return "No selected provincia";
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            // guardar los datos en csv
            try
            {
                using (StreamWriter writer = new StreamWriter("D:\\programming\\c#\\windowsForm\\csv\\formularios.csv", true))
                {
                    // escribir los datos de las listas en el csv
                    for (int i = 0; i < names.Count; i++)
                    {
                        writer.WriteLine($"{names[i]};{first[i]};{second[i]};{prov[i]}");
                    }
                }

                // mensajito de que los datos se guardaron
                MessageBox.Show("Datos guardados correctamente en el archivo CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos en el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
