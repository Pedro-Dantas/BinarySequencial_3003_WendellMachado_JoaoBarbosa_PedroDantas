﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textarray = new System.Windows.Forms.TextBox();
            this.textbinary = new System.Windows.Forms.TextBox();
            this.textsequential = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateArray);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Binary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PrintBinary);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sequencial";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PrintSequencial);
            // 
            // textarray
            // 
            this.textarray.Location = new System.Drawing.Point(147, 34);
            this.textarray.Name = "textarray";
            this.textarray.Size = new System.Drawing.Size(100, 20);
            this.textarray.TabIndex = 3;
            // 
            // textbinary
            // 
            this.textbinary.Location = new System.Drawing.Point(147, 86);
            this.textbinary.Name = "textbinary";
            this.textbinary.Size = new System.Drawing.Size(100, 20);
            this.textbinary.TabIndex = 4;
            // 
            // textsequential
            // 
            this.textsequential.Location = new System.Drawing.Point(147, 141);
            this.textsequential.Name = "textsequential";
            this.textsequential.Size = new System.Drawing.Size(100, 20);
            this.textsequential.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textsequential);
            this.Controls.Add(this.textbinary);
            this.Controls.Add(this.textarray);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textarray;
        private System.Windows.Forms.TextBox textbinary;
        private System.Windows.Forms.TextBox textsequential;
    }
}

