using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var chislo1 = decimal.Parse(this.chislo1.Text);
            var chislo2 = decimal.Parse(this.chislo2.Text);
            var suma = chislo1 + chislo2;
            this.suma.Text = suma.ToString();

        }
    }
}
