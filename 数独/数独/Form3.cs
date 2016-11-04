using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数独
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form g=new Form1();
            this.Visible=false;
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form g = new Form2();
            this.Visible = false;
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form g = new Form4();
            this.Visible = false;
            g.Show();
        }
    }
}
