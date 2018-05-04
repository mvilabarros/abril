namespace serv1_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtSubdir = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.btnExtension = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtArchivos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(95, 12);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(386, 20);
            this.txtDir.TabIndex = 0;
            // 
            // txtSubdir
            // 
            this.txtSubdir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSubdir.Location = new System.Drawing.Point(12, 114);
            this.txtSubdir.Multiline = true;
            this.txtSubdir.Name = "txtSubdir";
            this.txtSubdir.ReadOnly = true;
            this.txtSubdir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSubdir.Size = new System.Drawing.Size(221, 235);
            this.txtSubdir.TabIndex = 1;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(612, 13);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(112, 20);
            this.txtExtension.TabIndex = 4;
            // 
            // txtExt
            // 
            this.txtExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExt.Location = new System.Drawing.Point(503, 114);
            this.txtExt.Multiline = true;
            this.txtExt.Name = "txtExt";
            this.txtExt.ReadOnly = true;
            this.txtExt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExt.Size = new System.Drawing.Size(221, 235);
            this.txtExt.TabIndex = 5;
            // 
            // btnExtension
            // 
            this.btnExtension.Location = new System.Drawing.Point(649, 39);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(75, 23);
            this.btnExtension.TabIndex = 6;
            this.btnExtension.Text = "Aceptar";
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Click += new System.EventHandler(this.btnExtension_Click);
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(406, 38);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 23);
            this.btnDir.TabIndex = 7;
            this.btnDir.Text = "Aceptar";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subdirectorios: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Archivos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Archivos con determinada extensión: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Introduce extensión: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Introduce ruta: ";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(10, 65);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(68, 13);
            this.lblRuta.TabIndex = 13;
            this.lblRuta.Text = "Ruta actual: ";
            // 
            // txtArchivos
            // 
            this.txtArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtArchivos.Location = new System.Drawing.Point(260, 114);
            this.txtArchivos.Multiline = true;
            this.txtArchivos.Name = "txtArchivos";
            this.txtArchivos.ReadOnly = true;
            this.txtArchivos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArchivos.Size = new System.Drawing.Size(221, 235);
            this.txtArchivos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 361);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.btnExtension);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtArchivos);
            this.Controls.Add(this.txtSubdir);
            this.Controls.Add(this.txtDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(751, 400);
            this.Name = "Form1";
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtSubdir;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Button btnExtension;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtArchivos;
    }
}

