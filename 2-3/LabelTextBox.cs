using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_3
{
    public enum ePosicion
    {
        ARRIBA, ABAJO, IZQUIERDA, DERECHA
    }

    [
        DefaultProperty("TextL"),
        DefaultEvent("Enter")
    ]

    public partial class LabelTextBox : UserControl
    {       
        public LabelTextBox()
        {
            InitializeComponent();
        }
        [Description("Lee o establece el campo Text del TextBox interno del componente")]
        private void LabelTextBox_Load(object sender, EventArgs e)
        {
            TextL = Name;
            TextT = "";
            recolocar();
        }

       
        private ePosicion posicion = ePosicion.IZQUIERDA;
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        //Pixeles de separación entre label y textbox
        private int margen = 0;
        public int Margen
        {
            set
            {
                if (value >= 0)
                {
                    margen = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get {
                return margen;
            }
        }

        //Campo Text del label
        public string TextL
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        //Campo Text del TextBox
        public string TextT
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(txt.Width + Margen, 0);
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    txt.Width = this.Width - lbl.Width - Margen;
                    this.Width = txt.Width + lbl.Width + margen;
                break;

                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Margen, 0);
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    txt.Width = this.Width - lbl.Width - Margen;
                    this.Width = txt.Width + lbl.Width + margen;
                    break;

                case ePosicion.ARRIBA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(0, lbl.Height + Margen);
                    txt.Width = this.Width;
                    this.Height = txt.Height + lbl.Height + Margen;
                    this.Width = Math.Max(lbl.Width, txt.Width);
                    break;

                case ePosicion.ABAJO:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(0, txt.Height + Margen);
                    txt.Width = this.Width;
                    this.Height = txt.Height + lbl.Height + Margen;
                    this.Width = Math.Max(lbl.Width, txt.Width);
                    break;
            }
        }


        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }

    
    }
}
