using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32Turtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 150;
            Turtle.PenSize = 8;
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);

            Turtle.PenUp();
            Turtle.MoveTo(100, 150);
            Turtle.PenDown();

            Turtle.Forward(100);
            Turtle.Rotate(-90);
            Turtle.Forward(100);
            Turtle.Rotate(-90);
            Turtle.Forward(100);
            Turtle.Rotate(-90);
            Turtle.Forward(100);
            Turtle.Rotate(-90);

            Turtle.PenUp();
            Turtle.MoveTo(160, 150);
            Turtle.PenDown();

            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);

            Turtle.PenUp();
            Turtle.MoveTo(160, 100);
            Turtle.PenDown();

            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);


        }

        private void cube()
        {
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
            Turtle.Forward(100);
            Turtle.Rotate(90);
        }
    }
}
