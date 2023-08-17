namespace GestaoPetShop
{
    partial class FormCadastroCliente
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label emailLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AtivocheckBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonBuscarFoto = new System.Windows.Forms.Button();
            this.emailClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.buttonInserirEmail = new System.Windows.Forms.Button();
            this.buttonInserirTelefone = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(5, 49);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(305, 49);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(33, 16);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(305, 102);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(34, 16);
            rGLabel.TabIndex = 5;
            rGLabel.Text = "CEP";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(5, 153);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(51, 16);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Cidade";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(220, 102);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(25, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "UF";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(4, 68);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(295, 22);
            this.nomeTextBox.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(307, 68);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(215, 22);
            this.cPFTextBox.TabIndex = 4;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CEP", true));
            this.rGTextBox.Location = new System.Drawing.Point(308, 121);
            this.rGTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(213, 22);
            this.rGTextBox.TabIndex = 6;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cidade", true));
            this.foneTextBox.Location = new System.Drawing.Point(4, 171);
            this.foneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(160, 22);
            this.foneTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "UF", true));
            this.emailTextBox.Location = new System.Drawing.Point(220, 121);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(49, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(596, 432);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(689, 432);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "País";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Pais", true));
            this.textBox1.Location = new System.Drawing.Point(169, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Bairro", true));
            this.textBox2.Location = new System.Drawing.Point(287, 171);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bairro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Numero", true));
            this.textBox3.Location = new System.Drawing.Point(5, 226);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Número";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Logradouro", true));
            this.textBox4.Location = new System.Drawing.Point(121, 226);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 22);
            this.textBox4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Logradouro";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "DataNascimento", true));
            this.textBox5.Location = new System.Drawing.Point(4, 121);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 22);
            this.textBox5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data De Nascimento";
            // 
            // AtivocheckBox1
            // 
            this.AtivocheckBox1.AutoSize = true;
            this.AtivocheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.clienteBindingSource, "Ativo", true));
            this.AtivocheckBox1.Location = new System.Drawing.Point(416, 228);
            this.AtivocheckBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtivocheckBox1.Name = "AtivocheckBox1";
            this.AtivocheckBox1.Size = new System.Drawing.Size(59, 20);
            this.AtivocheckBox1.TabIndex = 23;
            this.AtivocheckBox1.Text = "Ativo";
            this.AtivocheckBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "Foto", true));
            this.pictureBoxFoto.Location = new System.Drawing.Point(544, 52);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(113, 125);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 24;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonBuscarFoto
            // 
            this.buttonBuscarFoto.Location = new System.Drawing.Point(544, 183);
            this.buttonBuscarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarFoto.Name = "buttonBuscarFoto";
            this.buttonBuscarFoto.Size = new System.Drawing.Size(113, 23);
            this.buttonBuscarFoto.TabIndex = 25;
            this.buttonBuscarFoto.Text = "Buscar foto";
            this.buttonBuscarFoto.UseVisualStyleBackColor = true;
            this.buttonBuscarFoto.Click += new System.EventHandler(this.buttonBuscarFoto_Click);
            // 
            // emailClienteBindingSource
            // 
            this.emailClienteBindingSource.DataMember = "EmailCliente";
            this.emailClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // emailClienteDataGridView
            // 
            this.emailClienteDataGridView.AllowUserToAddRows = false;
            this.emailClienteDataGridView.AllowUserToDeleteRows = false;
            this.emailClienteDataGridView.AllowUserToOrderColumns = true;
            this.emailClienteDataGridView.AutoGenerateColumns = false;
            this.emailClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.emailClienteDataGridView.DataSource = this.emailClienteBindingSource;
            this.emailClienteDataGridView.Location = new System.Drawing.Point(12, 304);
            this.emailClienteDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailClienteDataGridView.Name = "emailClienteDataGridView";
            this.emailClienteDataGridView.ReadOnly = true;
            this.emailClienteDataGridView.RowHeadersVisible = false;
            this.emailClienteDataGridView.RowHeadersWidth = 51;
            this.emailClienteDataGridView.RowTemplate.Height = 24;
            this.emailClienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emailClienteDataGridView.Size = new System.Drawing.Size(316, 121);
            this.emailClienteDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // telefoneClientesBindingSource
            // 
            this.telefoneClientesBindingSource.DataMember = "TelefoneClientes";
            this.telefoneClientesBindingSource.DataSource = this.clienteBindingSource;
            // 
            // telefoneClientesDataGridView
            // 
            this.telefoneClientesDataGridView.AllowUserToAddRows = false;
            this.telefoneClientesDataGridView.AllowUserToDeleteRows = false;
            this.telefoneClientesDataGridView.AllowUserToOrderColumns = true;
            this.telefoneClientesDataGridView.AutoGenerateColumns = false;
            this.telefoneClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefoneClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.telefoneClientesDataGridView.DataSource = this.telefoneClientesBindingSource;
            this.telefoneClientesDataGridView.Location = new System.Drawing.Point(441, 304);
            this.telefoneClientesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefoneClientesDataGridView.Name = "telefoneClientesDataGridView";
            this.telefoneClientesDataGridView.ReadOnly = true;
            this.telefoneClientesDataGridView.RowHeadersVisible = false;
            this.telefoneClientesDataGridView.RowHeadersWidth = 51;
            this.telefoneClientesDataGridView.RowTemplate.Height = 24;
            this.telefoneClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.telefoneClientesDataGridView.Size = new System.Drawing.Size(257, 124);
            this.telefoneClientesDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 276);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(257, 22);
            this.textBoxEmail.TabIndex = 28;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(441, 276);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(176, 22);
            this.textBoxTelefone.TabIndex = 29;
            // 
            // buttonInserirEmail
            // 
            this.buttonInserirEmail.Location = new System.Drawing.Point(275, 274);
            this.buttonInserirEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirEmail.Name = "buttonInserirEmail";
            this.buttonInserirEmail.Size = new System.Drawing.Size(63, 23);
            this.buttonInserirEmail.TabIndex = 30;
            this.buttonInserirEmail.Text = "Inserir";
            this.buttonInserirEmail.UseVisualStyleBackColor = true;
            this.buttonInserirEmail.Click += new System.EventHandler(this.buttonInserirEmail_Click);
            // 
            // buttonInserirTelefone
            // 
            this.buttonInserirTelefone.Location = new System.Drawing.Point(623, 274);
            this.buttonInserirTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirTelefone.Name = "buttonInserirTelefone";
            this.buttonInserirTelefone.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirTelefone.TabIndex = 31;
            this.buttonInserirTelefone.Text = "Inserir";
            this.buttonInserirTelefone.UseVisualStyleBackColor = true;
            this.buttonInserirTelefone.Click += new System.EventHandler(this.buttonInserirTelefone_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoPetShop.Properties.Resources.papel_de_parede_2;
            this.ClientSize = new System.Drawing.Size(789, 493);
            this.Controls.Add(this.buttonInserirTelefone);
            this.Controls.Add(this.buttonInserirEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.telefoneClientesDataGridView);
            this.Controls.Add(this.emailClienteDataGridView);
            this.Controls.Add(this.buttonBuscarFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.AtivocheckBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroCliente";
            this.ShowInTaskbar = false;
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox AtivocheckBox1;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonBuscarFoto;
        private System.Windows.Forms.BindingSource emailClienteBindingSource;
        private System.Windows.Forms.DataGridView emailClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource telefoneClientesBindingSource;
        private System.Windows.Forms.DataGridView telefoneClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Button buttonInserirEmail;
        private System.Windows.Forms.Button buttonInserirTelefone;
    }
}