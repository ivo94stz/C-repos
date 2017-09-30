using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void smetni_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(this.X.Text);
            var num2 = decimal.Parse(this.Y.Text);
            var sum = num1 + num2;
            result.Text = sum.ToString();

        }
    }
}
