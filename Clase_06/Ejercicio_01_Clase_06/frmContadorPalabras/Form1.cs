using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmContadorPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> palabras = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = palabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            
            MostrarPodio(podio);

        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento , KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if(podio.Count==0)
            {
                MessageBox.Show("No ingresaste datos");
            }
            else
            {
                for(int i=0; i<3 && i<podio.Count;i++)
                {
                    foreach (KeyValuePair<string, int> par in podio)
                    {
                        stringBuilder.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                    }

                }
            }
            MessageBox.Show(stringBuilder.ToString(), "Podio");


        }


        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            Dictionary<string, int> palabras = new Dictionary<string, int>();
            string texto = rtbIngresarPalabras.Text;
            string[] cadena = texto.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in cadena)
            {
                if (palabras.ContainsKey(palabra))
                {
                    palabras[palabra]++;
                }
                else
                {
                    palabras.Add(palabra, 1);

                }
            }
            return palabras;
        }
    }
}
