﻿namespace GestaoPetShop
{
    partial class FormCadastroAgendamento
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label label;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label horarioLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label idAnimalLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idProfissionalLabel;
            System.Windows.Forms.Label nomeAnimalLabel;
            System.Windows.Forms.Label nomeClienteLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label nomeProfissionalLabel1;
            System.Windows.Forms.Label descricaoSituacaoLabel;
            System.Windows.Forms.Label dataAgLabel;
            System.Windows.Forms.Label idSituacaoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idSituacaoTextBox = new System.Windows.Forms.TextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataAgDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.descricaoSituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.nomeProfissionalComboBox = new System.Windows.Forms.ComboBox();
            this.horarioTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.idAnimalTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.idProfissionalTextBox = new System.Windows.Forms.TextBox();
            this.nomeAnimalTextBox = new System.Windows.Forms.TextBox();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.buttonPesquisarAnimal = new System.Windows.Forms.Button();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoServicosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxPrecoAplicado = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.button_InserirServicoAgendamento = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.agendamentoServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorComDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1RemoverServico = new System.Windows.Forms.Button();
            this.groupBoxServico = new System.Windows.Forms.GroupBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            horarioLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            idAnimalLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idProfissionalLabel = new System.Windows.Forms.Label();
            nomeAnimalLabel = new System.Windows.Forms.Label();
            nomeClienteLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            nomeProfissionalLabel1 = new System.Windows.Forms.Label();
            descricaoSituacaoLabel = new System.Windows.Forms.Label();
            dataAgLabel = new System.Windows.Forms.Label();
            idSituacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicoDataGridView)).BeginInit();
            this.groupBoxServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(72, 9);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 15;
            descricaoLabel.Text = "Descricao:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 9);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 17;
            idLabel.Text = "Id:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(467, 9);
            label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(96, 16);
            label.TabIndex = 19;
            label.Text = "Preço /Unitário";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(587, 9);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 16);
            label8.TabIndex = 23;
            label8.Text = "Preço Aplicado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(375, 9);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 16);
            label9.TabIndex = 24;
            label9.Text = "Quantidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(708, 9);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 16);
            label10.TabIndex = 27;
            label10.Text = "Subtotal";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(429, 14);
            horarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(55, 16);
            horarioLabel.TabIndex = 26;
            horarioLabel.Text = "Horario:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(32, 14);
            idLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(21, 16);
            idLabel1.TabIndex = 28;
            idLabel1.Text = "Id:";
            // 
            // idAnimalLabel
            // 
            idAnimalLabel.AutoSize = true;
            idAnimalLabel.Location = new System.Drawing.Point(27, 73);
            idAnimalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAnimalLabel.Name = "idAnimalLabel";
            idAnimalLabel.Size = new System.Drawing.Size(65, 16);
            idAnimalLabel.TabIndex = 30;
            idAnimalLabel.Text = "Id Animal:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(576, 73);
            idClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(65, 16);
            idClienteLabel.TabIndex = 32;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idProfissionalLabel
            // 
            idProfissionalLabel.AutoSize = true;
            idProfissionalLabel.Location = new System.Drawing.Point(49, 118);
            idProfissionalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idProfissionalLabel.Name = "idProfissionalLabel";
            idProfissionalLabel.Size = new System.Drawing.Size(94, 16);
            idProfissionalLabel.TabIndex = 34;
            idProfissionalLabel.Text = "Id Profissional:";
            // 
            // nomeAnimalLabel
            // 
            nomeAnimalLabel.AutoSize = true;
            nomeAnimalLabel.Location = new System.Drawing.Point(184, 73);
            nomeAnimalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeAnimalLabel.Name = "nomeAnimalLabel";
            nomeAnimalLabel.Size = new System.Drawing.Size(91, 16);
            nomeAnimalLabel.TabIndex = 38;
            nomeAnimalLabel.Text = "Nome Animal:";
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(716, 73);
            nomeClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(91, 16);
            nomeClienteLabel.TabIndex = 40;
            nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(765, 118);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(41, 16);
            totalLabel.TabIndex = 44;
            totalLabel.Text = "Total:";
            // 
            // nomeProfissionalLabel1
            // 
            nomeProfissionalLabel1.AutoSize = true;
            nomeProfissionalLabel1.Location = new System.Drawing.Point(280, 118);
            nomeProfissionalLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeProfissionalLabel1.Name = "nomeProfissionalLabel1";
            nomeProfissionalLabel1.Size = new System.Drawing.Size(120, 16);
            nomeProfissionalLabel1.TabIndex = 46;
            nomeProfissionalLabel1.Text = "Nome Profissional:";
            // 
            // descricaoSituacaoLabel
            // 
            descricaoSituacaoLabel.AutoSize = true;
            descricaoSituacaoLabel.Location = new System.Drawing.Point(843, 20);
            descricaoSituacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoSituacaoLabel.Name = "descricaoSituacaoLabel";
            descricaoSituacaoLabel.Size = new System.Drawing.Size(128, 16);
            descricaoSituacaoLabel.TabIndex = 47;
            descricaoSituacaoLabel.Text = "Descricao Situacao:";
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(149, 14);
            dataAgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(59, 16);
            dataAgLabel.TabIndex = 51;
            dataAgLabel.Text = "Data Ag:";
            // 
            // idSituacaoLabel
            // 
            idSituacaoLabel.AutoSize = true;
            idSituacaoLabel.Location = new System.Drawing.Point(661, 18);
            idSituacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idSituacaoLabel.Name = "idSituacaoLabel";
            idSituacaoLabel.Size = new System.Drawing.Size(77, 16);
            idSituacaoLabel.TabIndex = 52;
            idSituacaoLabel.Text = "Id Situacao:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(20, 289);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(43, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // idSituacaoTextBox
            // 
            this.idSituacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdSituacao", true));
            this.idSituacaoTextBox.Location = new System.Drawing.Point(755, 15);
            this.idSituacaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idSituacaoTextBox.Name = "idSituacaoTextBox";
            this.idSituacaoTextBox.Size = new System.Drawing.Size(60, 22);
            this.idSituacaoTextBox.TabIndex = 53;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // dataAgDateTimePicker
            // 
            this.dataAgDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgDateTimePicker.Location = new System.Drawing.Point(221, 9);
            this.dataAgDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataAgDateTimePicker.Name = "dataAgDateTimePicker";
            this.dataAgDateTimePicker.Size = new System.Drawing.Size(199, 22);
            this.dataAgDateTimePicker.TabIndex = 52;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendamentoBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(1000, 112);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(59, 20);
            this.ativoCheckBox.TabIndex = 49;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descricaoSituacaoComboBox
            // 
            this.descricaoSituacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DescricaoSituacao", true));
            this.descricaoSituacaoComboBox.FormattingEnabled = true;
            this.descricaoSituacaoComboBox.Location = new System.Drawing.Point(993, 15);
            this.descricaoSituacaoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoSituacaoComboBox.Name = "descricaoSituacaoComboBox";
            this.descricaoSituacaoComboBox.Size = new System.Drawing.Size(160, 24);
            this.descricaoSituacaoComboBox.TabIndex = 48;
            this.descricaoSituacaoComboBox.SelectedIndexChanged += new System.EventHandler(this.descricaoSituacaoComboBox_SelectedIndexChanged);
            // 
            // nomeProfissionalComboBox
            // 
            this.nomeProfissionalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "NomeProfissional", true));
            this.nomeProfissionalComboBox.FormattingEnabled = true;
            this.nomeProfissionalComboBox.Location = new System.Drawing.Point(412, 114);
            this.nomeProfissionalComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeProfissionalComboBox.Name = "nomeProfissionalComboBox";
            this.nomeProfissionalComboBox.Size = new System.Drawing.Size(160, 24);
            this.nomeProfissionalComboBox.TabIndex = 47;
            this.nomeProfissionalComboBox.SelectedIndexChanged += new System.EventHandler(this.nomeProfissionalComboBox_SelectedIndexChanged);
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Horario", true));
            this.horarioTextBox.Location = new System.Drawing.Point(497, 10);
            this.horarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(135, 22);
            this.horarioTextBox.TabIndex = 27;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Id", true));
            this.idTextBox1.Enabled = false;
            this.idTextBox1.Location = new System.Drawing.Point(65, 10);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(72, 22);
            this.idTextBox1.TabIndex = 29;
            // 
            // idAnimalTextBox
            // 
            this.idAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.idAnimalTextBox.Location = new System.Drawing.Point(99, 68);
            this.idAnimalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idAnimalTextBox.Name = "idAnimalTextBox";
            this.idAnimalTextBox.Size = new System.Drawing.Size(71, 22);
            this.idAnimalTextBox.TabIndex = 31;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(648, 68);
            this.idClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(43, 22);
            this.idClienteTextBox.TabIndex = 33;
            // 
            // idProfissionalTextBox
            // 
            this.idProfissionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdProfissional", true));
            this.idProfissionalTextBox.Location = new System.Drawing.Point(149, 114);
            this.idProfissionalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idProfissionalTextBox.Name = "idProfissionalTextBox";
            this.idProfissionalTextBox.Size = new System.Drawing.Size(84, 22);
            this.idProfissionalTextBox.TabIndex = 35;
            // 
            // nomeAnimalTextBox
            // 
            this.nomeAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "NomeAnimal", true));
            this.nomeAnimalTextBox.Location = new System.Drawing.Point(283, 68);
            this.nomeAnimalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeAnimalTextBox.Name = "nomeAnimalTextBox";
            this.nomeAnimalTextBox.Size = new System.Drawing.Size(265, 22);
            this.nomeAnimalTextBox.TabIndex = 39;
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "NomeCliente", true));
            this.nomeClienteTextBox.Location = new System.Drawing.Point(820, 68);
            this.nomeClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(192, 22);
            this.nomeClienteTextBox.TabIndex = 41;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(824, 114);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(156, 22);
            this.totalTextBox.TabIndex = 45;
            // 
            // buttonPesquisarAnimal
            // 
            this.buttonPesquisarAnimal.Location = new System.Drawing.Point(1024, 73);
            this.buttonPesquisarAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPesquisarAnimal.Name = "buttonPesquisarAnimal";
            this.buttonPesquisarAnimal.Size = new System.Drawing.Size(85, 23);
            this.buttonPesquisarAnimal.TabIndex = 22;
            this.buttonPesquisarAnimal.Text = "Pesq";
            this.buttonPesquisarAnimal.UseVisualStyleBackColor = true;
            this.buttonPesquisarAnimal.Click += new System.EventHandler(this.buttonPesquisarAnimal_Click);
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoServicosBindingSource, "IdServico", true));
            this.descricaoComboBox.DataSource = this.servicoBindingSource;
            this.descricaoComboBox.DisplayMember = "Descricao";
            this.descricaoComboBox.FormattingEnabled = true;
            this.descricaoComboBox.Location = new System.Drawing.Point(75, 30);
            this.descricaoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(293, 24);
            this.descricaoComboBox.TabIndex = 1;
            this.descricaoComboBox.ValueMember = "Id";
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // agendamentoServicosBindingSource
            // 
            this.agendamentoServicosBindingSource.DataSource = this.agendamentoServicosBindingSource1;
            // 
            // agendamentoServicosBindingSource1
            // 
            this.agendamentoServicosBindingSource1.DataMember = "AgendamentoServicos";
            this.agendamentoServicosBindingSource1.DataSource = this.agendamentoBindingSource;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.BackColor = System.Drawing.Color.White;
            this.textBoxSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoServicosBindingSource, "ValorTotal", true));
            this.textBoxSubtotal.Location = new System.Drawing.Point(707, 30);
            this.textBoxSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(109, 22);
            this.textBoxSubtotal.TabIndex = 5;
            // 
            // textBoxPrecoAplicado
            // 
            this.textBoxPrecoAplicado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoServicosBindingSource, "ValorComDesconto", true));
            this.textBoxPrecoAplicado.Location = new System.Drawing.Point(591, 30);
            this.textBoxPrecoAplicado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecoAplicado.Name = "textBoxPrecoAplicado";
            this.textBoxPrecoAplicado.Size = new System.Drawing.Size(105, 22);
            this.textBoxPrecoAplicado.TabIndex = 4;
            this.textBoxPrecoAplicado.TextChanged += new System.EventHandler(this.textBoxPrecoAplicado_TextChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoServicosBindingSource, "Quantidade", true));
            this.textBoxQuantidade.Location = new System.Drawing.Point(379, 30);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(73, 22);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.Text = "1";
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxPrecoAplicado_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoServicosBindingSource, "IdServico", true));
            this.idTextBox.Location = new System.Drawing.Point(7, 30);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(59, 22);
            this.idTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.BackColor = System.Drawing.Color.White;
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(459, 30);
            this.precoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.ReadOnly = true;
            this.precoTextBox.Size = new System.Drawing.Size(123, 22);
            this.precoTextBox.TabIndex = 3;
            this.precoTextBox.TextChanged += new System.EventHandler(this.precoTextBox_TextChanged);
            // 
            // button_InserirServicoAgendamento
            // 
            this.button_InserirServicoAgendamento.Location = new System.Drawing.Point(823, 30);
            this.button_InserirServicoAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.button_InserirServicoAgendamento.Name = "button_InserirServicoAgendamento";
            this.button_InserirServicoAgendamento.Size = new System.Drawing.Size(85, 25);
            this.button_InserirServicoAgendamento.TabIndex = 7;
            this.button_InserirServicoAgendamento.Text = "Inserir";
            this.button_InserirServicoAgendamento.UseVisualStyleBackColor = true;
            this.button_InserirServicoAgendamento.Click += new System.EventHandler(this.button_InserirServicoAgendamento_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(24, 246);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(79, 25);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(1055, 484);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 25);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // agendamentoServicoDataGridView
            // 
            this.agendamentoServicoDataGridView.AllowUserToAddRows = false;
            this.agendamentoServicoDataGridView.AllowUserToDeleteRows = false;
            this.agendamentoServicoDataGridView.AllowUserToOrderColumns = true;
            this.agendamentoServicoDataGridView.AutoGenerateColumns = false;
            this.agendamentoServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendamentoServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.servicoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.valorComDescontoDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.idServicoDataGridViewTextBoxColumn,
            this.tempoDataGridViewTextBoxColumn});
            this.agendamentoServicoDataGridView.DataSource = this.agendamentoServicosBindingSource;
            this.agendamentoServicoDataGridView.Location = new System.Drawing.Point(71, 289);
            this.agendamentoServicoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.agendamentoServicoDataGridView.Name = "agendamentoServicoDataGridView";
            this.agendamentoServicoDataGridView.ReadOnly = true;
            this.agendamentoServicoDataGridView.RowHeadersVisible = false;
            this.agendamentoServicoDataGridView.RowHeadersWidth = 51;
            this.agendamentoServicoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agendamentoServicoDataGridView.Size = new System.Drawing.Size(1091, 182);
            this.agendamentoServicoDataGridView.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicoDataGridViewTextBoxColumn
            // 
            this.servicoDataGridViewTextBoxColumn.DataPropertyName = "Servico";
            this.servicoDataGridViewTextBoxColumn.HeaderText = "Servico";
            this.servicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicoDataGridViewTextBoxColumn.Name = "servicoDataGridViewTextBoxColumn";
            this.servicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorComDescontoDataGridViewTextBoxColumn
            // 
            this.valorComDescontoDataGridViewTextBoxColumn.DataPropertyName = "ValorComDesconto";
            this.valorComDescontoDataGridViewTextBoxColumn.HeaderText = "ValorComDesconto";
            this.valorComDescontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorComDescontoDataGridViewTextBoxColumn.Name = "valorComDescontoDataGridViewTextBoxColumn";
            this.valorComDescontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorComDescontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // idServicoDataGridViewTextBoxColumn
            // 
            this.idServicoDataGridViewTextBoxColumn.DataPropertyName = "IdServico";
            this.idServicoDataGridViewTextBoxColumn.HeaderText = "IdServico";
            this.idServicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idServicoDataGridViewTextBoxColumn.Name = "idServicoDataGridViewTextBoxColumn";
            this.idServicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idServicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempoDataGridViewTextBoxColumn
            // 
            this.tempoDataGridViewTextBoxColumn.DataPropertyName = "Tempo";
            this.tempoDataGridViewTextBoxColumn.HeaderText = "Tempo";
            this.tempoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempoDataGridViewTextBoxColumn.Name = "tempoDataGridViewTextBoxColumn";
            this.tempoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempoDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1RemoverServico
            // 
            this.button1RemoverServico.Location = new System.Drawing.Point(1033, 257);
            this.button1RemoverServico.Margin = new System.Windows.Forms.Padding(4);
            this.button1RemoverServico.Name = "button1RemoverServico";
            this.button1RemoverServico.Size = new System.Drawing.Size(127, 25);
            this.button1RemoverServico.TabIndex = 30;
            this.button1RemoverServico.Text = "Remover Serviço";
            this.button1RemoverServico.UseVisualStyleBackColor = true;
            this.button1RemoverServico.Click += new System.EventHandler(this.button1RemoverServico_Click);
            // 
            // groupBoxServico
            // 
            this.groupBoxServico.Controls.Add(this.idTextBox);
            this.groupBoxServico.Controls.Add(label8);
            this.groupBoxServico.Controls.Add(this.precoTextBox);
            this.groupBoxServico.Controls.Add(label);
            this.groupBoxServico.Controls.Add(label9);
            this.groupBoxServico.Controls.Add(this.textBoxQuantidade);
            this.groupBoxServico.Controls.Add(this.button_InserirServicoAgendamento);
            this.groupBoxServico.Controls.Add(label10);
            this.groupBoxServico.Controls.Add(descricaoLabel);
            this.groupBoxServico.Controls.Add(this.textBoxSubtotal);
            this.groupBoxServico.Controls.Add(this.descricaoComboBox);
            this.groupBoxServico.Controls.Add(idLabel);
            this.groupBoxServico.Controls.Add(this.textBoxPrecoAplicado);
            this.groupBoxServico.Enabled = false;
            this.groupBoxServico.Location = new System.Drawing.Point(72, 165);
            this.groupBoxServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxServico.Name = "groupBoxServico";
            this.groupBoxServico.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxServico.Size = new System.Drawing.Size(1088, 78);
            this.groupBoxServico.TabIndex = 31;
            this.groupBoxServico.TabStop = false;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(940, 257);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(85, 25);
            this.buttonNovo.TabIndex = 7;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // FormCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 528);
            this.Controls.Add(idAnimalLabel);
            this.Controls.Add(this.idAnimalTextBox);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(idSituacaoLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(nomeProfissionalLabel1);
            this.Controls.Add(nomeAnimalLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nomeAnimalTextBox);
            this.Controls.Add(this.nomeProfissionalComboBox);
            this.Controls.Add(nomeClienteLabel);
            this.Controls.Add(this.idSituacaoTextBox);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(this.groupBoxServico);
            this.Controls.Add(this.buttonPesquisarAnimal);
            this.Controls.Add(dataAgLabel);
            this.Controls.Add(this.button1RemoverServico);
            this.Controls.Add(this.dataAgDateTimePicker);
            this.Controls.Add(idProfissionalLabel);
            this.Controls.Add(this.idProfissionalTextBox);
            this.Controls.Add(this.agendamentoServicoDataGridView);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(descricaoSituacaoLabel);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.descricaoSituacaoComboBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(horarioLabel);
            this.Controls.Add(this.horarioTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroAgendamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FormCadastroAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicoDataGridView)).EndInit();
            this.groupBoxServico.ResumeLayout(false);
            this.groupBoxServico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_InserirServicoAgendamento;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.TextBox textBoxPrecoAplicado;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonPesquisarAnimal;
        private System.Windows.Forms.TextBox horarioTextBox;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox idAnimalTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox idProfissionalTextBox;
        private System.Windows.Forms.TextBox nomeAnimalTextBox;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox nomeProfissionalComboBox;
        private System.Windows.Forms.ComboBox descricaoSituacaoComboBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.DataGridView agendamentoServicoDataGridView;
        private System.Windows.Forms.DateTimePicker dataAgDateTimePicker;
        private System.Windows.Forms.TextBox idSituacaoTextBox;
        private System.Windows.Forms.Button button1RemoverServico;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.GroupBox groupBoxServico;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.BindingSource agendamentoServicosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorComDescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource agendamentoServicosBindingSource1;
    }
}