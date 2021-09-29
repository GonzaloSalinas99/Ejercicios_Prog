using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRAPAME_SI_PUEDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if(textBox1.Text == "" || textBox2.Text == "")
                {
                    throw new ParametrosVaciosException("NO INGRESO NINGUN VALOR");
                }
                richTextBox1.Text = $"KM / HS: {Calculador.Calcular(int.Parse(textBox1.Text), int.Parse(textBox2.Text))}";

            }
            catch (ParametrosVaciosException exc)
            {
                MessageBox.Show($"{exc.Message}");
            }
            catch(FormatException format)
            {
                MessageBox.Show(format.Message);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
