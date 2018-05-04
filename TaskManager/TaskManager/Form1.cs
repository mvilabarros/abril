using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{

    public partial class Form1 : Form
    {
        static string nl = Environment.NewLine;
        const string format = "{0,6} {1,15} {2,20} {3}";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] procesos = Process.GetProcesses(".");
                txtInfo.Text = String.Format(format, "Nombre", "PID", "Título", nl);
                foreach (Process p in procesos)
                {
                    txtInfo.Text = txtInfo.Text + String.Format(format + nl, p.ProcessName, p.Id, p.MainWindowTitle,nl);
                }
            }
            catch (Exception ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPid.Text != "")
                {
                    Process proceso = Process.GetProcessById(Convert.ToInt32(txtPid.Text));
                    txtInfo.Text = String.Format(format, proceso.Id, proceso.StartTime.ToShortTimeString(), proceso.Threads.Count, nl);
                    foreach (ProcessModule mod in proceso.Modules)
                    {
                        txtInfo.Text = txtInfo.Text + String.Format("Mod: {0}" + nl, mod.FileName);
                    }
                    ProcessThreadCollection hilosProceso = proceso.Threads;
                    foreach (ProcessThread hilo in hilosProceso)
                    {
                        txtInfo.Text = txtInfo.Text + String.Format("Hilo: {0} {1}" + nl, hilo.Id, hilo.StartTime);
                    }
                }
            }

            catch (Win32Exception ex)
            {
                txtInfo.Text = "Error: " + ex;

            }
            catch (ArgumentException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
            catch (FormatException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
            catch (InvalidOperationException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPid.Text != "")
                {
                    Process proceso = Process.GetProcessById(Convert.ToInt32(txtPid.Text));
                    proceso.CloseMainWindow();
                }
            }
            catch (ArgumentException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
            catch (FormatException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPid.Text != "")
                {
                    Process proceso = Process.GetProcessById(Convert.ToInt32(txtPid.Text));
                    proceso.Kill();
                }
            }
            catch (ArgumentException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
            catch (FormatException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPid.Text != "")
                {
                    String programa = Convert.ToString(txtPid.Text);
                    ProcessStartInfo startInfo = new ProcessStartInfo(programa);
                    Process.Start(startInfo);
                }
            }
            catch (Win32Exception ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
            catch (FormatException ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter s = null;
            try
            {
                if (txtInfo.Text != "")
                {
                    this.saveFileDialog1.Title = "Selección de directorio para almacenar datos";
                    this.saveFileDialog1.InitialDirectory = "C:\\";
                    this.saveFileDialog1.ValidateNames = true;
                    this.saveFileDialog1.Filter = "txt (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    this.saveFileDialog1.FilterIndex = 2;
                    this.saveFileDialog1.ShowDialog();
                    s = new StreamWriter(this.saveFileDialog1.FileName, append: false);
                    s.Write(this.txtInfo.Text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
            finally
            {
                if (s != null) s.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            try
            {
                this.openFileDialog1.Title = "Selección de directorio para mostrar datos.";
                this.openFileDialog1.InitialDirectory = "C:\\";
                this.openFileDialog1.Filter = "txt (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                this.openFileDialog1.FilterIndex = 2;
                this.openFileDialog1.ShowDialog();
                sr = new StreamReader(this.openFileDialog1.FileName);
                txtInfo.Text = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                txtInfo.Text = "Error: " + ex;
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
