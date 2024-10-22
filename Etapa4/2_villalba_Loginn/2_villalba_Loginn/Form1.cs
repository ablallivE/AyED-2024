using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_villalba_Loginn
{
    public partial class Fa : Form
    {
        public Fa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "Enzo2008")
            {
                if (contra.Text == "30enzo30")
                {
                    MessageBox.Show("ingreso permitido");
                }
                else
                {
                    MessageBox.Show("usuario o contraseña invalida");
                }

            }
            else
            {
                MessageBox.Show("usuario o contraseña invalida");
            }
        }

        private void contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            MessageBox.Show(contra.Text);
        }

        private void Fa_Load(object sender, EventArgs e)
        {

        }
    }
}
