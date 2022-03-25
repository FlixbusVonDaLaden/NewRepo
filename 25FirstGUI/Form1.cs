using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25FirstGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            this.txtHelloWorld.Text = "Hello World!";
            this.btnHelloWorld.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtHelloWorld.Text = " ";
            this.btnHelloWorld.Enabled = true;
        }
        private void btnHelloWorld_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            // Sender hat statischen Datentyp : Object
            //Sender aht dynamsichen Datentyp: Button   (Immer das Objekt, welches das Ereignis auslöst)
            Button b = (Button)sender;  //Expliziter cast
            int sizeX = rand.Next(10, 100);
            int sizeY = rand.Next(10, 100);
            b.Size = new Size(sizeX, sizeY);
            int x = rand.Next(this.FindForm().Size.Width - b.Size.Width);
            int y = rand.Next(this.FindForm().Size.Height - b.Size.Height);
            b.Location = new Point(x, y);
        }
    }
}
