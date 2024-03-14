using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Listado_de_tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnEntrada.Text))
            {
                // Crea un nuevo Label y un CheckBox
                Label nuevoLabel = new Label();
                CheckBox nuevoCheckBox = new CheckBox();

                // Configura el texto y el estilo del Label
                nuevoLabel.Text = btnEntrada.Text;
                nuevoLabel.Font = new Font("Arial", 12); // Tamaño de fuente 12, tipo de fuente Arial
                nuevoLabel.BackColor = Color.White; // Establece el fondo transparente
                nuevoCheckBox.BackColor = Color.White; // Establece el fondo transparente

                // Ajusta el Padding del CheckBox para reducir el espacio en blanco
                nuevoCheckBox.Padding = new Padding(0);

                // Establece AutoSize en false para el CheckBox
                nuevoCheckBox.AutoSize = false;

                // Encuentra la posición vertical del último CheckBox y Label en el formulario
                int ultimoCheckBoxTop = 2;
                foreach (Control control in Controls)
                {
                    if (control is CheckBox || control is Label)
                    {
                        ultimoCheckBoxTop = Math.Max(ultimoCheckBoxTop, control.Bottom);
                    }
                }

                // Agrega el nuevo CheckBox y Label al formulario
                Controls.Add(nuevoCheckBox);
                Controls.Add(nuevoLabel);

                // Establece la ubicación del nuevo CheckBox y Label
                nuevoCheckBox.Left = 82; // Separación de 5 unidades desde el borde izquierdo del formulario
                nuevoCheckBox.Top = ultimoCheckBoxTop + 10; // Mueve el nuevo CheckBox un poco más abajo del último CheckBox
                nuevoCheckBox.Width = 20; // Ajusta el ancho del CheckBox
                nuevoLabel.Left = nuevoCheckBox.Right + 5; // Separación de 5 unidades entre el CheckBox y el Label
                nuevoLabel.Top = ultimoCheckBoxTop + 12;

                // Asegúrate de que los controles recién creados estén en la parte superior
                nuevoCheckBox.BringToFront();
                nuevoLabel.BringToFront();

                // Limpia el TextBox después de agregar el texto
                btnEntrada.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa algún texto en el TextBox.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

