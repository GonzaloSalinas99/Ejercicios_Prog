using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Del_Super
{
    public partial class frmAltaModificacion : Form
    {
        
        public frmAltaModificacion(string titulo,string texto,string textoConfirmacion)
        {
            InitializeComponent();
            this.Text = titulo;
            txtModificar.Text = texto;
            btnConfirmar.Text = textoConfirmacion;
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void txtModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else
            {
                if(e.KeyChar == (char)27)
                {
                    Cancelar();
                }
            }
        }

        private void Confirmar()
        {
            if (!String.IsNullOrWhiteSpace(txtModificar.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Ingresar Informacion");
            }
        }
        private void Cancelar()
        {
            this.DialogResult =DialogResult.Cancel;
            this.Close();
        }

        private void frmAltaModificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
