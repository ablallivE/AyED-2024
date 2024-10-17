using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0_villalba_celcius
{
    public partial class front : Form
    {
        public front()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gradof.Text = (float.Parse(gradoconverjente.Text) * 18 / 10 + 32).ToString();
            gradoK.Text = ((float.Parse(gradoconverjente.Text) + 273).ToString());
            gradof.Visible = true;
            gradoK.Visible = true;
            gragas.Visible = true;
        }
    }
}
