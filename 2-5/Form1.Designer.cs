﻿namespace _2_5
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
            this.lblPalabra = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.lblLetra = new System.Windows.Forms.Label();
            this.dibujoAhorcado1 = new ClassLibrary2.DibujoAhorcado();
            this.SuspendLayout();
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(24, 289);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(49, 13);
            this.lblPalabra.TabIndex = 1;
            this.lblPalabra.Text = "Palabra: ";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(132, 327);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(30, 20);
            this.txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Introduce una letra: ";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(180, 325);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "ENVIAR";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(200, 289);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(0, 13);
            this.lblLetra.TabIndex = 6;
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 6;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(27, 12);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(255, 270);
            this.dibujoAhorcado1.TabIndex = 7;
            this.dibujoAhorcado1.Text = "dibujoAhorcado";
            this.dibujoAhorcado1.CambiaError += new ClassLibrary2.DibujoAhorcado.EventHandler(this.dibujoAhorcado1_CambiaError);
            this.dibujoAhorcado1.Ahorcado += new ClassLibrary2.DibujoAhorcado.EventHandler(this.dibujoAhorcado1_Ahorcado);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 393);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblPalabra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Hangman Mario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblLetra;
        private ClassLibrary2.DibujoAhorcado dibujoAhorcado1;
    }
}

