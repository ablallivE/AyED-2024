using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Villalba_Menu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            label3.Text = textBox2.Text;
            label6.Text = (int.Parse(label2.Text) * int.Parse(label3.Text)).ToString();
            label2.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 pantalla1 = new Form1();
            pantalla1.Show();
            this.Hide();
        }
    }
}
