using System;
using System.Collections.Generic;
using System.Text;

namespace Quader
{
    public class Quader
    {

        private double a;
       public double B
        {
            get; set;
       }

       public double H
        {
            get; set;
       }
        
        public Quader(double a, double b, double h)
        {
            this.A = a;     //Diese Variante bevorzugt, weil zusaötzlich Code in Setter ausgeführt wird!!!
            this.B = b;
            this.H = h;
        }

        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                if (value < 0)
                {
                    this.a = 0;
                }
                else
                {
                    this.a = value;
                }
            }
        }

        public double Volumen()
        {
            return this.A * this.B * this.H;
        }

        public double Oberflaeche()
        {
            return (this.A * 2) + (this.B * 2) + (this.H * 2);
        }

    }
}
