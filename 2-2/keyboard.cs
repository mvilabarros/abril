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

namespace _2_2
{
    public partial class keyboard : Form
    {
        string password = "1234";
        int count = 3;
        bool error = true;

        public keyboard()
        {
            InitializeComponent();
        }

        private void btnClick(Object sender, EventArgs e)
        {
            if (txt_number.Text.Length < 35)
            {
                this.txt_number.Text += (sender as Button).Text;
            }
            (sender as Button).BackColor = Color.Red;

        }
        private void btnEnter(Object sender, EventArgs e)
        {
            if ((sender as Button).BackColor != Color.Red)
            {
                (sender as Button).BackColor = Color.GreenYellow;
            }
        }

        private void btnLeave(Object sender, EventArgs e)
        {
            if ((sender as Button).BackColor != Color.Red)
            {
                (sender as Button).BackColor = SystemColors.ButtonFace;
                (sender as Button).UseVisualStyleBackColor = true;
            }
        }

        void btnReset(object sender, System.EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button)) // control is Button 
                {
                    Button btn = (Button)control;
                    btn.BackColor = SystemColors.ButtonFace;
                    btn.UseVisualStyleBackColor = true;
                }
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox txtReset = (TextBox)control;
                    txtReset.Text = "";
                }
            }
        }

        bool check(string var)
        {
            return var== password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 12, y = 40;
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < 12; i++)
            {
                Button newButton = new Button();
                if (i % 3 == 0)
                {
                    y += 23;
                    x = 12;
                }
                if (i <= 8)
                {
                    newButton.Text = Convert.ToString(i + 1);
                }
                else if (i == 9)
                {
                    newButton.Text = "*";
                }
                else if (i == 10)
                {
                    newButton.Text = "0";
                }
                else
                {
                    newButton.Text = "#";
                }
                newButton.Name = "button" + (i + 1);
                newButton.Location = new Point(x, y);
                newButton.Click += new System.EventHandler(this.btnClick);
                newButton.MouseEnter += new System.EventHandler(this.btnEnter);
                newButton.MouseLeave += new System.EventHandler(this.btnLeave);
                newButton.Enabled = true;
                buttons.Add(newButton);
                this.Controls.Add(newButton);
                x += 75;
            }
            
            pin pin = new pin();
            DialogResult res;
            do
            {
                res = pin.ShowDialog();
                switch (res)
                {
                    case DialogResult.OK:
                        try
                        {
                           error = !check(pin.txt_pin.Text);
                        }
                        catch
                        {
                            error = true;
                        }
                        break;
                    case DialogResult.Cancel:
                         Environment.Exit(0);
                        break;
                }
                if (error) count--;
                if (count == 0)
                {
                    Environment.Exit(0);
                }
            } while (error);
        }
    
        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter s = null;
            try
            {
                if (txt_number.Text != "")
                {
                    this.saveFileDialog1.Title = "Selección de directorio para almacenar datos";
                    this.saveFileDialog1.InitialDirectory = "C:\\";
                    this.saveFileDialog1.Filter = "texto (*.txt)|*.txt| Todos los archivos| *.* ";
                    this.saveFileDialog1.ValidateNames = true;
                    this.saveFileDialog1.ShowDialog();
                    s = new StreamWriter(this.saveFileDialog1.FileName, append: true);
                    s.Write(this.txt_number.Text + Environment.NewLine);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error guardado", "ArgumentException", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error guardado", "UnauthorizedAccessException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (s != null)
                    s.Close();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mvilabarros", "Teclado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
