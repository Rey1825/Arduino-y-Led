﻿namespace Arduino_y_Led
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
            this.BttnEncender = new System.Windows.Forms.Button();
            this.BttnApagar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnEncender
            // 
            this.BttnEncender.Location = new System.Drawing.Point(58, 34);
            this.BttnEncender.Name = "BttnEncender";
            this.BttnEncender.Size = new System.Drawing.Size(157, 78);
            this.BttnEncender.TabIndex = 0;
            this.BttnEncender.Text = "Encender:\r\nRojo";
            this.BttnEncender.UseVisualStyleBackColor = true;
            this.BttnEncender.Click += new System.EventHandler(this.BttnEncender_Click);
            // 
            // BttnApagar
            // 
            this.BttnApagar.Location = new System.Drawing.Point(270, 34);
            this.BttnApagar.Name = "BttnApagar";
            this.BttnApagar.Size = new System.Drawing.Size(157, 78);
            this.BttnApagar.TabIndex = 1;
            this.BttnApagar.Text = "Apagar:\r\nRojo\r\n";
            this.BttnApagar.UseVisualStyleBackColor = true;
            this.BttnApagar.Click += new System.EventHandler(this.BttnApagar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encender:\r\nVerde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apagar:\r\nVerde";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 78);
            this.button3.TabIndex = 4;
            this.button3.Text = "Encender:\r\nRojo y Verde";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 78);
            this.button4.TabIndex = 5;
            this.button4.Text = "Apagar:\r\nRojo y Verde";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 78);
            this.button5.TabIndex = 6;
            this.button5.Text = "Encender/Apagar:\r\nRojo/Verde\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(270, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 78);
            this.button6.TabIndex = 7;
            this.button6.Text = "Encender/Apagar:\r\nVerde/Rojo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BttnApagar);
            this.Controls.Add(this.BttnEncender);
            this.Name = "Form1";
            this.Text = "Leds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnEncender;
        private System.Windows.Forms.Button BttnApagar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

