﻿namespace GestaoPetShop
{
    partial class FormCadastroProfissional
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
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label cPFLabel1;
            System.Windows.Forms.Label cEPLabel1;
            System.Windows.Forms.Label nomeFuncaoLabel;
            System.Windows.Forms.Label idFuncaoLabel;
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.profissionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.uFTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonBuscarFoto = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.buttonInserirEmail = new System.Windows.Forms.Button();
            this.buttonExcluirEmail = new System.Windows.Forms.Button();
            this.buttonInserirTelefone = new System.Windows.Forms.Button();
            this.buttonExcluirTelefone = new System.Windows.Forms.Button();
            this.emailProfissionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailProfissionalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneProfissionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneProfissionalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.lblProfissional = new System.Windows.Forms.Label();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.textBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.nomeFuncaoComboBox = new System.Windows.Forms.ComboBox();
            this.idFuncaoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            cPFLabel1 = new System.Windows.Forms.Label();
            cEPLabel1 = new System.Windows.Forms.Label();
            nomeFuncaoLabel = new System.Windows.Forms.Label();
            idFuncaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailProfissionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailProfissionalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneProfissionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneProfissionalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(117, 158);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(46, 16);
            bairroLabel.TabIndex = 3;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(355, 158);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(54, 16);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "Cidade:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(27, 110);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(114, 16);
            dataNascimentoLabel.TabIndex = 11;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(151, 110);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(80, 16);
            logradouroLabel.TabIndex = 17;
            logradouroLabel.Text = "Logradouro:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(27, 65);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 19;
            nomeLabel.Text = "Nome:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(27, 158);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(58, 16);
            numeroLabel.TabIndex = 21;
            numeroLabel.Text = "Numero:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(179, 206);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(37, 16);
            paisLabel.TabIndex = 23;
            paisLabel.Text = "Pais:";
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(129, 202);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(28, 16);
            uFLabel.TabIndex = 25;
            uFLabel.Text = "UF:";
            // 
            // cPFLabel1
            // 
            cPFLabel1.AutoSize = true;
            cPFLabel1.Location = new System.Drawing.Point(455, 64);
            cPFLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel1.Name = "cPFLabel1";
            cPFLabel1.Size = new System.Drawing.Size(36, 16);
            cPFLabel1.TabIndex = 37;
            cPFLabel1.Text = "CPF:";
            // 
            // cEPLabel1
            // 
            cEPLabel1.AutoSize = true;
            cEPLabel1.Location = new System.Drawing.Point(25, 204);
            cEPLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cEPLabel1.Name = "cEPLabel1";
            cEPLabel1.Size = new System.Drawing.Size(37, 16);
            cEPLabel1.TabIndex = 38;
            cEPLabel1.Text = "CEP:";
            // 
            // nomeFuncaoLabel
            // 
            nomeFuncaoLabel.AutoSize = true;
            nomeFuncaoLabel.Location = new System.Drawing.Point(445, 206);
            nomeFuncaoLabel.Name = "nomeFuncaoLabel";
            nomeFuncaoLabel.Size = new System.Drawing.Size(95, 16);
            nomeFuncaoLabel.TabIndex = 38;
            nomeFuncaoLabel.Text = "Nome Funcao:";
            // 
            // idFuncaoLabel
            // 
            idFuncaoLabel.AutoSize = true;
            idFuncaoLabel.Location = new System.Drawing.Point(363, 206);
            idFuncaoLabel.Name = "idFuncaoLabel";
            idFuncaoLabel.Size = new System.Drawing.Size(69, 16);
            idFuncaoLabel.TabIndex = 39;
            idFuncaoLabel.Text = "Id Funcao:";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.profissionalBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(293, 224);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(77, 25);
            this.ativoCheckBox.TabIndex = 10;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // profissionalBindingSource
            // 
            this.profissionalBindingSource.DataSource = typeof(Models.Profissional);
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(120, 177);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(224, 22);
            this.bairroTextBox.TabIndex = 5;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(357, 177);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(224, 22);
            this.cidadeTextBox.TabIndex = 6;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "Logradouro", true));
            this.logradouroTextBox.Location = new System.Drawing.Point(155, 129);
            this.logradouroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(428, 22);
            this.logradouroTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(29, 84);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(421, 22);
            this.nomeTextBox.TabIndex = 0;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(29, 177);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(73, 22);
            this.numeroTextBox.TabIndex = 4;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(182, 224);
            this.paisTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(105, 22);
            this.paisTextBox.TabIndex = 9;
            // 
            // uFTextBox
            // 
            this.uFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "UF", true));
            this.uFTextBox.Location = new System.Drawing.Point(132, 224);
            this.uFTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uFTextBox.Name = "uFTextBox";
            this.uFTextBox.Size = new System.Drawing.Size(44, 22);
            this.uFTextBox.TabIndex = 8;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.profissionalBindingSource, "Foto", true));
            this.pictureBoxFoto.Location = new System.Drawing.Point(648, 41);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(125, 135);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 27;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonBuscarFoto
            // 
            this.buttonBuscarFoto.Location = new System.Drawing.Point(648, 183);
            this.buttonBuscarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarFoto.Name = "buttonBuscarFoto";
            this.buttonBuscarFoto.Size = new System.Drawing.Size(125, 26);
            this.buttonBuscarFoto.TabIndex = 14;
            this.buttonBuscarFoto.Text = "Buscar Foto";
            this.buttonBuscarFoto.UseVisualStyleBackColor = true;
            this.buttonBuscarFoto.Click += new System.EventHandler(this.buttonBuscarFoto_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(29, 285);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 22);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(405, 285);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(203, 22);
            this.textBoxTelefone.TabIndex = 13;
            // 
            // buttonInserirEmail
            // 
            this.buttonInserirEmail.Location = new System.Drawing.Point(239, 285);
            this.buttonInserirEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirEmail.Name = "buttonInserirEmail";
            this.buttonInserirEmail.Size = new System.Drawing.Size(76, 26);
            this.buttonInserirEmail.TabIndex = 12;
            this.buttonInserirEmail.Text = "Inserir";
            this.buttonInserirEmail.UseVisualStyleBackColor = true;
            this.buttonInserirEmail.Click += new System.EventHandler(this.buttonInserirEmail_Click);
            // 
            // buttonExcluirEmail
            // 
            this.buttonExcluirEmail.Location = new System.Drawing.Point(321, 285);
            this.buttonExcluirEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirEmail.Name = "buttonExcluirEmail";
            this.buttonExcluirEmail.Size = new System.Drawing.Size(76, 26);
            this.buttonExcluirEmail.TabIndex = 18;
            this.buttonExcluirEmail.Text = "Excluir";
            this.buttonExcluirEmail.UseVisualStyleBackColor = true;
            this.buttonExcluirEmail.Click += new System.EventHandler(this.buttonExcluirEmail_Click);
            // 
            // buttonInserirTelefone
            // 
            this.buttonInserirTelefone.Location = new System.Drawing.Point(615, 285);
            this.buttonInserirTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirTelefone.Name = "buttonInserirTelefone";
            this.buttonInserirTelefone.Size = new System.Drawing.Size(76, 26);
            this.buttonInserirTelefone.TabIndex = 14;
            this.buttonInserirTelefone.Text = "Inserir";
            this.buttonInserirTelefone.UseVisualStyleBackColor = true;
            this.buttonInserirTelefone.Click += new System.EventHandler(this.buttonInserirTelefone_Click);
            // 
            // buttonExcluirTelefone
            // 
            this.buttonExcluirTelefone.Location = new System.Drawing.Point(696, 285);
            this.buttonExcluirTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirTelefone.Name = "buttonExcluirTelefone";
            this.buttonExcluirTelefone.Size = new System.Drawing.Size(76, 26);
            this.buttonExcluirTelefone.TabIndex = 19;
            this.buttonExcluirTelefone.Text = "Excluir";
            this.buttonExcluirTelefone.UseVisualStyleBackColor = true;
            this.buttonExcluirTelefone.Click += new System.EventHandler(this.buttonExcluirTelefone_Click);
            // 
            // emailProfissionalBindingSource
            // 
            this.emailProfissionalBindingSource.DataMember = "EmailProfissional";
            this.emailProfissionalBindingSource.DataSource = this.profissionalBindingSource;
            // 
            // emailProfissionalDataGridView
            // 
            this.emailProfissionalDataGridView.AllowUserToAddRows = false;
            this.emailProfissionalDataGridView.AllowUserToDeleteRows = false;
            this.emailProfissionalDataGridView.AllowUserToOrderColumns = true;
            this.emailProfissionalDataGridView.AutoGenerateColumns = false;
            this.emailProfissionalDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.emailProfissionalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailProfissionalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.emailProfissionalDataGridView.DataSource = this.emailProfissionalBindingSource;
            this.emailProfissionalDataGridView.Location = new System.Drawing.Point(29, 314);
            this.emailProfissionalDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailProfissionalDataGridView.Name = "emailProfissionalDataGridView";
            this.emailProfissionalDataGridView.ReadOnly = true;
            this.emailProfissionalDataGridView.RowHeadersVisible = false;
            this.emailProfissionalDataGridView.RowHeadersWidth = 51;
            this.emailProfissionalDataGridView.RowTemplate.Height = 24;
            this.emailProfissionalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emailProfissionalDataGridView.Size = new System.Drawing.Size(367, 140);
            this.emailProfissionalDataGridView.TabIndex = 34;
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
            // telefoneProfissionalBindingSource
            // 
            this.telefoneProfissionalBindingSource.DataMember = "TelefoneProfissional";
            this.telefoneProfissionalBindingSource.DataSource = this.profissionalBindingSource;
            // 
            // telefoneProfissionalDataGridView
            // 
            this.telefoneProfissionalDataGridView.AllowUserToAddRows = false;
            this.telefoneProfissionalDataGridView.AllowUserToDeleteRows = false;
            this.telefoneProfissionalDataGridView.AllowUserToOrderColumns = true;
            this.telefoneProfissionalDataGridView.AutoGenerateColumns = false;
            this.telefoneProfissionalDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.telefoneProfissionalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefoneProfissionalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            this.telefoneProfissionalDataGridView.DataSource = this.telefoneProfissionalBindingSource;
            this.telefoneProfissionalDataGridView.Location = new System.Drawing.Point(405, 314);
            this.telefoneProfissionalDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefoneProfissionalDataGridView.Name = "telefoneProfissionalDataGridView";
            this.telefoneProfissionalDataGridView.ReadOnly = true;
            this.telefoneProfissionalDataGridView.RowHeadersVisible = false;
            this.telefoneProfissionalDataGridView.RowHeadersWidth = 51;
            this.telefoneProfissionalDataGridView.RowTemplate.Height = 24;
            this.telefoneProfissionalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.telefoneProfissionalDataGridView.Size = new System.Drawing.Size(367, 140);
            this.telefoneProfissionalDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(593, 465);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(76, 26);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(675, 465);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(76, 26);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // lblProfissional
            // 
            this.lblProfissional.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProfissional.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissional.Location = new System.Drawing.Point(0, 0);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(804, 49);
            this.lblProfissional.TabIndex = 37;
            this.lblProfissional.Text = "Cadastro de Profissional";
            this.lblProfissional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(459, 84);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(124, 22);
            this.cPFTextBox.TabIndex = 1;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(29, 224);
            this.cEPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(96, 22);
            this.cEPTextBox.TabIndex = 7;
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "DataNascimento", true));
            this.textBoxDataNascimento.Location = new System.Drawing.Point(29, 129);
            this.textBoxDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.Size = new System.Drawing.Size(117, 22);
            this.textBoxDataNascimento.TabIndex = 2;
            // 
            // nomeFuncaoComboBox
            // 
            this.nomeFuncaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "NomeFuncao", true));
            this.nomeFuncaoComboBox.FormattingEnabled = true;
            this.nomeFuncaoComboBox.Location = new System.Drawing.Point(448, 222);
            this.nomeFuncaoComboBox.Name = "nomeFuncaoComboBox";
            this.nomeFuncaoComboBox.Size = new System.Drawing.Size(135, 24);
            this.nomeFuncaoComboBox.TabIndex = 11;
            this.nomeFuncaoComboBox.SelectedIndexChanged += new System.EventHandler(this.nomeFuncaoComboBox_SelectedIndexChanged);
            // 
            // idFuncaoTextBox
            // 
            this.idFuncaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profissionalBindingSource, "IdFuncao", true));
            this.idFuncaoTextBox.Location = new System.Drawing.Point(366, 224);
            this.idFuncaoTextBox.Name = "idFuncaoTextBox";
            this.idFuncaoTextBox.Size = new System.Drawing.Size(66, 22);
            this.idFuncaoTextBox.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(637, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cadastrar Usuário";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCadastroProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 517);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.button1);
            this.Controls.Add(idFuncaoLabel);
            this.Controls.Add(this.idFuncaoTextBox);
            this.Controls.Add(nomeFuncaoLabel);
            this.Controls.Add(this.nomeFuncaoComboBox);
            this.Controls.Add(this.textBoxDataNascimento);
            this.Controls.Add(cEPLabel1);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(cPFLabel1);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.telefoneProfissionalDataGridView);
            this.Controls.Add(this.emailProfissionalDataGridView);
            this.Controls.Add(this.buttonExcluirTelefone);
            this.Controls.Add(this.buttonInserirTelefone);
            this.Controls.Add(this.buttonExcluirEmail);
            this.Controls.Add(this.buttonInserirEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonBuscarFoto);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(logradouroLabel);
            this.Controls.Add(this.logradouroTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(uFLabel);
            this.Controls.Add(this.uFTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroProfissional";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroProfissional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailProfissionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailProfissionalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneProfissionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneProfissionalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource profissionalBindingSource;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox uFTextBox;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonBuscarFoto;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Button buttonInserirEmail;
        private System.Windows.Forms.Button buttonExcluirEmail;
        private System.Windows.Forms.Button buttonInserirTelefone;
        private System.Windows.Forms.Button buttonExcluirTelefone;
        private System.Windows.Forms.BindingSource emailProfissionalBindingSource;
        private System.Windows.Forms.DataGridView emailProfissionalDataGridView;
        private System.Windows.Forms.BindingSource telefoneProfissionalBindingSource;
        private System.Windows.Forms.DataGridView telefoneProfissionalDataGridView;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label lblProfissional;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBoxDataNascimento;
        private System.Windows.Forms.ComboBox nomeFuncaoComboBox;
        private System.Windows.Forms.TextBox idFuncaoTextBox;
        private System.Windows.Forms.Button button1;
    }
}