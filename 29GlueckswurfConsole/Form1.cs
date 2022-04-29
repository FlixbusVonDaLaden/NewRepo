using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29GlueckswurfConsole
{
    public partial class Glueckswurf : Form
    {
        private Glueckswurf glueck = new Glueckswurf(100);

        public Form1()
        {
            InitializeComponent();
            updateGUI();
        }

        private void updateGUI()
        {
            this.guthabentb.Text = glueck.Guthaben.ToString();
            this.nudEinsatz.Maximum = glueck.Guthaben;
        }

        private void btnGlueckszahl_Click(object sender, EventArgs e)
        {
            Button btn = sender;
        }

        
    }
}
