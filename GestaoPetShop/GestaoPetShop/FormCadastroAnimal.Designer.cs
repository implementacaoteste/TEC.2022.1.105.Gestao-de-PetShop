namespace GestaoPetShop
{
    partial class FormCadastroAnimal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAnimal));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.labelNomeDoAnimal = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelAgressivo = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlergia = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.buttonBuscarRaca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(528, 53);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Animal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Nome", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 197);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 27);
            this.textBox1.TabIndex = 2;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(Models.Animal);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Sexo", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(286, 197);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 27);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Agressivo", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(360, 197);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 27);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Cor", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(11, 256);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 27);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Idade", true));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(286, 256);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 27);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Alergia", true));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(362, 256);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 27);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "DataNascimento", true));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(15, 311);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 27);
            this.textBox7.TabIndex = 8;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(420, 311);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(99, 28);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSalvar.Location = new System.Drawing.Point(316, 311);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(99, 28);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Checked = true;
            this.checkBoxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.animalBindingSource, "Ativo", true));
            this.checkBoxAtivo.Location = new System.Drawing.Point(214, 317);
            this.checkBoxAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(59, 20);
            this.checkBoxAtivo.TabIndex = 9;
            this.checkBoxAtivo.Text = "&Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // labelNomeDoAnimal
            // 
            this.labelNomeDoAnimal.AutoSize = true;
            this.labelNomeDoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeDoAnimal.Location = new System.Drawing.Point(14, 173);
            this.labelNomeDoAnimal.Name = "labelNomeDoAnimal";
            this.labelNomeDoAnimal.Size = new System.Drawing.Size(132, 20);
            this.labelNomeDoAnimal.TabIndex = 23;
            this.labelNomeDoAnimal.Text = "Nome do Animal";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(282, 175);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(46, 20);
            this.labelSexo.TabIndex = 24;
            this.labelSexo.Text = "Sexo";
            // 
            // labelAgressivo
            // 
            this.labelAgressivo.AutoSize = true;
            this.labelAgressivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgressivo.Location = new System.Drawing.Point(356, 175);
            this.labelAgressivo.Name = "labelAgressivo";
            this.labelAgressivo.Size = new System.Drawing.Size(83, 20);
            this.labelAgressivo.TabIndex = 25;
            this.labelAgressivo.Text = "Agressivo";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCor.Location = new System.Drawing.Point(14, 234);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(36, 20);
            this.labelCor.TabIndex = 26;
            this.labelCor.Text = "&Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "&Idade";
            // 
            // labelAlergia
            // 
            this.labelAlergia.AutoSize = true;
            this.labelAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlergia.Location = new System.Drawing.Point(360, 234);
            this.labelAlergia.Name = "labelAlergia";
            this.labelAlergia.Size = new System.Drawing.Size(61, 20);
            this.labelAlergia.TabIndex = 28;
            this.labelAlergia.Text = "&Alergia";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.Location = new System.Drawing.Point(11, 287);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(139, 20);
            this.labelDataNascimento.TabIndex = 29;
            this.labelDataNascimento.Text = "&Data Nascimento";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "NomeCliente", true));
            this.textBox8.Location = new System.Drawing.Point(11, 143);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(191, 22);
            this.textBox8.TabIndex = 30;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "NomeRaca", true));
            this.textBox9.Location = new System.Drawing.Point(286, 143);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(198, 22);
            this.textBox9.TabIndex = 31;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(214, 144);
            this.buttonBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(29, 23);
            this.buttonBuscarCliente.TabIndex = 0;
            this.buttonBuscarCliente.Text = "...";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // buttonBuscarRaca
            // 
            this.buttonBuscarRaca.Location = new System.Drawing.Point(489, 142);
            this.buttonBuscarRaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarRaca.Name = "buttonBuscarRaca";
            this.buttonBuscarRaca.Size = new System.Drawing.Size(29, 23);
            this.buttonBuscarRaca.TabIndex = 1;
            this.buttonBuscarRaca.Text = "...";
            this.buttonBuscarRaca.UseVisualStyleBackColor = true;
            this.buttonBuscarRaca.Click += new System.EventHandler(this.buttonBuscarRaca_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Selecione o Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Selecione a Raça";
            // 
            // FormCadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBuscarRaca);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelAlergia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCor);
            this.Controls.Add(this.labelAgressivo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelNomeDoAnimal);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormCadastroAnimal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.Label labelNomeDoAnimal;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelAgressivo;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAlergia;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.Button buttonBuscarRaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}