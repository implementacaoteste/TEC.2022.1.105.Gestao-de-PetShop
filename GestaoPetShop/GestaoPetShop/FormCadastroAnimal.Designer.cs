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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNomeDoAnimal = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelAgressivo = new System.Windows.Forms.Label();
            this.labelCor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlergia = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(800, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Animal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(230, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(351, 151);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 22);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(30, 217);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 22);
            this.textBox7.TabIndex = 18;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(713, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(615, 418);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 21;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.animalBindingSource, "Ativo", true));
            this.checkBoxAtivo.Location = new System.Drawing.Point(12, 418);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(59, 20);
            this.checkBoxAtivo.TabIndex = 22;
            this.checkBoxAtivo.Text = "&Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(Models.Animal);
            // 
            // labelNomeDoAnimal
            // 
            this.labelNomeDoAnimal.AutoSize = true;
            this.labelNomeDoAnimal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Nome", true));
            this.labelNomeDoAnimal.Location = new System.Drawing.Point(27, 72);
            this.labelNomeDoAnimal.Name = "labelNomeDoAnimal";
            this.labelNomeDoAnimal.Size = new System.Drawing.Size(107, 16);
            this.labelNomeDoAnimal.TabIndex = 23;
            this.labelNomeDoAnimal.Text = "Nome do Animal";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Sexo", true));
            this.labelSexo.Location = new System.Drawing.Point(235, 72);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(38, 16);
            this.labelSexo.TabIndex = 24;
            this.labelSexo.Text = "Sexo";
            // 
            // labelAgressivo
            // 
            this.labelAgressivo.AutoSize = true;
            this.labelAgressivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Agressivo", true));
            this.labelAgressivo.Location = new System.Drawing.Point(348, 72);
            this.labelAgressivo.Name = "labelAgressivo";
            this.labelAgressivo.Size = new System.Drawing.Size(68, 16);
            this.labelAgressivo.TabIndex = 25;
            this.labelAgressivo.Text = "Agressivo";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Cor", true));
            this.labelCor.Location = new System.Drawing.Point(27, 132);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(28, 16);
            this.labelCor.TabIndex = 26;
            this.labelCor.Text = "&Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Idade", true));
            this.label2.Location = new System.Drawing.Point(235, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "&Idade";
            // 
            // labelAlergia
            // 
            this.labelAlergia.AutoSize = true;
            this.labelAlergia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Alergia", true));
            this.labelAlergia.Location = new System.Drawing.Point(351, 132);
            this.labelAlergia.Name = "labelAlergia";
            this.labelAlergia.Size = new System.Drawing.Size(50, 16);
            this.labelAlergia.TabIndex = 28;
            this.labelAlergia.Text = "&Alergia";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "DataNascimento", true));
            this.labelDataNascimento.Location = new System.Drawing.Point(30, 200);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(111, 16);
            this.labelDataNascimento.TabIndex = 29;
            this.labelDataNascimento.Text = "&Data Nascimento";
            // 
            // FormCadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormCadastroAnimal";
            this.Text = "Cadastro de Animal";
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
    }
}