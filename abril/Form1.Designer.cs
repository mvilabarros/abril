namespace abril
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.list1 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_move1 = new System.Windows.Forms.Button();
            this.btn_move2 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsec = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.list1.Location = new System.Drawing.Point(15, 35);
            this.list1.Name = "list1";
            this.list1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list1.Size = new System.Drawing.Size(218, 225);
            this.list1.TabIndex = 0;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(276, 35);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(218, 225);
            this.list2.TabIndex = 1;
            this.list2.SelectedIndexChanged += new System.EventHandler(this.list2_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 278);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 318);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "label2";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(276, 313);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Añadir";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(410, 313);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Borrar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_move1
            // 
            this.btn_move1.Location = new System.Drawing.Point(276, 354);
            this.btn_move1.Name = "btn_move1";
            this.btn_move1.Size = new System.Drawing.Size(75, 23);
            this.btn_move1.TabIndex = 6;
            this.btn_move1.Text = "Mover 1->2";
            this.btn_move1.UseVisualStyleBackColor = true;
            this.btn_move1.Click += new System.EventHandler(this.btn_move1_Click);
            // 
            // btn_move2
            // 
            this.btn_move2.Location = new System.Drawing.Point(410, 354);
            this.btn_move2.Name = "btn_move2";
            this.btn_move2.Size = new System.Drawing.Size(75, 23);
            this.btn_move2.TabIndex = 7;
            this.btn_move2.Text = "Mover 1<-2";
            this.btn_move2.UseVisualStyleBackColor = true;
            this.btn_move2.Click += new System.EventHandler(this.btn_move2_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(276, 278);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(218, 20);
            this.txt.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Location = new System.Drawing.Point(273, 10);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(84, 13);
            this.lblsec.TabIndex = 9;
            this.lblsec.Text = "Lista secundaria";
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(12, 10);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(71, 13);
            this.lblp.TabIndex = 10;
            this.lblp.Text = "Lista principal";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 389);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn_move2);
            this.Controls.Add(this.btn_move1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_move1;
        private System.Windows.Forms.Button btn_move2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lblp;
    }
}

