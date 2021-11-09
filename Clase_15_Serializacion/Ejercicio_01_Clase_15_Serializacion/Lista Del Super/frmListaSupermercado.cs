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
using System.Xml.Serialization;

namespace Lista_Del_Super
{
    public partial class frmListaSupermercado : Form
    {
        public List<string> listaObjetos;
        private static string rutaArchivo;

        public frmListaSupermercado()
        {

            InitializeComponent();
            listaObjetos = new List<string>();
            string applicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string nombreArchivo = "listaSupermercado.xml";
            rutaArchivo = Path.Combine(applicationData, nombreArchivo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lBoxListaObjetos.SelectedItem != null && lBoxListaObjetos is not null)
            {
                int indiceABorrar = lBoxListaObjetos.SelectedIndex;

                listaObjetos.RemoveAt(indiceABorrar);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaModificacion frmAltaModificacion = new frmAltaModificacion("Agregar Objeto", "", "Agregar");

            if(frmAltaModificacion.ShowDialog() == DialogResult.OK)
            {
                listaObjetos.Add(frmAltaModificacion.txtModificar.Text);
                GuardarDatos();
                ActualizarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(lBoxListaObjetos.SelectedItem != null)
            {
                int indice = lBoxListaObjetos.SelectedIndex;
                frmAltaModificacion frmAltaModificacion = new frmAltaModificacion("Modificar Objeto", lBoxListaObjetos.SelectedItem.ToString(), "Modificar");

                if(frmAltaModificacion.ShowDialog() == DialogResult.OK)
                {
                    listaObjetos.RemoveAt(indice);
                    listaObjetos.Insert(indice,frmAltaModificacion.txtModificar.Text) ;
                    GuardarDatos();
                    ActualizarLista();
                }


            }
        }
        private  void ActualizarLista()
        {
            lBoxListaObjetos.DataSource = null;
            
               lBoxListaObjetos.DataSource = listaObjetos;


        }
        private void frmListaSupermercado_Load(object sender, EventArgs e)
        {
            RecuperarDatos();
            ActualizarLista();
        }
        private void GuardarDatos()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaObjetos.GetType());
                xmlSerializer.Serialize(streamWriter, listaObjetos);
            }
        }

        private void RecuperarDatos()
        {
            using (StreamReader streamReader = new StreamReader(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaObjetos.GetType());
                listaObjetos = xmlSerializer.Deserialize(streamReader) as List<string>;
            }
        } 
    }
}
