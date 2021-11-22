using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvisameSiCambias
{
    public partial class frmAvisador : Form
    {
        private Persona persona; 


        public frmAvisador()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                btn_Crear.Text = "Actualizar";
            }

            if(txtNombre.Text != persona.Nombre)
            {
                persona.Nombre = txtNombre.Text;
            }
            if(txtApellido.Text != persona.Apellido)
            {
                persona.Apellido = txtApellido.Text;
            }

            lblNombreCompleto.Text = persona.Mostrar();

        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

    }
}
