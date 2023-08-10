namespace GestaoPetShop
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
            this.buttonImagem = new System.Windows.Forms.Button();
            this.button_CancelarCadastroOuAlterar = new System.Windows.Forms.Button();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ativoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            tempoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ativoLabel.Location = new System.Drawing.Point(31, 210);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(44, 18);
            ativoLabel.TabIndex = 1;
            ativoLabel.Text = "Ativo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(89, 86);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(76, 18);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descriçao";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(24, 86);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 18);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.Location = new System.Drawing.Point(145, 145);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(48, 18);
            precoLabel.TabIndex = 7;
            precoLabel.Text = "Preco";
            // 
            // tempoLabel
            // 
            tempoLabel.AutoSize = true;
            tempoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempoLabel.Location = new System.Drawing.Point(24, 145);
            tempoLabel.Name = "tempoLabel";
            tempoLabel.Size = new System.Drawing.Size(55, 18);
            tempoLabel.TabIndex = 9;
            tempoLabel.Text = "Tempo";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.servicoBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.Location = new System.Drawing.Point(78, 209);
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
            this.descricaoTextBox.Location = new System.Drawing.Point(92, 107);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(379, 24);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(27, 107);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(53, 24);
            this.idTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTextBox.Location = new System.Drawing.Point(148, 166);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 24);
            this.precoTextBox.TabIndex = 3;
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Tempo", true));
            this.tempoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoTextBox.Location = new System.Drawing.Point(27, 166);
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.Size = new System.Drawing.Size(100, 24);
            this.tempoTextBox.TabIndex = 2;
            // 
            // label1CadastrarServico
            // 
            this.label1CadastrarServico.AutoSize = true;
            this.label1CadastrarServico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CadastrarServico.Location = new System.Drawing.Point(118, 23);
            this.label1CadastrarServico.Name = "label1CadastrarServico";
            this.label1CadastrarServico.Size = new System.Drawing.Size(218, 25);
            this.label1CadastrarServico.TabIndex = 11;
            this.label1CadastrarServico.Text = "Cadastro de Serviço";
            // 
            // label2_AlterarServico
            // 
            this.label2_AlterarServico.AutoSize = true;
            this.label2_AlterarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_AlterarServico.Location = new System.Drawing.Point(129, 23);
            this.label2_AlterarServico.Name = "label2_AlterarServico";
            this.label2_AlterarServico.Size = new System.Drawing.Size(183, 25);
            this.label2_AlterarServico.TabIndex = 12;
            this.label2_AlterarServico.Text = "Alterar de Serviço";
            // 
            // button_SalvarServico
            // 
            this.button_SalvarServico.BackColor = System.Drawing.Color.Chocolate;
            this.button_SalvarServico.BackgroundImage = global::GestaoPetShop.Properties.Resources.save_transparente1;
            this.button_SalvarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SalvarServico.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_SalvarServico.FlatAppearance.BorderSize = 0;
            this.button_SalvarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SalvarServico.Location = new System.Drawing.Point(379, 182);
            this.button_SalvarServico.Name = "button_SalvarServico";
            this.button_SalvarServico.Size = new System.Drawing.Size(38, 36);
            this.button_SalvarServico.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button_SalvarServico, "Salvar");
            this.button_SalvarServico.UseVisualStyleBackColor = false;
            this.button_SalvarServico.Click += new System.EventHandler(this.button_SalvarServico_Click);
            // 
            // buttonImagem
            // 
            this.buttonImagem.BackgroundImage = global::GestaoPetShop.Properties.Resources.kitty;
            this.buttonImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonImagem.FlatAppearance.BorderSize = 0;
            this.buttonImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImagem.Location = new System.Drawing.Point(404, 23);
            this.buttonImagem.Name = "buttonImagem";
            this.buttonImagem.Size = new System.Drawing.Size(67, 61);
            this.buttonImagem.TabIndex = 15;
            this.buttonImagem.UseVisualStyleBackColor = true;
            // 
            // button_CancelarCadastroOuAlterar
            // 
            this.button_CancelarCadastroOuAlterar.BackColor = System.Drawing.Color.Chocolate;
            this.button_CancelarCadastroOuAlterar.BackgroundImage = global::GestaoPetShop.Properties.Resources.cancel_removebg_preview;
            this.button_CancelarCadastroOuAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_CancelarCadastroOuAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_CancelarCadastroOuAlterar.FlatAppearance.BorderSize = 0;
            this.button_CancelarCadastroOuAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CancelarCadastroOuAlterar.Location = new System.Drawing.Point(433, 182);
            this.button_CancelarCadastroOuAlterar.Name = "button_CancelarCadastroOuAlterar";
            this.button_CancelarCadastroOuAlterar.Size = new System.Drawing.Size(38, 36);
            this.button_CancelarCadastroOuAlterar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.button_CancelarCadastroOuAlterar, "Cancelar");
            this.button_CancelarCadastroOuAlterar.UseVisualStyleBackColor = false;
            this.button_CancelarCadastroOuAlterar.Click += new System.EventHandler(this.button_CancelarCadastroOuAlterar_Click);
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // FormsCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_SalvarServico;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.buttonImagem);
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
            this.MaximizeBox = false;
            this.Name = "FormsCadastroServico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviço";
            this.Load += new System.EventHandler(this.FormsCadastroServico_Load);
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
        private System.Windows.Forms.Button buttonImagem;
    }
}