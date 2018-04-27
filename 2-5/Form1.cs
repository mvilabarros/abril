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

        static Random random;
        static string[] palabras = { "Bowser", "Peach", "Luigi", "Mario", "Toad" };
        static string comprueba;
        static string compruebaMayus;
        static int aciertos = 0;

        StringBuilder mostrar;

        private void Comprueba()
        {
            string mayus = null;
            char comp = '\0' ;
            bool ganar = false;

            if (txt.Text.Length != 0)
            {
                mayus = txt.Text.ToUpper();
                comp = mayus[0];
            }

            List<char> correctos = new List<char>();
            List<char> errores = new List<char>();

            if (compruebaMayus.Contains(comp) && comp != '\0')
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
                lblLetra.Text = "ACIERTO";
            }
            else
            {
                errores.Add(comp);
                lblLetra.Text = "FALLO";
                dibujoAhorcado1.Errores += 1;
            }
            lblPalabra.Text = "Palabra: " + mostrar.ToString();

            if (aciertos == comprueba.Length) ganar = true;
            if (ganar)
            {
                MessageBox.Show("¡HAS GANADO!", "~~~~", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cargar();
            }
        }

        private void Cargar()
        {
            aciertos = 0;
            dibujoAhorcado1.Errores = 0;
            random = new Random((int)DateTime.Now.Ticks);
            comprueba = palabras[random.Next(0, palabras.Length)];
            compruebaMayus = comprueba.ToUpper();
            mostrar = new StringBuilder(comprueba.Length);

            for (int i = 0; i < comprueba.Length; i++)
            {
                mostrar.Append('_');
            }
            lblPalabra.Text = "Palabra: " + mostrar.ToString();
        }

        private void dibujoAhorcado1_CambiaError(object ahorcado, EventArgs eve)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt.Text.Length != 0) Comprueba();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dibujoAhorcado1_Ahorcado(object ahorcado, EventArgs eve)
        {
         
            MessageBox.Show("¡HAS PERDIDO!", "~~~~", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Cargar();
            
        }
    }
}
