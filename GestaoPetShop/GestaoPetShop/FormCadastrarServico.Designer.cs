namespace GestaoPetShop
{
    partial class FormCadastrarServico
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label tempoLabel;
            System.Windows.Forms.Label ativoLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.tempoTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2_AlterarServico = new System.Windows.Forms.Label();
            this.label1CadastrarServico = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            tempoLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(313, 103);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(316, 122);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(53, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(313, 177);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(69, 16);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descrição";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(316, 196);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(469, 26);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.Location = new System.Drawing.Point(562, 259);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(43, 16);
            precoLabel.TabIndex = 5;
            precoLabel.Text = "Preço";
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTextBox.Location = new System.Drawing.Point(565, 278);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(220, 26);
            this.precoTextBox.TabIndex = 6;
            this.precoTextBox.Click += new System.EventHandler(this.precoTextBox_Click);
            this.precoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempoTextBox_KeyPress);
            this.precoTextBox.Leave += new System.EventHandler(this.precoTextBox_Click);
            // 
            // tempoLabel
            // 
            tempoLabel.AutoSize = true;
            tempoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempoLabel.Location = new System.Drawing.Point(313, 259);
            tempoLabel.Name = "tempoLabel";
            tempoLabel.Size = new System.Drawing.Size(51, 16);
            tempoLabel.TabIndex = 7;
            tempoLabel.Text = "Tempo";
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Tempo", true));
            this.tempoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoTextBox.Location = new System.Drawing.Point(316, 278);
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.Size = new System.Drawing.Size(100, 26);
            this.tempoTextBox.TabIndex = 8;
            this.tempoTextBox.Click += new System.EventHandler(this.tempoTextBox_Click);
            this.tempoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempoTextBox_KeyPress);
            this.tempoTextBox.Leave += new System.EventHandler(this.tempoTextBox_Click);
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(313, 364);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(37, 16);
            ativoLabel.TabIndex = 9;
            ativoLabel.Text = "Ativo";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.servicoBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(316, 383);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(377, 24);
            this.ativoCheckBox.TabIndex = 10;
            this.ativoCheckBox.Text = "Define se esse serviço pode ser utilizado em agendamento ou não";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(361, 457);
            this.btnSalvar.MaximumSize = new System.Drawing.Size(141, 37);
            this.btnSalvar.MinimumSize = new System.Drawing.Size(141, 37);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 37);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(587, 457);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(141, 37);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(141, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 37);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2_AlterarServico
            // 
            this.label2_AlterarServico.AutoSize = true;
            this.label2_AlterarServico.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_AlterarServico.ForeColor = System.Drawing.Color.Black;
            this.label2_AlterarServico.Location = new System.Drawing.Point(451, 9);
            this.label2_AlterarServico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2_AlterarServico.Name = "label2_AlterarServico";
            this.label2_AlterarServico.Size = new System.Drawing.Size(242, 38);
            this.label2_AlterarServico.TabIndex = 14;
            this.label2_AlterarServico.Text = "Alterar Serviço";
            // 
            // label1CadastrarServico
            // 
            this.label1CadastrarServico.AutoSize = true;
            this.label1CadastrarServico.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CadastrarServico.ForeColor = System.Drawing.Color.Black;
            this.label1CadastrarServico.Location = new System.Drawing.Point(426, 9);
            this.label1CadastrarServico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1CadastrarServico.Name = "label1CadastrarServico";
            this.label1CadastrarServico.Size = new System.Drawing.Size(292, 38);
            this.label1CadastrarServico.TabIndex = 13;
            this.label1CadastrarServico.Text = "Cadastrar Serviço";
            // 
            // FormCadastrarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 594);
            this.Controls.Add(this.label2_AlterarServico);
            this.Controls.Add(this.label1CadastrarServico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(tempoLabel);
            this.Controls.Add(this.tempoTextBox);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 633);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 0);
            this.Name = "FormCadastrarServico";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormCadastrarServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox tempoTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2_AlterarServico;
        private System.Windows.Forms.Label label1CadastrarServico;
    }
}