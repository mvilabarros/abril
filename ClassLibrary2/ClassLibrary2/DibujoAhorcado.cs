using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary2
{
    public partial class DibujoAhorcado : Control
    {
        private int errores;
        public DibujoAhorcado(int error) { this.errores = error; }
        public delegate void EventHandler(object ahorcado, EventArgs eve);
        public event EventHandler CambiaError = delegate { };
        public event EventHandler Ahorcado = delegate { }; //Si tiene un delegado vacio no hace falta comprobar si es nulo

        public int Errores
        {
            set //SET CON VALOR,EVENTO Y REFRESH
            {
                if (this.errores != value)
                {
                    this.errores = value;
                    this.CambiaError(this, EventArgs.Empty); //meter nulo
                    this.Refresh();
                }
                if(Errores == 6)
                {
                    this.Ahorcado(this, EventArgs.Empty);
                }
            }
            get { return this.errores; }
        }

        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            Pen p = new Pen(Color.Black);
            DibujoAhorcado notify = new DibujoAhorcado(Errores);

            //Base
            g.DrawLine(p, 20, 240, 220, 240);
            g.DrawLine(p, 40, 240, 40, 50);
            g.DrawLine(p, 40, 50, 160, 50);
            g.DrawLine(p, 80, 50, 40, 90);
            g.DrawLine(p, 160, 50, 160, 80);

            //Cuerpo
            switch (notify.Errores) 
            {
                case 1:
                    g.DrawEllipse(p, 150, 80, 20, 20); //cabeza
                    break;
                case 2:
                    g.DrawLine(p, 160, 100, 160, 150); //cuerpo
                    goto case 1;
                case 3:
                    g.DrawLine(p, 160, 150, 150, 180); //p izq
                    goto case 2;
                case 4:
                    g.DrawLine(p, 160, 150, 170, 180); //p der
                    goto case 3;
                case 5:
                    g.DrawLine(p, 160, 110, 150, 130); //b izq
                    goto case 4;
                case 6:
                    g.DrawLine(p, 160, 110, 170, 130); //b der
                    goto case 5;
            }
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString("Errores: " + notify.Errores.ToString() , this.Font, b, 200, 10);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            b.Dispose();
        }
    }
}


/*
         g.DrawEllipse(p, 150, 80, 20, 20); //cabeza
         g.DrawLine(p, 160, 100, 160, 150); //cuerpo
         g.DrawLine(p, 160, 150, 150, 180); //p izq
         g.DrawLine(p, 160, 150, 170, 180); //p der
         g.DrawLine(p, 160, 110, 150, 130); //b izq  
         g.DrawLine(p, 160, 110, 170, 130); //b der
*/
