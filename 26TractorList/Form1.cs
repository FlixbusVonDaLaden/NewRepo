using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26TractorList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.txtList.Text += this.txtMarke.Text + " " + this.txtBez.Text + " -> " + this.txtPower.Text + " PS" + "\r\n";
            this.txtMarke.Text = "";
            this.txtBez.Text = "";
            this.txtPower.Text = "";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            this.txtList.Text = "";
        }

        private void txtMarke_TextChanged(object sender, EventArgs e)
        {
            if(this.txtMarke.Text != "" && this.txtBez.Text != "" && this.txtPower.Text != "")
            {
                this.btnadd.Enabled = true;
            }
            else
            {
                this.btnadd.Enabled = false; 
            }
        }
    }
}
