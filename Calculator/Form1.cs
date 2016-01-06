using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public int a { get; set; }
        public int b { get; set; }

        public Calculator()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            if (txtBox.Text.Count(x => x == '.') > 0)
            {
                btnPoint.Enabled = false;
            }
            Button button = (Button)sender;
            txtBox.Text = txtBox.Text + button.Text;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtBox.Text);
            txtBox.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            b = int.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Text = (a + b).ToString();
        }
    }
}
