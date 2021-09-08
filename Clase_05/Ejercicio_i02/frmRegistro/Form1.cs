using System;
using System.Windows.Forms;
using Biblioteca;

namespace frmRegistro
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbPais.Items.Add("Argentina");
            lbPais.Items.Add("Uruguay");
            lbPais.Items.Add("Chile");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
//            Ingresante usuario = new Ingresante();

            string nombre;
            string direccion;
            string pais;
            string[] Cursos;
            string genero;
            int edad;
            if(Ingresante.setNombre(textNombre.Text) && Ingresante.setDireccion(textDireccion.Text) && Ingresante.setGenero(gbGenero.Text) && Ingresante.setEdad(numEdad.Text) && 
                Ingresante.setPais(lbPais.Text) && Ingresante.setNombre(gb))
            {
                nombre = textNombre.Text;
            }
            else
            {
                MessageBox.Show("No ingreso el nombre", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
