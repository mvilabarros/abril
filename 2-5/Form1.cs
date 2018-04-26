using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random random = new Random((int)DateTime.Now.Ticks);
        static string[] palabras = { "Bowser", "Peach", "Luigi", "Mario", "Toad" };
        static string comprueba = palabras[random.Next(0, palabras.Length)];
        static string compruebaMayus = comprueba.ToUpper();

        private void Comprueba()
        {
            string mayus = txt.Text.ToUpper();
            char comp = mayus[0];
            int aciertos = 0;
            bool ganar = false;

            StringBuilder mostrar = new StringBuilder(comprueba.Length);
            for(int i = 0; i < comprueba.Length; i++)
            {
                mostrar.Append('_');
            }

            List<char> correctos = new List<char>();
            List<char> errores = new List<char>();

            if (compruebaMayus.Contains(comp))
            {
                correctos.Add(comp);
                for(int i = 0; i < comprueba.Length; i++)
                {
                    if(compruebaMayus[i] == comp)
                    {
                        mostrar[i] = comprueba[i];
                        aciertos++;
                    }
                }
                if (aciertos == comprueba.Length) ganar = true;
                lblLetra.Text = "ACIERTO";
            }
            else
            {
                errores.Add(comp);
                lblLetra.Text = "FALLO";
                dibujoAhorcado1.Errores += 1;
            }

            lblPalabra.Text = "Palabra: " + mostrar.ToString();
            string cambiarMostrar = "";
            for(int i = 1; i < comprueba.Length; i++)
            {

            }
            //if ganar
        }

        private void dibujoAhorcado1_CambiaError(object ahorcado, EventArgs eve)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dibujoAhorcado1.Errores = Convert.ToInt32(txt.Text);
            if(txt.Text.Length != 0) Comprueba();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dibujoAhorcado1.Errores = 0;
        }
    }
}
