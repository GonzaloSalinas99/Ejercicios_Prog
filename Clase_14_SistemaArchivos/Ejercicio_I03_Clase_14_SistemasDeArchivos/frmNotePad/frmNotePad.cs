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

namespace frmNotePad
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile;
        SaveFileDialog saveFile;
        string archivo;

        public Form1()
        {
            InitializeComponent();
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    string archivo = openFile.FileName;

                    using (StreamReader streamReader = new StreamReader(archivo))
                    {
                        richTextBox1.Text = streamReader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }

                
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Archivo de texto|.txt";
            saveFileDialog.ShowDialog();
            string nombreArchivo = saveFileDialog.FileName;
            if(!File.Exists(nombreArchivo))
            {
                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    File.Copy(richTextBox1.Text, nombreArchivo);
                }

                
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "0 caracteres";
        }



        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivo))
            {
                GuardarArchivoFileDialog();
            }
            else
            {
                GuardarArchivo(archivo);
            }
        }

        private void GuardarArchivoFileDialog()
        {
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFile.FileName;
                GuardarArchivo(archivo);
            }
        }

        private void GuardarArchivo(string ruta)
        {
            ruta = saveFile.FileName;

            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.Write(richTextBox1.Text, true);
            }
        }
        private void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString());

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} caracteres";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
