﻿namespace GestaoPetShop
{
    partial class FormRelatorioGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioGeral));
            this.buttonRelatorioCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTeste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRelatorioCliente
            // 
            this.buttonRelatorioCliente.Location = new System.Drawing.Point(12, 12);
            this.buttonRelatorioCliente.Name = "buttonRelatorioCliente";
            this.buttonRelatorioCliente.Size = new System.Drawing.Size(105, 35);
            this.buttonRelatorioCliente.TabIndex = 0;
            this.buttonRelatorioCliente.Text = "Relatório Cliente";
            this.buttonRelatorioCliente.UseVisualStyleBackColor = true;
            this.buttonRelatorioCliente.Click += new System.EventHandler(this.buttonRelatorioCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(322, 24);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 2;
            this.btnTeste.Text = "teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // FormRelatorioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRelatorioCliente);
            this.Name = "FormRelatorioGeral";
            this.Text = "FormRelatorioGeral";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRelatorioCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTeste;
    }
}