using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLinkLabel_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mylinklabel1.Text = "Hesap M.";
            mylinklabel1.ForeColor = Color.Orange;
            mylinklabel2.Text = "Onedio";
            mylinklabel2.ForeColor = Color.Purple;
           
        }

       
        private void mylinklabel1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("calc.exe");
        }

        private void mylinklabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.onedio.com");
        }
    }
}
