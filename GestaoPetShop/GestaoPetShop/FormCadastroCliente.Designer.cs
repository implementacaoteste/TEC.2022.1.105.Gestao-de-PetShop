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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1CadastrarCliente = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.AtivocheckBox1 = new System.Windows.Forms.CheckBox();
            this.buttonBuscarFoto = new System.Windows.Forms.Button();
            this.telefoneClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
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
            this.label2AlterarCliente = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.rGTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPFTextBox = new System.Windows.Forms.MaskedTextBox();
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
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(11, 76);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(45, 17);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(490, 76);
            cPFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(34, 17);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // rGLabel
            // 
            rGLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            rGLabel.AutoSize = true;
            rGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rGLabel.Location = new System.Drawing.Point(793, 142);
            rGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(35, 17);
            rGLabel.TabIndex = 5;
            rGLabel.Text = "CEP";
            // 
            // foneLabel
            // 
            foneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            foneLabel.AutoSize = true;
            foneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foneLabel.Location = new System.Drawing.Point(494, 211);
            foneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(52, 17);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Cidade";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(714, 211);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(26, 17);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "UF";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(11, 94);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(442, 26);
            this.nomeTextBox.TabIndex = 0;
            this.nomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // foneTextBox
            // 
            this.foneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cidade", true));
            this.foneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foneTextBox.Location = new System.Drawing.Point(494, 232);
            this.foneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(181, 26);
            this.foneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "UF", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(714, 232);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.MaxLength = 2;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(61, 26);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            // 
            // label1CadastrarCliente
            // 
            this.label1CadastrarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1CadastrarCliente.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CadastrarCliente.Location = new System.Drawing.Point(244, 5);
            this.label1CadastrarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1CadastrarCliente.Name = "label1CadastrarCliente";
            this.label1CadastrarCliente.Size = new System.Drawing.Size(646, 40);
            this.label1CadastrarCliente.TabIndex = 0;
            this.label1CadastrarCliente.Text = "Cadastrar Cliente";
            this.label1CadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(841, 553);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.MaximumSize = new System.Drawing.Size(141, 37);
            this.buttonSalvar.MinimumSize = new System.Drawing.Size(141, 37);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(141, 37);
            this.buttonSalvar.TabIndex = 20;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(986, 553);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.MaximumSize = new System.Drawing.Size(141, 37);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(141, 37);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(141, 37);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(799, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "País";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Pais", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(799, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Bairro", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(11, 232);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 26);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bairro";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Numero", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(494, 163);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 26);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Número";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Logradouro", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(11, 163);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(442, 26);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Logradouro";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(793, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
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
            this.AtivocheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtivocheckBox1.Location = new System.Drawing.Point(898, 272);
            this.AtivocheckBox1.Margin = new System.Windows.Forms.Padding(2);
            this.AtivocheckBox1.Name = "AtivocheckBox1";
            this.AtivocheckBox1.Size = new System.Drawing.Size(58, 21);
            this.AtivocheckBox1.TabIndex = 19;
            this.AtivocheckBox1.Text = "Ativo";
            this.AtivocheckBox1.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarFoto
            // 
            this.buttonBuscarFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscarFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarFoto.Location = new System.Drawing.Point(982, 191);
            this.buttonBuscarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarFoto.MaximumSize = new System.Drawing.Size(141, 37);
            this.buttonBuscarFoto.MinimumSize = new System.Drawing.Size(141, 37);
            this.buttonBuscarFoto.Name = "buttonBuscarFoto";
            this.buttonBuscarFoto.Size = new System.Drawing.Size(141, 37);
            this.buttonBuscarFoto.TabIndex = 18;
            this.buttonBuscarFoto.Text = "Buscar foto";
            this.buttonBuscarFoto.UseVisualStyleBackColor = false;
            this.buttonBuscarFoto.Click += new System.EventHandler(this.buttonBuscarFoto_Click);
            // 
            // telefoneClientesDataGridView
            // 
            this.telefoneClientesDataGridView.AllowUserToAddRows = false;
            this.telefoneClientesDataGridView.AllowUserToDeleteRows = false;
            this.telefoneClientesDataGridView.AllowUserToOrderColumns = true;
            this.telefoneClientesDataGridView.AllowUserToResizeColumns = false;
            this.telefoneClientesDataGridView.AllowUserToResizeRows = false;
            this.telefoneClientesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telefoneClientesDataGridView.AutoGenerateColumns = false;
            this.telefoneClientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.telefoneClientesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.telefoneClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefoneClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.telefoneClientesDataGridView.DataSource = this.telefoneClientesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.telefoneClientesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.telefoneClientesDataGridView.Location = new System.Drawing.Point(581, 354);
            this.telefoneClientesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.telefoneClientesDataGridView.Name = "telefoneClientesDataGridView";
            this.telefoneClientesDataGridView.ReadOnly = true;
            this.telefoneClientesDataGridView.RowHeadersVisible = false;
            this.telefoneClientesDataGridView.RowHeadersWidth = 51;
            this.telefoneClientesDataGridView.RowTemplate.Height = 24;
            this.telefoneClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.telefoneClientesDataGridView.Size = new System.Drawing.Size(542, 189);
            this.telefoneClientesDataGridView.TabIndex = 17;
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
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(14, 317);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(249, 26);
            this.textBoxEmail.TabIndex = 10;
            // 
            // buttonInserirEmail
            // 
            this.buttonInserirEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInserirEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserirEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirEmail.Location = new System.Drawing.Point(267, 313);
            this.buttonInserirEmail.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserirEmail.MaximumSize = new System.Drawing.Size(141, 37);
            this.buttonInserirEmail.MinimumSize = new System.Drawing.Size(141, 37);
            this.buttonInserirEmail.Name = "buttonInserirEmail";
            this.buttonInserirEmail.Size = new System.Drawing.Size(141, 37);
            this.buttonInserirEmail.TabIndex = 11;
            this.buttonInserirEmail.Text = "Inserir";
            this.buttonInserirEmail.UseVisualStyleBackColor = false;
            this.buttonInserirEmail.Click += new System.EventHandler(this.buttonInserirEmail_Click);
            // 
            // buttonInserirTelefone
            // 
            this.buttonInserirTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInserirTelefone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserirTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirTelefone.Location = new System.Drawing.Point(841, 313);
            this.buttonInserirTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserirTelefone.MaximumSize = new System.Drawing.Size(141, 37);
            this.buttonInserirTelefone.MinimumSize = new System.Drawing.Size(141, 37);
            this.buttonInserirTelefone.Name = "buttonInserirTelefone";
            this.buttonInserirTelefone.Size = new System.Drawing.Size(141, 37);
            this.buttonInserirTelefone.TabIndex = 15;
            this.buttonInserirTelefone.Text = "Inserir";
            this.buttonInserirTelefone.UseVisualStyleBackColor = false;
            this.buttonInserirTelefone.Click += new System.EventHandler(this.buttonInserirTelefone_Click);
            // 
            // emailClienteDataGridView
            // 
            this.emailClienteDataGridView.AllowUserToAddRows = false;
            this.emailClienteDataGridView.AllowUserToDeleteRows = false;
            this.emailClienteDataGridView.AllowUserToOrderColumns = true;
            this.emailClienteDataGridView.AllowUserToResizeColumns = false;
            this.emailClienteDataGridView.AllowUserToResizeRows = false;
            this.emailClienteDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailClienteDataGridView.AutoGenerateColumns = false;
            this.emailClienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emailClienteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.emailClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.emailClienteDataGridView.DataSource = this.emailClienteBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.emailClienteDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.emailClienteDataGridView.Location = new System.Drawing.Point(14, 354);
            this.emailClienteDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.emailClienteDataGridView.Name = "emailClienteDataGridView";
            this.emailClienteDataGridView.ReadOnly = true;
            this.emailClienteDataGridView.RowHeadersVisible = false;
            this.emailClienteDataGridView.RowHeadersWidth = 51;
            this.emailClienteDataGridView.RowTemplate.Height = 24;
            this.emailClienteDataGridView.Size = new System.Drawing.Size(540, 189);
            this.emailClienteDataGridView.TabIndex = 13;
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
            this.buttonExcluirEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirEmail.Location = new System.Drawing.Point(412, 313);
            this.buttonExcluirEmail.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirEmail.MaximumSize = new System.Drawing.Size(141, 37);
            this.buttonExcluirEmail.MinimumSize = new System.Drawing.Size(141, 37);
            this.buttonExcluirEmail.Name = "buttonExcluirEmail";
            this.buttonExcluirEmail.Size = new System.Drawing.Size(141, 37);
            this.buttonExcluirEmail.TabIndex = 12;
            this.buttonExcluirEmail.Text = "Excluir";
            this.buttonExcluirEmail.UseVisualStyleBackColor = false;
            this.buttonExcluirEmail.Click += new System.EventHandler(this.buttonExcluirEmail_Click);
            // 
            // buttonExcluirTelefone
            // 
            this.buttonExcluirTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExcluirTelefone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluirTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirTelefone.Location = new System.Drawing.Point(986, 313);
            this.buttonExcluirTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirTelefone.MaximumSize = new System.Drawing.Size(141, 37);
            this.buttonExcluirTelefone.MinimumSize = new System.Drawing.Size(141, 37);
            this.buttonExcluirTelefone.Name = "buttonExcluirTelefone";
            this.buttonExcluirTelefone.Size = new System.Drawing.Size(141, 37);
            this.buttonExcluirTelefone.TabIndex = 16;
            this.buttonExcluirTelefone.Text = "Excluir";
            this.buttonExcluirTelefone.UseVisualStyleBackColor = false;
            this.buttonExcluirTelefone.Click += new System.EventHandler(this.buttonExcluirTelefone_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxFoto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "Foto", true));
            this.pictureBoxFoto.Location = new System.Drawing.Point(999, 76);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(106, 111);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 24;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Digite o e-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Digite o telefone";
            // 
            // label2AlterarCliente
            // 
            this.label2AlterarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2AlterarCliente.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2AlterarCliente.Location = new System.Drawing.Point(244, 5);
            this.label2AlterarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2AlterarCliente.Name = "label2AlterarCliente";
            this.label2AlterarCliente.Size = new System.Drawing.Size(646, 40);
            this.label2AlterarCliente.TabIndex = 35;
            this.label2AlterarCliente.Text = "Alterar Cliente";
            this.label2AlterarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "DataNascimento", true));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(796, 94);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Mask = "00/00/0000";
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 26);
            this.textBox5.TabIndex = 38;
            this.textBox5.ValidatingType = typeof(System.DateTime);
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefone.Location = new System.Drawing.Point(585, 318);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefone.Mask = "(99) 00000-0000";
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(252, 26);
            this.textBoxTelefone.TabIndex = 39;
            this.textBoxTelefone.Click += new System.EventHandler(this.textBoxTelefone_Click);
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CEP", true));
            this.rGTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rGTextBox.Location = new System.Drawing.Point(796, 161);
            this.rGTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rGTextBox.Mask = "00000-999";
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(161, 26);
            this.rGTextBox.TabIndex = 40;
            this.rGTextBox.Click += new System.EventHandler(this.rGTextBox_Click);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFTextBox.Location = new System.Drawing.Point(493, 94);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cPFTextBox.Mask = "000,000,000-00";
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(229, 26);
            this.cPFTextBox.TabIndex = 41;
            this.cPFTextBox.Click += new System.EventHandler(this.cPFTextBox_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 594);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2AlterarCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonExcluirTelefone);
            this.Controls.Add(this.buttonExcluirEmail);
            this.Controls.Add(this.emailClienteDataGridView);
            this.Controls.Add(this.buttonInserirTelefone);
            this.Controls.Add(this.buttonInserirEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.telefoneClientesDataGridView);
            this.Controls.Add(this.buttonBuscarFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.AtivocheckBox1);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.label1CadastrarCliente);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 633);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1150, 633);
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
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1CadastrarCliente;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox AtivocheckBox1;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonBuscarFoto;
        private System.Windows.Forms.BindingSource telefoneClientesBindingSource;
        private System.Windows.Forms.DataGridView telefoneClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonInserirEmail;
        private System.Windows.Forms.Button buttonInserirTelefone;
        private System.Windows.Forms.BindingSource emailClienteBindingSource;
        private System.Windows.Forms.DataGridView emailClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonExcluirEmail;
        private System.Windows.Forms.Button buttonExcluirTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2AlterarCliente;
        private System.Windows.Forms.MaskedTextBox textBox5;
        private System.Windows.Forms.MaskedTextBox textBoxTelefone;
        private System.Windows.Forms.MaskedTextBox rGTextBox;
        private System.Windows.Forms.MaskedTextBox cPFTextBox;
    }
}