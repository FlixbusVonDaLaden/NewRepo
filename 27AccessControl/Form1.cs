using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27AccessControl
{
    public partial class Form1 : Form
    {
        private AccessControl ac;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int maxPersons = int.Parse(this.txtMaxCount.Text);
            this.ac = new AccessControl(maxPersons);
            updateGUI();
        }

        public void updateGUI()
        {
            txtCurrentCount.Text = this.ac.CurrentCount.ToString();
            //btnDecrement
            if(this.ac.CurrentCount <= 0)
            {
                this.Decrement.Enabled = false;
            }
            else
            {
                this.Decrement.Enabled = true;
            }
            if (this.ac.canEnter())
            {
                this.Increment.Enabled = true;
            }
            else
            {
                this.Increment.Enabled = false;
            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Increment_Click(object sender, EventArgs e)
        {
            this.ac.increment();
        }

        private void Decrement_Click(object sender, EventArgs e)
        {
            this.ac.decrement();
            updateGUI();
        }
    }
}
