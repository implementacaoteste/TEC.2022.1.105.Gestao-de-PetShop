namespace GestaoPetShop
{
    partial class FormCadastroFuncao
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
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroFuncao));
            this.lblAlterarFuncao = new System.Windows.Forms.Label();
            this.lblCadastrarFuncao = new System.Windows.Forms.Label();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.btnCancelarCadastroOuAlterar = new System.Windows.Forms.Button();
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(407, 168);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 17);
            idLabel.TabIndex = 18;
            idLabel.Text = "Id";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(406, 248);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(45, 17);
            nomeLabel.TabIndex = 19;
            nomeLabel.Text = "Nome";
            // 
            // lblAlterarFuncao
            // 
            this.lblAlterarFuncao.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarFuncao.ForeColor = System.Drawing.Color.Black;
            this.lblAlterarFuncao.Location = new System.Drawing.Point(400, 22);
            this.lblAlterarFuncao.Name = "lblAlterarFuncao";
            this.lblAlterarFuncao.Size = new System.Drawing.Size(335, 48);
            this.lblAlterarFuncao.TabIndex = 13;
            this.lblAlterarFuncao.Text = "Alterar Função";
            this.lblAlterarFuncao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCadastrarFuncao
            // 
            this.lblCadastrarFuncao.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarFuncao.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarFuncao.Location = new System.Drawing.Point(375, 23);
            this.lblCadastrarFuncao.Name = "lblCadastrarFuncao";
            this.lblCadastrarFuncao.Size = new System.Drawing.Size(385, 47);
            this.lblCadastrarFuncao.TabIndex = 14;
            this.lblCadastrarFuncao.Text = "Cadastrar Função";
            this.lblCadastrarFuncao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalvarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarServico.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvarServico.FlatAppearance.BorderSize = 0;
            this.btnSalvarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarServico.ImageKey = "(none)";
            this.btnSalvarServico.Location = new System.Drawing.Point(409, 366);
            this.btnSalvarServico.MaximumSize = new System.Drawing.Size(141, 37);
            this.btnSalvarServico.MinimumSize = new System.Drawing.Size(141, 37);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(141, 37);
            this.btnSalvarServico.TabIndex = 16;
            this.btnSalvarServico.Tag = "Salvar";
            this.btnSalvarServico.Text = "Salvar";
            this.btnSalvarServico.UseVisualStyleBackColor = false;
            this.btnSalvarServico.Click += new System.EventHandler(this.btnSalvarServico_Click);
            // 
            // btnCancelarCadastroOuAlterar
            // 
            this.btnCancelarCadastroOuAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelarCadastroOuAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarCadastroOuAlterar.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastroOuAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastroOuAlterar.Location = new System.Drawing.Point(584, 366);
            this.btnCancelarCadastroOuAlterar.MaximumSize = new System.Drawing.Size(141, 37);
            this.btnCancelarCadastroOuAlterar.MinimumSize = new System.Drawing.Size(141, 37);
            this.btnCancelarCadastroOuAlterar.Name = "btnCancelarCadastroOuAlterar";
            this.btnCancelarCadastroOuAlterar.Size = new System.Drawing.Size(141, 37);
            this.btnCancelarCadastroOuAlterar.TabIndex = 17;
            this.btnCancelarCadastroOuAlterar.Text = "Cancelar";
            this.btnCancelarCadastroOuAlterar.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroOuAlterar.Click += new System.EventHandler(this.btnCancelarCadastroOuAlterar_Click);
            // 
            // funcaoBindingSource
            // 
            this.funcaoBindingSource.DataSource = typeof(Models.Funcao);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcaoBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(409, 190);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(76, 26);
            this.idTextBox.TabIndex = 19;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcaoBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(409, 267);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(316, 26);
            this.nomeTextBox.TabIndex = 20;
            // 
            // FormCadastroFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 594);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnCancelarCadastroOuAlterar);
            this.Controls.Add(this.btnSalvarServico);
            this.Controls.Add(this.lblCadastrarFuncao);
            this.Controls.Add(this.lblAlterarFuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 633);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 633);
            this.Name = "FormCadastroFuncao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroFuncao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlterarFuncao;
        private System.Windows.Forms.Label lblCadastrarFuncao;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.Button btnCancelarCadastroOuAlterar;
        private System.Windows.Forms.BindingSource funcaoBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}