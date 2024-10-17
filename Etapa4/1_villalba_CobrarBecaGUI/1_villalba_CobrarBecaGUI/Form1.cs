using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_villalba_CobrarBecaGUI
{
    public partial class monto : Form
    {
        public monto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) >= 19)  
            {
                if (ingresos.Text == "100,001 - 200,000" || ingresos.Text == "Más de 200,000")
                {
                    MessageBox.Show("la beca ha sido aceptada");
                }
                else
                {
                    MessageBox.Show("la beca ha sido rechazada\n ingresos invalidos");
                }
            }
            else
            {
                MessageBox.Show("la beca ha sido rechazada\n edad invalida");
            }
        }
    }
}
