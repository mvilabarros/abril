using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocNotas
{
    public partial class bloc : Form
    {
        int fileLength = 0;
        bool word_wrap;
        string txt_color;
        string txt_background;
        string txt_mode = "C";
        string filtro = "txt (*.txt)|*.txt|" +
                        "ini (*.ini)|*.ini|" +
                        "java (*.java)|*.java|" +
                        "cs (*.cs)|*.cs|" +
                        "py (*.py)|*.py|" +
                        "html (*.html)|*.html|" +
                        "css (*.css)|*.css|" +
                        "xml (*.xml)|*.xml|" +
                        "Todo (*.*)|*.*";

        public bloc()
        {
            InitializeComponent();
        }

        //TODO filtro en string, using cierrra automaticamente=quitar close, si dos opciones prefer if, define para los readconf

        private void saveFile()
        {
            StreamWriter s = null;
            try
            {
                if (txt.Text != "")
                {
                    this.saveFileDialog1.Title = "Selección de directorio para almacenar datos";
                    this.saveFileDialog1.InitialDirectory = "C:\\";
                    this.saveFileDialog1.Filter = filtro;
                    this.saveFileDialog1.ValidateNames = true;
                    this.saveFileDialog1.FilterIndex = 1;
                    this.saveFileDialog1.ShowDialog();
                    s = new StreamWriter(this.saveFileDialog1.FileName, append: false);
                    s.Write(this.txt.Text + Environment.NewLine);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No se ha creado el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error guardado.", "UnauthorizedAccessException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TXT CONFIG
        private void saveConfig()
        {
            StreamWriter file = null;
            try
            {
                using (file = new StreamWriter("..//..//Resources//config.txt"))
                {
                    file.Write(word_wrap + ";" +
                               txt_color + ";" +
                               txt_background + ";" +
                               txt_mode + ";");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error guardado configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (file != null) file.Close();
            }
        }

        private void readConfig()
        {
            if (File.Exists("..//..//Resources//config.txt") && new FileInfo("..//..//Resources//config.txt").Length != 0)
            {
                using (StreamReader sr = new StreamReader("..//..//Resources//config.txt"))
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();
                    strArray = str.Split(';');
                    word_wrap = Convert.ToBoolean(strArray[0]);
                    txt_color = strArray[1];
                    txt_background = strArray[2];
                    txt_mode = strArray[3];
                }
            }
            else
            {
                saveConfig();
                readConfig();
            }
        }

        //BINARIO CONF
        private void saveConf()
        {
            BinaryWriter bw = null;
            try
            {
                bw = new BinaryWriter(new FileStream("..//..//Resources//conf.txt", FileMode.OpenOrCreate));
                bw.Write(word_wrap);
                bw.Write(txt_color);
                bw.Write(txt_background);
                bw.Write(txt_mode);
            }
            catch (Exception)
            {
                MessageBox.Show("Error guardado configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (bw != null) bw.Close();
            }
        }

        private void readConf()
        {
            if (File.Exists("..//..//Resources//conf.txt") && new FileInfo("..//..//Resources//conf.txt").Length != 0)
            {
                BinaryReader br = null;
                try
                {
                    br = new BinaryReader(new FileStream("..//..//Resources//conf.txt", FileMode.Open));
                    word_wrap = br.ReadBoolean();
                    txt_color = br.ReadString();
                    txt_background = br.ReadString();
                    txt_mode = br.ReadString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error lectura configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (br != null) br.Close();
                }
            }
            else
            {
                saveConf();
                readConf();
            }
        }


        //Form
        private void bloc_Load(object sender, EventArgs e)
        {
            //
            // readConfig();
            readConf();
            //
            txt.WordWrap = word_wrap;
            //if (txt.WordWrap)
            //{
            //    ajusteDeLíneaToolStripMenuItem.Checked = true;
            //}
            //else
            //{
            //    ajusteDeLíneaToolStripMenuItem.Checked = false;
            //}
            ajusteDeLíneaToolStripMenuItem.Checked = txt.WordWrap;

            if (txt_mode == ("CharacterCasing.Upper"))
            {
                minúsculasToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = false;
                mayúsculasToolStripMenuItem.Checked = true;

                txt.CharacterCasing = CharacterCasing.Upper;
            }
            else if (txt_mode.Equals("CharacterCasing.Lower"))
            {
                mayúsculasToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = false;
                minúsculasToolStripMenuItem.Checked = true;

                txt.CharacterCasing = CharacterCasing.Lower;
            }
            else
            {
                mayúsculasToolStripMenuItem.Checked = false;
                minúsculasToolStripMenuItem.Checked = false;
                normalToolStripMenuItem.Checked = true;

                txt.CharacterCasing = CharacterCasing.Normal;
            }

            txt.ForeColor = ColorTranslator.FromHtml(txt_color);
            txt.BackColor = ColorTranslator.FromHtml(txt_background);

        }

        private void bloc_FormClosed(object sender, FormClosedEventArgs e)
        {
            word_wrap = txt.WordWrap;
            if (mayúsculasToolStripMenuItem.Checked)
            {
                txt_mode = "CharacterCasing.Upper";
            }
            else if (minúsculasToolStripMenuItem.Checked)
            {
                txt_mode = "CharacterCasing.Lower";
            }
            else
            {
                txt_mode = "CharacterCasing.Normal";
            }
            txt_color = ColorTranslator.ToHtml(txt.ForeColor);
            txt_background = ColorTranslator.ToHtml(txt.BackColor);


            //
            saveConfig();
            saveConf();
            //

            if (fileLength < txt.TextLength)
            {
                DialogResult dia = MessageBox.Show("¿Deseas guardar el archivo?", "¿Confirmar cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dia == DialogResult.Yes)
                    if (txt.TextLength > 0)
                        saveFile();

            }
        }

        //Archivo
        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream str = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = filtro;

            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((str = openFileDialog1.OpenFile()) != null)
                    {
                        using (str)
                        {
                            string fileName = openFileDialog1.FileName;
                            string fileText = File.ReadAllText(fileName);
                            txt.Text = fileText;
                            fileLength = txt.TextLength;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede abrir el archivo: " + ex.Message);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt.TextLength > 0) saveFile();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.Clear();
            this.Close();
        }

        //Edición
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(txt.SelectionLength > 0) Clipboard.SetText(txt.SelectedText);
            if (txt.SelectionLength > 0) txt.Copy();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt.SelectedText != "") txt.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if (Clipboard.ContainsText()) txt.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
            if (Clipboard.ContainsText() || txt.SelectionLength > 0) txt.Paste();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt.CanUndo == true)
            {
                txt.Undo();
                txt.ClearUndo();
            }
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.SelectAll();
            txt.Focus();
        }

        //Herramientas
        private void ajusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (ajusteDeLíneaToolStripMenuItem.Checked)
            //{
            //    txt.WordWrap = true;
            //}
            //else
            //{
            //    txt.WordWrap = false;
            //}
            txt.WordWrap = ajusteDeLíneaToolStripMenuItem.Checked;
        }

        private void mayúsculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minúsculasToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;

            txt.CharacterCasing = CharacterCasing.Upper;
        }

        private void minúsculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayúsculasToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;

            txt.CharacterCasing = CharacterCasing.Lower;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayúsculasToolStripMenuItem.Checked = false;
            minúsculasToolStripMenuItem.Checked = false;

            txt.CharacterCasing = CharacterCasing.Normal;
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog txtColor = new ColorDialog();
            txtColor.AllowFullOpen = true;
            txtColor.ShowHelp = true;
            txtColor.Color = txt.ForeColor;

            if (txtColor.ShowDialog() == DialogResult.OK)
                txt.ForeColor = txtColor.Color;
        }

        private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog backColor = new ColorDialog();
            backColor.AllowFullOpen = true;
            backColor.ShowHelp = true;
            backColor.Color = txt.BackColor;

            if (backColor.ShowDialog() == DialogResult.OK)
                txt.BackColor = backColor.Color;
        }

    }
}
