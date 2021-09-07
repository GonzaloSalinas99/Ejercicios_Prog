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
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            //MessageBox.Show(txtNombre.Text);
            string titulo = "Hola, Windows Forms";
            string mensaje = $"Soy {nombre} {apellido}";


            FrmSaludo frmSaludo = new FrmSaludo(titulo, mensaje);
            frmSaludo.ShowDialog(); //MODAL, no puedo interactuar con el resto
        }
    }
}
