using System;
using System.Collections.Generic;
using System.Text;

namespace _16Reactangle
{
    public class Rectangle
    {
        private int lenX;
        private int lenY;

        public Rectangle(int lenY, int lenX)
        {
            this.lenY = lenY;
            this.lenX = lenX;
        }

        public int LenX
        {
            get
            {
                return this.lenX;
            }
            set
            {
                if(value < 0)
                {
                    // welche Möglichkeiten
                    // * (-1)
                    // Fehlermeldung
                    // ignorieren
                    // auf 0 setzen
                    this.lenX = 0;      //Besser Variante wäre: exception --> noch nicht gelernt, daher 2. Bste Lösung: auf 0 setzen
                }
                else
                {
                    this.lenX = value;
                }
            }
        }

        public int LenY
        {
            get
            {
                return this.lenY;
            }
            set
            {
                if (value < 0)
                {
                    // welche Möglichkeiten
                    // * (-1)
                    // Fehlermeldung
                    // ignorieren
                    // auf 0 setzen
                    this.lenY = 0;      //Besser Variante wäre: exception --> noch nicht gelernt, daher 2. Bste Lösung: auf 0 setzen
                }
                else
                {
                    this.lenY = value;
                }
            }
        }

        public int area()
        {
            return  this.lenX * this.lenY;  //Bei Methoden nie in die Konsole schreiben, falls man sie später noch einmal verwenden will!!!
        }

        public int Circumference()
        {
            return (this.lenY + this.lenX) * 2;
        }




    }
}
