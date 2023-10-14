namespace GestaoPetShop
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
            this.buttonRelatorioCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRelatorioCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelatorioCliente.Location = new System.Drawing.Point(12, 68);
            this.buttonRelatorioCliente.Name = "buttonRelatorioCliente";
            this.buttonRelatorioCliente.Size = new System.Drawing.Size(178, 30);
            this.buttonRelatorioCliente.TabIndex = 0;
            this.buttonRelatorioCliente.Text = "Relatório Cliente";
            this.buttonRelatorioCliente.UseVisualStyleBackColor = false;
            this.buttonRelatorioCliente.Click += new System.EventHandler(this.buttonRelatorioCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 287);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTeste.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.Location = new System.Drawing.Point(353, 68);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(141, 30);
            this.btnTeste.TabIndex = 2;
            this.btnTeste.Text = "teste";
            this.btnTeste.UseVisualStyleBackColor = false;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // FormRelatorioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 515);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRelatorioCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelatorioGeral";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO GERAL";
            this.Load += new System.EventHandler(this.FormRelatorioGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRelatorioCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTeste;
    }
}