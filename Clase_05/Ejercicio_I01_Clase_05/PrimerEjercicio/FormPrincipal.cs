using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerEjercicio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre="";
            string materiaFavorita="";
            string apellido="";
            if (textNombre.Text == "")
            {
                MessageBox.Show("No escribiste tu nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 nombre = textNombre.Text;
            }

            if (textApellido.Text =="")
            {
                MessageBox.Show("No escribiste tu apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                apellido = textApellido.Text;
            }


            if (String.IsNullOrWhiteSpace(cmbMaterias.Text))
            {
                MessageBox.Show("No escribiste tu materia favorita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                 materiaFavorita = cmbMaterias.Text;

            }
            if(nombre!="" && apellido!="" && materiaFavorita!="")
            {
                string titulo = "Hola, Windows Forms";
                string mensaje = $"Soy {nombre} {apellido} y mi materia favorita es: {materiaFavorita}";


                FrmSaludo frmSaludo = new FrmSaludo(titulo, mensaje);
                frmSaludo.ShowDialog(); //MODAL, no puedo interactuar con el resto
            }
            //MessageBox.Show(txtNombre.Text);

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            cmbMaterias.Items.Add("Programacion");
            cmbMaterias.Items.Add("Laboratorio");
            cmbMaterias.Items.Add("Matemática");
            cmbMaterias.Items.Add("Sist. Procesamiento de Datos");
            cmbMaterias.Items.Add("Ingles I");
            cmbMaterias.Items.Add("Programacion II");
            cmbMaterias.Items.Add("Laboratorio II");
            cmbMaterias.Items.Add("Ingles II");
        }


    }
}
