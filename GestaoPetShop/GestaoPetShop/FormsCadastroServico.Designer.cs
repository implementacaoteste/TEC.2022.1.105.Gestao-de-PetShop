﻿namespace GestaoPetShop
{
    partial class FormsCadastroServico
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
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label tempoLabel;
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.tempoTextBox = new System.Windows.Forms.TextBox();
            this.label1CadastrarServico = new System.Windows.Forms.Label();
            this.label2_AlterarServico = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_SalvarServico = new System.Windows.Forms.Button();
            this.button_CancelarCadastroOuAlterar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFechar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ativoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            tempoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.ForeColor = System.Drawing.Color.White;
            ativoLabel.Location = new System.Drawing.Point(28, 250);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(44, 18);
            ativoLabel.TabIndex = 1;
            ativoLabel.Text = "Ativo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.ForeColor = System.Drawing.Color.White;
            descricaoLabel.Location = new System.Drawing.Point(87, 126);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(76, 18);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descriçao";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.White;
            idLabel.Location = new System.Drawing.Point(22, 126);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 18);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.ForeColor = System.Drawing.Color.White;
            precoLabel.Location = new System.Drawing.Point(142, 185);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(48, 18);
            precoLabel.TabIndex = 7;
            precoLabel.Text = "Preco";
            // 
            // tempoLabel
            // 
            tempoLabel.AutoSize = true;
            tempoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempoLabel.ForeColor = System.Drawing.Color.White;
            tempoLabel.Location = new System.Drawing.Point(22, 185);
            tempoLabel.Name = "tempoLabel";
            tempoLabel.Size = new System.Drawing.Size(55, 18);
            tempoLabel.TabIndex = 9;
            tempoLabel.Text = "Tempo";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.servicoBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.ForeColor = System.Drawing.Color.White;
            this.ativoCheckBox.Location = new System.Drawing.Point(76, 249);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(262, 24);
            this.ativoCheckBox.TabIndex = 4;
            this.ativoCheckBox.Text = "Define se esse serviço pode ser usado";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(90, 148);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(379, 24);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(25, 148);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(53, 24);
            this.idTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTextBox.Location = new System.Drawing.Point(146, 206);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 24);
            this.precoTextBox.TabIndex = 3;
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Tempo", true));
            this.tempoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoTextBox.Location = new System.Drawing.Point(25, 206);
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.Size = new System.Drawing.Size(100, 24);
            this.tempoTextBox.TabIndex = 2;
            // 
            // label1CadastrarServico
            // 
            this.label1CadastrarServico.AutoSize = true;
            this.label1CadastrarServico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CadastrarServico.ForeColor = System.Drawing.Color.White;
            this.label1CadastrarServico.Location = new System.Drawing.Point(116, 57);
            this.label1CadastrarServico.Name = "label1CadastrarServico";
            this.label1CadastrarServico.Size = new System.Drawing.Size(218, 25);
            this.label1CadastrarServico.TabIndex = 11;
            this.label1CadastrarServico.Text = "Cadastro de Serviço";
            // 
            // label2_AlterarServico
            // 
            this.label2_AlterarServico.AutoSize = true;
            this.label2_AlterarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_AlterarServico.ForeColor = System.Drawing.Color.White;
            this.label2_AlterarServico.Location = new System.Drawing.Point(127, 57);
            this.label2_AlterarServico.Name = "label2_AlterarServico";
            this.label2_AlterarServico.Size = new System.Drawing.Size(183, 25);
            this.label2_AlterarServico.TabIndex = 12;
            this.label2_AlterarServico.Text = "Alterar de Serviço";
            // 
            // button_SalvarServico
            // 
            this.button_SalvarServico.BackColor = System.Drawing.Color.Transparent;
            this.button_SalvarServico.BackgroundImage = global::GestaoPetShop.Properties.Resources.save_transparente1;
            this.button_SalvarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SalvarServico.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_SalvarServico.FlatAppearance.BorderSize = 0;
            this.button_SalvarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SalvarServico.Location = new System.Drawing.Point(376, 234);
            this.button_SalvarServico.Name = "button_SalvarServico";
            this.button_SalvarServico.Size = new System.Drawing.Size(38, 36);
            this.button_SalvarServico.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button_SalvarServico, "Salvar");
            this.button_SalvarServico.UseVisualStyleBackColor = false;
            this.button_SalvarServico.Click += new System.EventHandler(this.button_SalvarServico_Click);
            // 
            // button_CancelarCadastroOuAlterar
            // 
            this.button_CancelarCadastroOuAlterar.BackColor = System.Drawing.Color.Transparent;
            this.button_CancelarCadastroOuAlterar.BackgroundImage = global::GestaoPetShop.Properties.Resources.cancel_removebg_preview;
            this.button_CancelarCadastroOuAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_CancelarCadastroOuAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_CancelarCadastroOuAlterar.FlatAppearance.BorderSize = 0;
            this.button_CancelarCadastroOuAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CancelarCadastroOuAlterar.Location = new System.Drawing.Point(430, 234);
            this.button_CancelarCadastroOuAlterar.Name = "button_CancelarCadastroOuAlterar";
            this.button_CancelarCadastroOuAlterar.Size = new System.Drawing.Size(38, 36);
            this.button_CancelarCadastroOuAlterar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button_CancelarCadastroOuAlterar, "Cancelar");
            this.button_CancelarCadastroOuAlterar.UseVisualStyleBackColor = false;
            this.button_CancelarCadastroOuAlterar.Click += new System.EventHandler(this.button_CancelarCadastroOuAlterar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBoxFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 34);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestaoPetShop.Properties.Resources.bicho_de_estimacao;
            this.pictureBox3.Location = new System.Drawing.Point(9, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxFechar
            // 
            this.pictureBoxFechar.Image = global::GestaoPetShop.Properties.Resources.close;
            this.pictureBoxFechar.Location = new System.Drawing.Point(473, 6);
            this.pictureBoxFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFechar.Name = "pictureBoxFechar";
            this.pictureBoxFechar.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFechar.TabIndex = 0;
            this.pictureBoxFechar.TabStop = false;
            this.pictureBoxFechar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoPetShop.Properties.Resources.png_transparent_pet_cat_animal_kitty_biological_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(350, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // FormsCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(165)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_SalvarServico;
            this.ClientSize = new System.Drawing.Size(503, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_CancelarCadastroOuAlterar);
            this.Controls.Add(this.button_SalvarServico);
            this.Controls.Add(this.label2_AlterarServico);
            this.Controls.Add(this.label1CadastrarServico);
            this.Controls.Add(tempoLabel);
            this.Controls.Add(this.tempoTextBox);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormsCadastroServico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviço";
            this.Load += new System.EventHandler(this.FormsCadastroServico_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox tempoTextBox;
        private System.Windows.Forms.Label label1CadastrarServico;
        private System.Windows.Forms.Label label2_AlterarServico;
        private System.Windows.Forms.Button button_SalvarServico;
        private System.Windows.Forms.Button button_CancelarCadastroOuAlterar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxFechar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}