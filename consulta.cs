using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO; // para usar el textfieldparser

namespace windowsForm
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void databtn_Click(object sender, EventArgs e)
        {
            // nombre del archivo CSV que vamos a leer
            string filePath = "D:\\programming\\c#\\windowsForm\\csv\\formularios.csv";

            // creamos un nuevo textfield para leer el archivo
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                // establecemos el delimitador del archivo
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                // leer la primera linea del archivo (cabezera) si es necesario
                // si no tiene cabecera el archivo pues no es necesario, puedes omitir estas lineas
                // string[] field = parser.GetFields();

                // leemos el resto del archivo
                while (!parser.EndOfData)
                {
                    // leer una linea y dividirla
                    // Nota si usas el truco para leer la cabecera en caso necesario, quita la declaration de la variable
                    string[] fields = parser.ReadFields();

                    // agregar una nueva fila al DataGridView y asignar los datos
                    dataGridView1.Rows.Add(fields);

                }
            }
        }
    }
}
