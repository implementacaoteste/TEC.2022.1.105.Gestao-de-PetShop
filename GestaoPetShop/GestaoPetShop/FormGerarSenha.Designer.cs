namespace GestaoPetShop
{
    partial class FormGerarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha2 = new System.Windows.Forms.TextBox();
            this.checkBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a Senha Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a Nova Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repita a Nova Senha";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(225, 106);
            this.txtSenhaAtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaAtual.MaxLength = 32;
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(132, 22);
            this.txtSenhaAtual.TabIndex = 3;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Enabled = false;
            this.txtNovaSenha.Location = new System.Drawing.Point(225, 172);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNovaSenha.MaxLength = 32;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(132, 22);
            this.txtNovaSenha.TabIndex = 4;
            // 
            // txtNovaSenha2
            // 
            this.txtNovaSenha2.Enabled = false;
            this.txtNovaSenha2.Location = new System.Drawing.Point(225, 239);
            this.txtNovaSenha2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNovaSenha2.MaxLength = 32;
            this.txtNovaSenha2.Name = "txtNovaSenha2";
            this.txtNovaSenha2.PasswordChar = '*';
            this.txtNovaSenha2.Size = new System.Drawing.Size(132, 22);
            this.txtNovaSenha2.TabIndex = 5;
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(383, 297);
            this.checkBoxMostrarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(116, 20);
            this.checkBoxMostrarSenha.TabIndex = 6;
            this.checkBoxMostrarSenha.Text = "Mostrar Senha";
            this.checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            this.checkBoxMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBoxMostrarSenha_CheckedChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGerar.Location = new System.Drawing.Point(85, 356);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(80, 34);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(224, 356);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 34);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "GERAR SENHA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGerarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.checkBoxMostrarSenha);
            this.Controls.Add(this.txtNovaSenha2);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormGerarSenha";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha2;
        private System.Windows.Forms.CheckBox checkBoxMostrarSenha;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
    }
}