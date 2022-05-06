using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _28Glueckswurf;

namespace _30GlueckswurfGUI
{
    public partial class Form1 : Form
    {
        private Glueckswurf glueck = new Glueckswurf(100);
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            updateGUI();
            aktualisiereGewinnchance();
            timer.Interval = 400;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.btnNext.BackColor = Color.Yellow;
            this.btnNext.Update();
            Thread.Sleep(200);
            this.btnNext.BackColor = Color.Red;
            this.btnNext.Update();
        }

        private void updateGUI()
        {
            this.txtGuthaben.Text = glueck.Guthaben.ToString();
            this.nudEinsatz.Maximum = glueck.Guthaben;
        }

        private void nudEinsatz_ValueChanged(object sender, EventArgs e)
        {
            aktualisiereGewinnchance();
        }

        private void aktualisiereGewinnchance()
        {
            int aktuellerEinsatz = (int)this.nudEinsatz.Value;
            this.lbGewinnchance.Text = "Gewinnchance: " + glueck.gewinnChance(aktuellerEinsatz).ToString();
        }

        private void btnGlueckszahl_Click(object sender, EventArgs e)
        {
            // Welcher der 6 Buttons wurde gedrückt?
            // sender - statischer Datentyp: object
            // sender - dynamischer Datentyp: Button        sender ist immer das Objekt, welches das Event auslöst
            Button btn = (Button)sender;        // expliziter Cast
            string nrAsString = btn.Text;
            int number = int.Parse(nrAsString);

            btn.BackColor = Color.Plum;
            enablebtnGlueckszahl(false);

            int einsatz = (int)nudEinsatz.Value;
            int gewinn = this.glueck.spieleEinSpiel(number, einsatz);
            int guthaben = int.Parse(this.txtGuthaben.Text);

            if(gewinn > 0)
            {
                this.lbGewinn.Text = "Du hast " + gewinn + " gewonnen!";
                guthaben -= einsatz;
                this.txtGuthaben.Text = (guthaben).ToString();
            }
            else
            {
                this.lbGewinn.Text = "Du hast leider nicht gewonnen.";
                guthaben -= einsatz;
                this.txtGuthaben.Text = (guthaben).ToString();
            }
            this.lbGewinn.Visible = false;
            this.btnSpielen.Enabled = true;
            this.nudEinsatz.Enabled = false;
        }

        public void enablebtnGlueckszahl(bool enabled)
        {
            this.btn1.Enabled = enabled;
            this.btn2.Enabled = enabled;
            this.btn3.Enabled = enabled;
            this.btn4.Enabled = enabled;
            this.btn5.Enabled = enabled;
            this.btn6.Enabled = enabled;
        }

        private void btnSpielen_Click(object sender, EventArgs e)
        {
            this.txtWuerfel1.Text = this.glueck.Wuerfelergebnis[0].ToString();
            this.txtWuerfel2.Text = this.glueck.Wuerfelergebnis[1].ToString();
            this.txtWuerfel3.Text = this.glueck.Wuerfelergebnis[2].ToString();
            this.lbGewinn.Visible = true;
            this.txtGuthaben.Text = glueck.Guthaben.ToString();
            this.btnNext.Visible = true;
            timer.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // diesen Button deaktivieren
            // Button für Glücksahlen wieder aktivieren und alle Buttons grau
            // Würfelergebnisse aus den Textboxen löschen
            // SystemColors.Control;

            
            this.nudEinsatz.Value = 10;
            enablebtnGlueckszahl(true);
            this.btnSpielen.Enabled = false;
            this.txtWuerfel1.Text = "";
            this.txtWuerfel2.Text = "";
            this.txtWuerfel3.Text = "";
            this.btnNext.Visible = false;
            this.nudEinsatz.Enabled = true;
            this.btn1.BackColor = SystemColors.ControlLight;
            this.btn2.BackColor = SystemColors.ControlLight;
            this.btn3.BackColor = SystemColors.ControlLight;
            this.btn4.BackColor = SystemColors.ControlLight;
            this.btn5.BackColor = SystemColors.ControlLight;
            this.btn6.BackColor = SystemColors.ControlLight;
            updateGUI();
            timer.Enabled = false;
            
        }
    }
}
