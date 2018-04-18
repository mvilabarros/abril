using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abril
{
    public partial class Form1 : Form
    {
        private int tick_cont = 0;
        private Icon icon1 = new Icon("..\\..\\Icon\\palm.ico");
        private Icon icon2 = new Icon("..\\..\\Icon\\favicon.ico");
        
        public Form1()
        {
            InitializeComponent();
            lbl1.Text = "Lista principal: " + list1.Items.Count;
            lbl2.Text = "Índices seleccionados: ";

            this.Text = "Title...";
            Icon = this.Icon;

            toolTip1.SetToolTip(this.list2, "Ítems en lista secundaria: " + list2.Items.Count);
            toolTip1.SetToolTip(this.list1, "Lista principal.");
            toolTip1.SetToolTip(this.btn_add, "Añade ítem a lista principal.");
            toolTip1.SetToolTip(this.btn_delete, "Borra ítem de la lista principal.");
            toolTip1.SetToolTip(this.btn_move1, "Mueve ítem de lista principal a secundaria.");
            toolTip1.SetToolTip(this.btn_move2, "Mueve ítem de lista secundaria a principal.");
            toolTip1.SetToolTip(this.txt, "Escribe nombre ítem.");

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string text = txt.Text;
            if(text.Length != 0) list1.Items.Add(text);
            txt.Text = "";
            lbl1.Text = "Lista principal: " + list1.Items.Count.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            while(list1.SelectedItems.Count > 0)
            {
                list1.Items.Remove(list1.SelectedItems[0]);
                lbl1.Text = "Lista principal: " + list1.Items.Count.ToString();
            }
        }

        private void btn_move1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while(list1.SelectedItems.Count > 0)
            {
                list2.Items.Insert(cont,list1.SelectedItems[0]);
                list1.Items.Remove(list1.SelectedItems[0]);
                cont++;
            }
            lbl1.Text = "Lista principal: " + list1.Items.Count;

        }

        private void btn_move2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while (list2.SelectedItems.Count > 0)
            {
                list1.Items.Insert(cont, list2.SelectedItems[0]);
                list2.Items.Remove(list2.SelectedItems[0]);
                cont++;
            }
            lbl1.Text = "Lista principal: " + list1.Items.Count;

        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl2.Text = "Índices seleccionados: ";
            List<int> selectedItemIndexes = new List<int>();
            foreach (var cont in list1.SelectedIndices)
            {
                lbl2.Text += cont;
            }

        }

        private void list2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.list2, "Ítems en lista secundaria: " + list2.Items.Count);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(this.Text.Length - 1) + this.Text.Remove(this.Text.Length - 1);
            tick_cont++;
            if (tick_cont % 2 == 0)
            {
                if (this.Icon == icon2)
                {
                    this.Icon = icon1;
                }
                else
                {
                    this.Icon = icon2;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

      
    }
}
