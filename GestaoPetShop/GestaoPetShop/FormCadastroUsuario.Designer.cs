namespace GestaoPetShop
{
    partial class FormCadastroUsuario
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
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label usuarioLoginLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.usuarioLoginTextBox = new System.Windows.Forms.TextBox();
            this.idTextBoxProfissional = new System.Windows.Forms.TextBox();
            this.nomeTextBoxProfissional = new System.Windows.Forms.TextBox();
            this.btnBuscarProfissional = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            senhaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            usuarioLoginLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.Location = new System.Drawing.Point(38, 285);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(50, 18);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(167, 285);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 18);
            label1.TabIndex = 11;
            label1.Text = "Confirmar senha";
            // 
            // usuarioLoginLabel
            // 
            usuarioLoginLabel.AutoSize = true;
            usuarioLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLoginLabel.Location = new System.Drawing.Point(39, 226);
            usuarioLoginLabel.Name = "usuarioLoginLabel";
            usuarioLoginLabel.Size = new System.Drawing.Size(104, 18);
            usuarioLoginLabel.TabIndex = 15;
            usuarioLoginLabel.Text = "Usuario Login:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(107, 20);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 15;
            idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(187, 20);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 16;
            nomeLabel.Text = "Nome:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(41, 307);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(115, 22);
            this.senhaTextBox.TabIndex = 2;
            this.senhaTextBox.Tag = "*";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Checked = true;
            this.ativoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(273, 246);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(59, 20);
            this.ativoCheckBox.TabIndex = 4;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(170, 307);
            this.textBoxConfirmarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.PasswordChar = '*';
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(115, 22);
            this.textBoxConfirmarSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadastro de Usuários";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSalvar.Location = new System.Drawing.Point(291, 303);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 31);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.Location = new System.Drawing.Point(371, 303);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(99, 31);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // usuarioLoginTextBox
            // 
            this.usuarioLoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "UsuarioLogin", true));
            this.usuarioLoginTextBox.Location = new System.Drawing.Point(42, 246);
            this.usuarioLoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuarioLoginTextBox.Name = "usuarioLoginTextBox";
            this.usuarioLoginTextBox.Size = new System.Drawing.Size(176, 22);
            this.usuarioLoginTextBox.TabIndex = 1;
            // 
            // idTextBoxProfissional
            // 
            this.idTextBoxProfissional.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IdProfissional", true));
            this.idTextBoxProfissional.Enabled = false;
            this.idTextBoxProfissional.Location = new System.Drawing.Point(109, 38);
            this.idTextBoxProfissional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBoxProfissional.Name = "idTextBoxProfissional";
            this.idTextBoxProfissional.Size = new System.Drawing.Size(49, 22);
            this.idTextBoxProfissional.TabIndex = 16;
            // 
            // nomeTextBoxProfissional
            // 
            this.nomeTextBoxProfissional.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeProfissional", true));
            this.nomeTextBoxProfissional.Enabled = false;
            this.nomeTextBoxProfissional.Location = new System.Drawing.Point(189, 38);
            this.nomeTextBoxProfissional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBoxProfissional.Name = "nomeTextBoxProfissional";
            this.nomeTextBoxProfissional.Size = new System.Drawing.Size(135, 22);
            this.nomeTextBoxProfissional.TabIndex = 17;
            // 
            // btnBuscarProfissional
            // 
            this.btnBuscarProfissional.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscarProfissional.Location = new System.Drawing.Point(159, 87);
            this.btnBuscarProfissional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarProfissional.Name = "btnBuscarProfissional";
            this.btnBuscarProfissional.Size = new System.Drawing.Size(189, 28);
            this.btnBuscarProfissional.TabIndex = 0;
            this.btnBuscarProfissional.Text = "Pesquisar Profissional";
            this.btnBuscarProfissional.UseVisualStyleBackColor = false;
            this.btnBuscarProfissional.Click += new System.EventHandler(this.btnBuscarProfissional_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(371, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTextBoxProfissional);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.nomeTextBoxProfissional);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Location = new System.Drawing.Point(41, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(429, 74);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarProfissional);
            this.Controls.Add(usuarioLoginLabel);
            this.Controls.Add(this.usuarioLoginTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(label1);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormCadastroUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox usuarioLoginTextBox;
        private System.Windows.Forms.TextBox idTextBoxProfissional;
        private System.Windows.Forms.TextBox nomeTextBoxProfissional;
        private System.Windows.Forms.Button btnBuscarProfissional;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}