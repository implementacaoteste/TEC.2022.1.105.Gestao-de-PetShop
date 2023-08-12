namespace GestaoPetShop
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
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label dataAgLabel;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataAgDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxPrecoAplicado = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.button_InserirServicoAgendamento = new System.Windows.Forms.Button();
            this.dataGridView_ServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEscluirServico = new System.Windows.Forms.Button();
            this.agendamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nomeProfissionalComboBox = new System.Windows.Forms.ComboBox();
            this.descricaoSituacaoComboBox = new System.Windows.Forms.ComboBox();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            dataAgLabel = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(63, 253);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 15;
            descricaoLabel.Text = "Descricao:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(17, 253);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 17;
            idLabel.Text = "Id:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(350, 255);
            label.Name = "label";
            label.Size = new System.Drawing.Size(79, 13);
            label.TabIndex = 19;
            label.Text = "Preço /Unitário";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(449, 253);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(79, 13);
            label8.TabIndex = 23;
            label8.Text = "Preço Aplicado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(290, 253);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(62, 13);
            label9.TabIndex = 24;
            label9.Text = "Quantidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(560, 253);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(46, 13);
            label10.TabIndex = 27;
            label10.Text = "Subtotal";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(709, 31);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(34, 13);
            ativoLabel.TabIndex = 22;
            ativoLabel.Text = "Ativo:";
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(101, 32);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(49, 13);
            dataAgLabel.TabIndex = 24;
            dataAgLabel.Text = "Data Ag:";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(310, 31);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(44, 13);
            horarioLabel.TabIndex = 26;
            horarioLabel.Text = "Horario:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(11, 31);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 28;
            idLabel1.Text = "Id:";
            // 
            // idAnimalLabel
            // 
            idAnimalLabel.AutoSize = true;
            idAnimalLabel.Location = new System.Drawing.Point(9, 83);
            idAnimalLabel.Name = "idAnimalLabel";
            idAnimalLabel.Size = new System.Drawing.Size(53, 13);
            idAnimalLabel.TabIndex = 30;
            idAnimalLabel.Text = "Id Animal:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(421, 83);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 32;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idProfissionalLabel
            // 
            idProfissionalLabel.AutoSize = true;
            idProfissionalLabel.Location = new System.Drawing.Point(4, 126);
            idProfissionalLabel.Name = "idProfissionalLabel";
            idProfissionalLabel.Size = new System.Drawing.Size(75, 13);
            idProfissionalLabel.TabIndex = 34;
            idProfissionalLabel.Text = "Id Profissional:";
            // 
            // nomeAnimalLabel
            // 
            nomeAnimalLabel.AutoSize = true;
            nomeAnimalLabel.Location = new System.Drawing.Point(127, 83);
            nomeAnimalLabel.Name = "nomeAnimalLabel";
            nomeAnimalLabel.Size = new System.Drawing.Size(72, 13);
            nomeAnimalLabel.TabIndex = 38;
            nomeAnimalLabel.Text = "Nome Animal:";
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Location = new System.Drawing.Point(526, 83);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new System.Drawing.Size(73, 13);
            nomeClienteLabel.TabIndex = 40;
            nomeClienteLabel.Text = "Nome Cliente:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(541, 126);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 44;
            totalLabel.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(descricaoSituacaoLabel);
            this.groupBox1.Controls.Add(this.descricaoSituacaoComboBox);
            this.groupBox1.Controls.Add(nomeProfissionalLabel1);
            this.groupBox1.Controls.Add(this.nomeProfissionalComboBox);
            this.groupBox1.Controls.Add(ativoLabel);
            this.groupBox1.Controls.Add(this.ativoCheckBox);
            this.groupBox1.Controls.Add(dataAgLabel);
            this.groupBox1.Controls.Add(this.dataAgDateTimePicker);
            this.groupBox1.Controls.Add(horarioLabel);
            this.groupBox1.Controls.Add(this.horarioTextBox);
            this.groupBox1.Controls.Add(idLabel1);
            this.groupBox1.Controls.Add(this.idTextBox1);
            this.groupBox1.Controls.Add(idAnimalLabel);
            this.groupBox1.Controls.Add(this.idAnimalTextBox);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteTextBox);
            this.groupBox1.Controls.Add(idProfissionalLabel);
            this.groupBox1.Controls.Add(this.idProfissionalTextBox);
            this.groupBox1.Controls.Add(nomeAnimalLabel);
            this.groupBox1.Controls.Add(this.nomeAnimalTextBox);
            this.groupBox1.Controls.Add(nomeClienteLabel);
            this.groupBox1.Controls.Add(this.nomeClienteTextBox);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.buttonPesquisarAnimal);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendamentoBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(763, 26);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(25, 24);
            this.ativoCheckBox.TabIndex = 23;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataAgDateTimePicker
            // 
            this.dataAgDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgDateTimePicker.Location = new System.Drawing.Point(164, 28);
            this.dataAgDateTimePicker.Name = "dataAgDateTimePicker";
            this.dataAgDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.dataAgDateTimePicker.TabIndex = 25;
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Horario", true));
            this.horarioTextBox.Location = new System.Drawing.Point(360, 28);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(102, 20);
            this.horarioTextBox.TabIndex = 27;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(36, 28);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(55, 20);
            this.idTextBox1.TabIndex = 29;
            // 
            // idAnimalTextBox
            // 
            this.idAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.idAnimalTextBox.Location = new System.Drawing.Point(63, 80);
            this.idAnimalTextBox.Name = "idAnimalTextBox";
            this.idAnimalTextBox.Size = new System.Drawing.Size(54, 20);
            this.idAnimalTextBox.TabIndex = 31;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(475, 80);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(33, 20);
            this.idClienteTextBox.TabIndex = 33;
            // 
            // idProfissionalTextBox
            // 
            this.idProfissionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdProfissional", true));
            this.idProfissionalTextBox.Location = new System.Drawing.Point(79, 123);
            this.idProfissionalTextBox.Name = "idProfissionalTextBox";
            this.idProfissionalTextBox.Size = new System.Drawing.Size(64, 20);
            this.idProfissionalTextBox.TabIndex = 35;
            // 
            // nomeAnimalTextBox
            // 
            this.nomeAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "NomeAnimal", true));
            this.nomeAnimalTextBox.Location = new System.Drawing.Point(201, 80);
            this.nomeAnimalTextBox.Name = "nomeAnimalTextBox";
            this.nomeAnimalTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeAnimalTextBox.TabIndex = 39;
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "NomeCliente", true));
            this.nomeClienteTextBox.Location = new System.Drawing.Point(598, 80);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(145, 20);
            this.nomeClienteTextBox.TabIndex = 41;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(584, 123);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(118, 20);
            this.totalTextBox.TabIndex = 45;
            // 
            // buttonPesquisarAnimal
            // 
            this.buttonPesquisarAnimal.Location = new System.Drawing.Point(751, 83);
            this.buttonPesquisarAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPesquisarAnimal.Name = "buttonPesquisarAnimal";
            this.buttonPesquisarAnimal.Size = new System.Drawing.Size(29, 19);
            this.buttonPesquisarAnimal.TabIndex = 22;
            this.buttonPesquisarAnimal.Text = "Pesq";
            this.buttonPesquisarAnimal.UseVisualStyleBackColor = true;
            this.buttonPesquisarAnimal.Click += new System.EventHandler(this.buttonPesquisarAnimal_Click);
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoComboBox.FormattingEnabled = true;
            this.descricaoComboBox.Location = new System.Drawing.Point(65, 270);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(221, 21);
            this.descricaoComboBox.TabIndex = 1;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(558, 270);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(83, 20);
            this.textBoxSubtotal.TabIndex = 5;
            // 
            // textBoxPrecoAplicado
            // 
            this.textBoxPrecoAplicado.Location = new System.Drawing.Point(452, 271);
            this.textBoxPrecoAplicado.Name = "textBoxPrecoAplicado";
            this.textBoxPrecoAplicado.Size = new System.Drawing.Size(80, 20);
            this.textBoxPrecoAplicado.TabIndex = 4;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(293, 271);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(56, 20);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.Text = "1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(3, 270);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(45, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(353, 271);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(79, 20);
            this.precoTextBox.TabIndex = 3;
            // 
            // button_InserirServicoAgendamento
            // 
            this.button_InserirServicoAgendamento.Location = new System.Drawing.Point(712, 267);
            this.button_InserirServicoAgendamento.Name = "button_InserirServicoAgendamento";
            this.button_InserirServicoAgendamento.Size = new System.Drawing.Size(64, 23);
            this.button_InserirServicoAgendamento.TabIndex = 7;
            this.button_InserirServicoAgendamento.Text = "Inserir";
            this.button_InserirServicoAgendamento.UseVisualStyleBackColor = true;
            this.button_InserirServicoAgendamento.Click += new System.EventHandler(this.button_InserirServicoAgendamento_Click);
            // 
            // dataGridView_ServicoDataGridView
            // 
            this.dataGridView_ServicoDataGridView.AllowUserToAddRows = false;
            this.dataGridView_ServicoDataGridView.AllowUserToDeleteRows = false;
            this.dataGridView_ServicoDataGridView.AllowUserToOrderColumns = true;
            this.dataGridView_ServicoDataGridView.AutoGenerateColumns = false;
            this.dataGridView_ServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ServicoDataGridView.DataSource = this.dataGridView_ServicoBindingSource;
            this.dataGridView_ServicoDataGridView.Location = new System.Drawing.Point(-3, 325);
            this.dataGridView_ServicoDataGridView.Name = "dataGridView_ServicoDataGridView";
            this.dataGridView_ServicoDataGridView.ReadOnly = true;
            this.dataGridView_ServicoDataGridView.RowHeadersVisible = false;
            this.dataGridView_ServicoDataGridView.RowHeadersWidth = 51;
            this.dataGridView_ServicoDataGridView.Size = new System.Drawing.Size(779, 175);
            this.dataGridView_ServicoDataGridView.TabIndex = 0;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(648, 267);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(59, 22);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(712, 504);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(56, 19);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEscluirServico
            // 
            this.buttonEscluirServico.Location = new System.Drawing.Point(681, 296);
            this.buttonEscluirServico.Name = "buttonEscluirServico";
            this.buttonEscluirServico.Size = new System.Drawing.Size(95, 23);
            this.buttonEscluirServico.TabIndex = 29;
            this.buttonEscluirServico.Text = "Excluir Serviço";
            this.buttonEscluirServico.UseVisualStyleBackColor = true;
            // 
            // agendamentoBindingSource1
            // 
            this.agendamentoBindingSource1.DataSource = typeof(Models.Agendamento);
            // 
            // nomeProfissionalLabel1
            // 
            nomeProfissionalLabel1.AutoSize = true;
            nomeProfissionalLabel1.Location = new System.Drawing.Point(180, 126);
            nomeProfissionalLabel1.Name = "nomeProfissionalLabel1";
            nomeProfissionalLabel1.Size = new System.Drawing.Size(94, 13);
            nomeProfissionalLabel1.TabIndex = 46;
            nomeProfissionalLabel1.Text = "Nome Profissional:";
            // 
            // nomeProfissionalComboBox
            // 
            this.nomeProfissionalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource1, "NomeProfissional", true));
            this.nomeProfissionalComboBox.FormattingEnabled = true;
            this.nomeProfissionalComboBox.Location = new System.Drawing.Point(280, 123);
            this.nomeProfissionalComboBox.Name = "nomeProfissionalComboBox";
            this.nomeProfissionalComboBox.Size = new System.Drawing.Size(121, 21);
            this.nomeProfissionalComboBox.TabIndex = 47;
            // 
            // descricaoSituacaoLabel
            // 
            descricaoSituacaoLabel.AutoSize = true;
            descricaoSituacaoLabel.Location = new System.Drawing.Point(472, 31);
            descricaoSituacaoLabel.Name = "descricaoSituacaoLabel";
            descricaoSituacaoLabel.Size = new System.Drawing.Size(103, 13);
            descricaoSituacaoLabel.TabIndex = 47;
            descricaoSituacaoLabel.Text = "Descricao Situacao:";
            // 
            // descricaoSituacaoComboBox
            // 
            this.descricaoSituacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource1, "DescricaoSituacao", true));
            this.descricaoSituacaoComboBox.FormattingEnabled = true;
            this.descricaoSituacaoComboBox.Location = new System.Drawing.Point(581, 28);
            this.descricaoSituacaoComboBox.Name = "descricaoSituacaoComboBox";
            this.descricaoSituacaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.descricaoSituacaoComboBox.TabIndex = 48;
            // 
            // FormCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 537);
            this.Controls.Add(this.buttonEscluirServico);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridView_ServicoDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label10);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.textBoxPrecoAplicado);
            this.Controls.Add(this.descricaoComboBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(label9);
            this.Controls.Add(label);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.button_InserirServicoAgendamento);
            this.Controls.Add(label8);
            this.Name = "FormCadastroAgendamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FormCadastroAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_InserirServicoAgendamento;
        private System.Windows.Forms.BindingSource dataGridView_ServicoBindingSource;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.TextBox textBoxPrecoAplicado;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.DataGridView dataGridView_ServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.Button buttonEscluirServico;
        private System.Windows.Forms.Button buttonPesquisarAnimal;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.DateTimePicker dataAgDateTimePicker;
        private System.Windows.Forms.TextBox horarioTextBox;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox idAnimalTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox idProfissionalTextBox;
        private System.Windows.Forms.TextBox nomeAnimalTextBox;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox nomeProfissionalComboBox;
        private System.Windows.Forms.BindingSource agendamentoBindingSource1;
        private System.Windows.Forms.ComboBox descricaoSituacaoComboBox;
    }
}