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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
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
            this.buttonBuscarFoto = new System.Windows.Forms.Button();
            this.telefoneClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.buttonInserirEmail = new System.Windows.Forms.Button();
            this.buttonInserirTelefone = new System.Windows.Forms.Button();
            this.emailClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExcluirEmail = new System.Windows.Forms.Button();
            this.buttonExcluirTelefone = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(24, 118);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(440, 118);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(33, 16);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // rGLabel
            // 
            rGLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(585, 219);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(34, 16);
            rGLabel.TabIndex = 5;
            rGLabel.Text = "CEP";
            // 
            // foneLabel
            // 
            foneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(243, 222);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(51, 16);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Cidade";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(411, 219);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(25, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "UF";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(24, 138);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(403, 22);
            this.nomeTextBox.TabIndex = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(437, 138);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(271, 22);
            this.cPFTextBox.TabIndex = 1;
            // 
            // rGTextBox
            // 
            this.rGTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CEP", true));
            this.rGTextBox.Location = new System.Drawing.Point(588, 239);
            this.rGTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(120, 22);
            this.rGTextBox.TabIndex = 9;
            // 
            // foneTextBox
            // 
            this.foneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cidade", true));
            this.foneTextBox.Location = new System.Drawing.Point(243, 239);
            this.foneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(161, 22);
            this.foneTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "UF", true));
            this.emailTextBox.Location = new System.Drawing.Point(411, 239);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(51, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSalvar.Location = new System.Drawing.Point(676, 576);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(87, 31);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(768, 576);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 31);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "País";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Pais", true));
            this.textBox1.Location = new System.Drawing.Point(468, 239);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Bairro", true));
            this.textBox2.Location = new System.Drawing.Point(24, 239);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bairro";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Numero", true));
            this.textBox3.Location = new System.Drawing.Point(629, 188);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Número";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Logradouro", true));
            this.textBox4.Location = new System.Drawing.Point(196, 188);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(427, 22);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Logradouro";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "DataNascimento", true));
            this.textBox5.Location = new System.Drawing.Point(21, 188);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 22);
            this.textBox5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data de nascimento";
            // 
            // AtivocheckBox1
            // 
            this.AtivocheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AtivocheckBox1.AutoSize = true;
            this.AtivocheckBox1.Checked = true;
            this.AtivocheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AtivocheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.clienteBindingSource, "Ativo", true));
            this.AtivocheckBox1.Location = new System.Drawing.Point(643, 271);
            this.AtivocheckBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtivocheckBox1.Name = "AtivocheckBox1";
            this.AtivocheckBox1.Size = new System.Drawing.Size(59, 20);
            this.AtivocheckBox1.TabIndex = 10;
            this.AtivocheckBox1.Text = "Ativo";
            this.AtivocheckBox1.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarFoto
            // 
            this.buttonBuscarFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscarFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscarFoto.Location = new System.Drawing.Point(732, 262);
            this.buttonBuscarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarFoto.Name = "buttonBuscarFoto";
            this.buttonBuscarFoto.Size = new System.Drawing.Size(116, 30);
            this.buttonBuscarFoto.TabIndex = 25;
            this.buttonBuscarFoto.Text = "Buscar foto";
            this.buttonBuscarFoto.UseVisualStyleBackColor = false;
            this.buttonBuscarFoto.Click += new System.EventHandler(this.buttonBuscarFoto_Click);
            // 
            // telefoneClientesDataGridView
            // 
            this.telefoneClientesDataGridView.AllowUserToAddRows = false;
            this.telefoneClientesDataGridView.AllowUserToDeleteRows = false;
            this.telefoneClientesDataGridView.AllowUserToOrderColumns = true;
            this.telefoneClientesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telefoneClientesDataGridView.AutoGenerateColumns = false;
            this.telefoneClientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.telefoneClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefoneClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.telefoneClientesDataGridView.DataSource = this.telefoneClientesBindingSource;
            this.telefoneClientesDataGridView.Location = new System.Drawing.Point(437, 391);
            this.telefoneClientesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefoneClientesDataGridView.Name = "telefoneClientesDataGridView";
            this.telefoneClientesDataGridView.ReadOnly = true;
            this.telefoneClientesDataGridView.RowHeadersVisible = false;
            this.telefoneClientesDataGridView.RowHeadersWidth = 51;
            this.telefoneClientesDataGridView.RowTemplate.Height = 24;
            this.telefoneClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.telefoneClientesDataGridView.Size = new System.Drawing.Size(417, 180);
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
            // telefoneClientesBindingSource
            // 
            this.telefoneClientesBindingSource.DataMember = "TelefoneClientes";
            this.telefoneClientesBindingSource.DataSource = this.clienteBindingSource;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmail.Location = new System.Drawing.Point(13, 347);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(263, 22);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTelefone.Location = new System.Drawing.Point(437, 350);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(265, 22);
            this.textBoxTelefone.TabIndex = 12;
            // 
            // buttonInserirEmail
            // 
            this.buttonInserirEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInserirEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserirEmail.Location = new System.Drawing.Point(284, 347);
            this.buttonInserirEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirEmail.Name = "buttonInserirEmail";
            this.buttonInserirEmail.Size = new System.Drawing.Size(69, 27);
            this.buttonInserirEmail.TabIndex = 30;
            this.buttonInserirEmail.Text = "Inserir";
            this.buttonInserirEmail.UseVisualStyleBackColor = false;
            this.buttonInserirEmail.Click += new System.EventHandler(this.buttonInserirEmail_Click);
            // 
            // buttonInserirTelefone
            // 
            this.buttonInserirTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInserirTelefone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserirTelefone.Location = new System.Drawing.Point(707, 348);
            this.buttonInserirTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirTelefone.Name = "buttonInserirTelefone";
            this.buttonInserirTelefone.Size = new System.Drawing.Size(69, 27);
            this.buttonInserirTelefone.TabIndex = 31;
            this.buttonInserirTelefone.Text = "Inserir";
            this.buttonInserirTelefone.UseVisualStyleBackColor = false;
            this.buttonInserirTelefone.Click += new System.EventHandler(this.buttonInserirTelefone_Click);
            // 
            // emailClienteDataGridView
            // 
            this.emailClienteDataGridView.AllowUserToAddRows = false;
            this.emailClienteDataGridView.AllowUserToDeleteRows = false;
            this.emailClienteDataGridView.AllowUserToOrderColumns = true;
            this.emailClienteDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailClienteDataGridView.AutoGenerateColumns = false;
            this.emailClienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.emailClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.emailClienteDataGridView.DataSource = this.emailClienteBindingSource;
            this.emailClienteDataGridView.Location = new System.Drawing.Point(11, 390);
            this.emailClienteDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailClienteDataGridView.Name = "emailClienteDataGridView";
            this.emailClienteDataGridView.ReadOnly = true;
            this.emailClienteDataGridView.RowHeadersVisible = false;
            this.emailClienteDataGridView.RowHeadersWidth = 51;
            this.emailClienteDataGridView.RowTemplate.Height = 24;
            this.emailClienteDataGridView.Size = new System.Drawing.Size(417, 180);
            this.emailClienteDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // emailClienteBindingSource
            // 
            this.emailClienteBindingSource.DataMember = "EmailCliente";
            this.emailClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // buttonExcluirEmail
            // 
            this.buttonExcluirEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExcluirEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluirEmail.Location = new System.Drawing.Point(355, 347);
            this.buttonExcluirEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirEmail.Name = "buttonExcluirEmail";
            this.buttonExcluirEmail.Size = new System.Drawing.Size(77, 27);
            this.buttonExcluirEmail.TabIndex = 32;
            this.buttonExcluirEmail.Text = "Excluir";
            this.buttonExcluirEmail.UseVisualStyleBackColor = false;
            this.buttonExcluirEmail.Click += new System.EventHandler(this.buttonExcluirEmail_Click);
            // 
            // buttonExcluirTelefone
            // 
            this.buttonExcluirTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExcluirTelefone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluirTelefone.Location = new System.Drawing.Point(777, 348);
            this.buttonExcluirTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirTelefone.Name = "buttonExcluirTelefone";
            this.buttonExcluirTelefone.Size = new System.Drawing.Size(77, 27);
            this.buttonExcluirTelefone.TabIndex = 33;
            this.buttonExcluirTelefone.Text = "Excluir";
            this.buttonExcluirTelefone.UseVisualStyleBackColor = false;
            this.buttonExcluirTelefone.Click += new System.EventHandler(this.buttonExcluirTelefone_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "Foto", true));
            this.pictureBoxFoto.Location = new System.Drawing.Point(732, 132);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(115, 126);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 24;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Digite e-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Digite telefone";
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonExcluirTelefone);
            this.Controls.Add(this.buttonExcluirEmail);
            this.Controls.Add(this.emailClienteDataGridView);
            this.Controls.Add(this.buttonInserirTelefone);
            this.Controls.Add(this.buttonInserirEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.telefoneClientesDataGridView);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 659);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(877, 659);
            this.Name = "FormCadastroCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
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
        private System.Windows.Forms.BindingSource telefoneClientesBindingSource;
        private System.Windows.Forms.DataGridView telefoneClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Button buttonInserirEmail;
        private System.Windows.Forms.Button buttonInserirTelefone;
        private System.Windows.Forms.BindingSource emailClienteBindingSource;
        private System.Windows.Forms.DataGridView emailClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonExcluirEmail;
        private System.Windows.Forms.Button buttonExcluirTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}