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

        private void txtMaxCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int maxPersons = int.Parse(this.txtMaxCount.Text);
                this.ac = new AccessControl(maxPersons);
                updateGUI();
            }
            catch(Exception ex)
            {
                //nichts tun
                this.ac = new AccessControl(0);
                updateGUI();
            }
        }

        public void updateGUI()
        {
            this.txtIncrementMultiple.Text = "";
            this.txtDecrementMultiple.Text = "";
            this.txtCurrentCount.Text = this.ac.CurrentCount.ToString();
            if(this.ac.CurrentCount <= 0)
            {
                this.btnDecrement.Enabled = false;
            }
            else
            {
                this.btnDecrement.Enabled = true;
            }

            //this.btnDecrement.Enabled = !(this.ac.CurrentCount <= 0);

            //if (this.ac.canenter())
            //{
            //    this.btnincrement.enabled = true;
            //}
            //else
            //{
            //    this.btnincrement.enabled = false;
            //}

            this.btnIncrement.Enabled = this.ac.canEnter();


        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            this.ac.increment();
            updateGUI();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            this.ac.decrement();
            updateGUI();
        }

        private void btnIncrementMultiple_Click(object sender, EventArgs e)
        {
            int persons = int.Parse(this.txtIncrementMultiple.Text);
            this.ac.increment(persons);
            updateGUI();
        }

        private void txtIncrementMultiple_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int multiplePersons = int.Parse(this.txtIncrementMultiple.Text);
                if (this.ac.canEnter(multiplePersons))
                {
                    //hier geht nach Ostern weiter
                    this.btnIncrementMultiple.Enabled = true;
                }
                else
                {
                    this.btnIncrementMultiple.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                this.btnIncrementMultiple.Enabled = false;
            }
        }

        private void btnDencrementMultiple_Click(object sender, EventArgs e)
        {
            int persons = int.Parse(this.txtDecrementMultiple.Text);
            this.ac.decrement(persons);
            updateGUI();
        }

        private void txtDecrementMultiple_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int multiplePersons = int.Parse(this.txtDecrementMultiple.Text);
                if (this.ac.canLeave(multiplePersons))
                {
                    this.btnDecrementMultiple.Enabled = true;
                }
                else
                {
                    this.btnDecrementMultiple.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                this.btnDecrementMultiple.Enabled = false;
            }
        }
    }
}
