using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4_Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

       

        private void btnZeichen_Click(object sender, EventArgs e)
        {
                if (btnZeichen.Text == "+")
                {
                    btnZeichen.Text = "-";
                }
                else if(btnZeichen.Text == "-")
                {
                    btnZeichen.Text = "*";
                }
                else if (btnZeichen.Text == "*")
                {
                btnZeichen.Text = "+";
                }
        }


        private void btnDatei_Click(object sender, EventArgs e)
        {
            DialogResult result = this.ofdDatei.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = ofdDatei.FileName;
                this.lbDatei.Text = fileName;

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Leider keine Datei Ausgewählt", "Datei wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAusgabe_Click(object sender, EventArgs e)
        {
            if(btnZeichen.Text == "+")
            {
                int add = txtZahl1 + txtZahl2;      //Zusammenrechnen
            }
            if (btnZeichen.Text == "-")
            {
                int add = txtZahl1 - txtZahl2;      //Zusammenrechnen
            }
            if (btnZeichen.Text == "*")
            {
                int add = txtZahl1 * txtZahl2;      //Zusammenrechnen
            }
        }
    }
}
