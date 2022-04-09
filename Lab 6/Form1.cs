using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string num_s = "";
            char[] c = s.ToCharArray();
            foreach (char ch in c)
            {
                if (char.IsNumber(ch))
                {
                    num_s += ch + " ";
                }
            }
            num_s = num_s.Trim();
            label1.Text = num_s;
        }
    }
}
