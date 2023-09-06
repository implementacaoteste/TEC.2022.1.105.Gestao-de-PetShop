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
            System.Windows.Forms.Label descricaoLabel;
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAlterarFuncao = new System.Windows.Forms.Label();
            this.lblCadastrarFuncao = new System.Windows.Forms.Label();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.btnCancelarCadastroOuAlterar = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestaoPetShop.Properties.Resources.bicho_de_estimacao;
            this.pictureBox3.Location = new System.Drawing.Point(11, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblAlterarFuncao
            // 
            this.lblAlterarFuncao.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarFuncao.ForeColor = System.Drawing.Color.Black;
            this.lblAlterarFuncao.Location = new System.Drawing.Point(142, 39);
            this.lblAlterarFuncao.Name = "lblAlterarFuncao";
            this.lblAlterarFuncao.Size = new System.Drawing.Size(201, 26);
            this.lblAlterarFuncao.TabIndex = 13;
            this.lblAlterarFuncao.Text = "Alterar Função";
            this.lblAlterarFuncao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCadastrarFuncao
            // 
            this.lblCadastrarFuncao.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarFuncao.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarFuncao.Location = new System.Drawing.Point(115, 39);
            this.lblCadastrarFuncao.Name = "lblCadastrarFuncao";
            this.lblCadastrarFuncao.Size = new System.Drawing.Size(255, 26);
            this.lblCadastrarFuncao.TabIndex = 14;
            this.lblCadastrarFuncao.Text = "Cadastrar Função";
            this.lblCadastrarFuncao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarServico.BackgroundImage = global::GestaoPetShop.Properties.Resources.save_transparente1;
            this.btnSalvarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarServico.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvarServico.FlatAppearance.BorderSize = 0;
            this.btnSalvarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarServico.Location = new System.Drawing.Point(367, 247);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(38, 36);
            this.btnSalvarServico.TabIndex = 16;
            this.btnSalvarServico.UseVisualStyleBackColor = false;
            this.btnSalvarServico.Click += new System.EventHandler(this.btnSalvarServico_Click);
            // 
            // btnCancelarCadastroOuAlterar
            // 
            this.btnCancelarCadastroOuAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarCadastroOuAlterar.BackgroundImage = global::GestaoPetShop.Properties.Resources.cancel_removebg_preview;
            this.btnCancelarCadastroOuAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarCadastroOuAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarCadastroOuAlterar.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastroOuAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastroOuAlterar.Location = new System.Drawing.Point(425, 247);
            this.btnCancelarCadastroOuAlterar.Name = "btnCancelarCadastroOuAlterar";
            this.btnCancelarCadastroOuAlterar.Size = new System.Drawing.Size(38, 36);
            this.btnCancelarCadastroOuAlterar.TabIndex = 17;
            this.btnCancelarCadastroOuAlterar.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroOuAlterar.Click += new System.EventHandler(this.btnCancelarCadastroOuAlterar_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.Black;
            idLabel.Location = new System.Drawing.Point(16, 127);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 18);
            idLabel.TabIndex = 21;
            idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(19, 149);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(53, 24);
            this.idTextBox.TabIndex = 18;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.ForeColor = System.Drawing.Color.Black;
            descricaoLabel.Location = new System.Drawing.Point(81, 127);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(53, 18);
            descricaoLabel.TabIndex = 20;
            descricaoLabel.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(84, 149);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(379, 24);
            this.nomeTextBox.TabIndex = 19;
            // 
            // funcaoBindingSource
            // 
            this.funcaoBindingSource.DataSource = typeof(Models.Funcao);
            // 
            // FormCadastroFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 311);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.btnCancelarCadastroOuAlterar);
            this.Controls.Add(this.btnSalvarServico);
            this.Controls.Add(this.lblCadastrarFuncao);
            this.Controls.Add(this.lblAlterarFuncao);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroFuncao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroFuncao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAlterarFuncao;
        private System.Windows.Forms.Label lblCadastrarFuncao;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.Button btnCancelarCadastroOuAlterar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.BindingSource funcaoBindingSource;
    }
}