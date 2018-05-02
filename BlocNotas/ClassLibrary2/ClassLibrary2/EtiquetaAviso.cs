using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary2
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        private eMarca marca = eMarca.Nada;
        private bool gradiente = false;
        private Bitmap imagenMarca;

        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get { return marca; }
        }

        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get { return gradiente; }
        }

        public Bitmap ImagenMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get { return imagenMarca;  }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
  

            //Dibujar fondo antes
            if (Gradiente)
            {
                LinearGradientBrush brush = new LinearGradientBrush(
                    this.ClientRectangle, Color.White, Color.Goldenrod, LinearGradientMode.Horizontal);
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
                brush.Dispose();
            }

            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                   this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height, this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    lapiz.Dispose();
                    break;

                case eMarca.Imagen:
                    g.DrawImage(new Bitmap(ImagenMarca), grosor, grosor, this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
            }

            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
    }
}
