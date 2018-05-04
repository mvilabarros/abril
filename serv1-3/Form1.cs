using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serv1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string nl = Environment.NewLine;
        static DirectoryInfo d;

        private void btnDir_Click(object sender, EventArgs e)
        {
            txtSubdir.Text = "";
            txtArchivos.Text = "";
            try
            {
                lblRuta.Text = "Ruta actual: " + Directory.GetCurrentDirectory() + nl + "Cambiamos a " + txtDir.Text;
                Directory.SetCurrentDirectory(txtDir.Text);
                d = new DirectoryInfo(Directory.GetCurrentDirectory());
                foreach (DirectoryInfo dir in d.GetDirectories())
                    txtSubdir.AppendText(dir.Name + nl);
                foreach (FileInfo f in d.GetFiles())
                    txtArchivos.AppendText(f.Name + nl);
            }
            catch (ArgumentException)
            {
                lblRuta.Text = "No has introducido una ruta correcta.";
            }
            catch (DirectoryNotFoundException)
            {
                lblRuta.Text = "Directorio no encontrado.";
            }

        }


        private void btnExtension_Click(object sender, EventArgs e)
        {
            txtExt.Text = "";
            string[] dirs = Directory.GetFiles(Directory.GetCurrentDirectory(), "*." + txtExtension.Text);
            foreach(string dir in dirs)
            {
                txtExt.AppendText(dir + nl);
            }
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRuta.Text = "Ruta actual: " + Directory.GetCurrentDirectory();
        }
    }
}
