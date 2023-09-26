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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsCadastroServico));
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.tempoTextBox = new System.Windows.Forms.TextBox();
            this.label1CadastrarServico = new System.Windows.Forms.Label();
            this.label2_AlterarServico = new System.Windows.Forms.Label();
            this.button_SalvarServico = new System.Windows.Forms.Button();
            this.button_CancelarCadastroOuAlterar = new System.Windows.Forms.Button();
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
            ativoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(107)))), ((int)(((byte)(62)))));
            ativoLabel.Location = new System.Drawing.Point(20, 237);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(44, 18);
            ativoLabel.TabIndex = 1;
            ativoLabel.Text = "Ativo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(107)))), ((int)(((byte)(62)))));
            descricaoLabel.Location = new System.Drawing.Point(80, 113);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(76, 18);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descriçao";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(107)))), ((int)(((byte)(62)))));
            idLabel.Location = new System.Drawing.Point(14, 113);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 18);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(107)))), ((int)(((byte)(62)))));
            precoLabel.Location = new System.Drawing.Point(134, 172);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(48, 18);
            precoLabel.TabIndex = 7;
            precoLabel.Text = "Preco";
            // 
            // tempoLabel
            // 
            tempoLabel.AutoSize = true;
            tempoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(107)))), ((int)(((byte)(62)))));
            tempoLabel.Location = new System.Drawing.Point(14, 172);
            tempoLabel.Name = "tempoLabel";
            tempoLabel.Size = new System.Drawing.Size(55, 18);
            tempoLabel.TabIndex = 9;
            tempoLabel.Text = "Tempo";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.servicoBindingSource, "Ativo", true));
            this.ativoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ativoCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(107)))), ((int)(((byte)(62)))));
            this.ativoCheckBox.Location = new System.Drawing.Point(68, 236);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(210, 24);
            this.ativoCheckBox.TabIndex = 4;
            this.ativoCheckBox.Text = "Define se esse serviço pode ser usado";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(82, 135);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(296, 24);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(17, 135);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(53, 24);
            this.idTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTextBox.Location = new System.Drawing.Point(139, 193);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 24);
            this.precoTextBox.TabIndex = 3;
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Tempo", true));
            this.tempoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoTextBox.Location = new System.Drawing.Point(17, 193);
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.Size = new System.Drawing.Size(100, 24);
            this.tempoTextBox.TabIndex = 2;
            // 
            // label1CadastrarServico
            // 
            this.label1CadastrarServico.AutoSize = true;
            this.label1CadastrarServico.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CadastrarServico.ForeColor = System.Drawing.Color.Black;
            this.label1CadastrarServico.Location = new System.Drawing.Point(86, 37);
            this.label1CadastrarServico.Name = "label1CadastrarServico";
            this.label1CadastrarServico.Size = new System.Drawing.Size(230, 26);
            this.label1CadastrarServico.TabIndex = 11;
            this.label1CadastrarServico.Text = "Cadastro de Serviço";
            // 
            // label2_AlterarServico
            // 
            this.label2_AlterarServico.AutoSize = true;
            this.label2_AlterarServico.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_AlterarServico.ForeColor = System.Drawing.Color.Black;
            this.label2_AlterarServico.Location = new System.Drawing.Point(96, 37);
            this.label2_AlterarServico.Name = "label2_AlterarServico";
            this.label2_AlterarServico.Size = new System.Drawing.Size(201, 26);
            this.label2_AlterarServico.TabIndex = 12;
            this.label2_AlterarServico.Text = "Alterar de Serviço";
            // 
            // button_SalvarServico
            // 
            this.button_SalvarServico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_SalvarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_SalvarServico.FlatAppearance.BorderSize = 0;
            this.button_SalvarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SalvarServico.Location = new System.Drawing.Point(259, 255);
            this.button_SalvarServico.Name = "button_SalvarServico";
            this.button_SalvarServico.Size = new System.Drawing.Size(57, 26);
            this.button_SalvarServico.TabIndex = 13;
            this.button_SalvarServico.Text = "Salvar";
            this.button_SalvarServico.UseVisualStyleBackColor = false;
            this.button_SalvarServico.Click += new System.EventHandler(this.button_SalvarServico_Click);
            // 
            // button_CancelarCadastroOuAlterar
            // 
            this.button_CancelarCadastroOuAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_CancelarCadastroOuAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_CancelarCadastroOuAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_CancelarCadastroOuAlterar.FlatAppearance.BorderSize = 0;
            this.button_CancelarCadastroOuAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CancelarCadastroOuAlterar.Location = new System.Drawing.Point(322, 253);
            this.button_CancelarCadastroOuAlterar.Name = "button_CancelarCadastroOuAlterar";
            this.button_CancelarCadastroOuAlterar.Size = new System.Drawing.Size(66, 28);
            this.button_CancelarCadastroOuAlterar.TabIndex = 14;
            this.button_CancelarCadastroOuAlterar.Text = "Cancelar";
            this.button_CancelarCadastroOuAlterar.UseVisualStyleBackColor = false;
            this.button_CancelarCadastroOuAlterar.Click += new System.EventHandler(this.button_CancelarCadastroOuAlterar_Click);
            // 
            // FormsCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_SalvarServico;
            this.ClientSize = new System.Drawing.Size(400, 293);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 332);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 332);
            this.Name = "FormsCadastroServico";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}