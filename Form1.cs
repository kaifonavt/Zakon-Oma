using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == null)^(textBox2.Text == null)) { MessageBox.Show("Error", "enter all data"); } 
            else { 
                float u = Convert.ToInt32(textBox1.Text);
                float r = Convert.ToInt32(textBox2.Text);
                float i = u / r;
                textBox3.Text = i.ToString();
            }
        }
    }
}
