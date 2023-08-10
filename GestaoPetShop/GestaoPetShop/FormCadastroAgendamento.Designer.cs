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
            System.Windows.Forms.Label idAnimalLabel;
            System.Windows.Forms.Label idProfissionalLabel;
            System.Windows.Forms.Label idSituacaoLabel;
            System.Windows.Forms.Label totalLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxPrecoAplicado = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.button_InserirServicoAgendamento = new System.Windows.Forms.Button();
            this.dataGridView_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_ServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.dataAgTextBox = new System.Windows.Forms.TextBox();
            this.horarioTextBox = new System.Windows.Forms.TextBox();
            this.idAnimalTextBox = new System.Windows.Forms.TextBox();
            this.idProfissionalTextBox = new System.Windows.Forms.TextBox();
            this.idSituacaoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.labelNomedoAnimal = new System.Windows.Forms.Label();
            this.textBoxNomedoAnimal = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNomedoCliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNomedoProfissional = new System.Windows.Forms.Label();
            this.buttonEscluirServico = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            dataAgLabel = new System.Windows.Forms.Label();
            horarioLabel = new System.Windows.Forms.Label();
            idAnimalLabel = new System.Windows.Forms.Label();
            idProfissionalLabel = new System.Windows.Forms.Label();
            idSituacaoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelNomedoProfissional);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelNomedoCliente);
            this.groupBox1.Controls.Add(this.textBoxNomedoAnimal);
            this.groupBox1.Controls.Add(this.labelNomedoAnimal);
            this.groupBox1.Controls.Add(ativoLabel);
            this.groupBox1.Controls.Add(this.ativoCheckBox);
            this.groupBox1.Controls.Add(dataAgLabel);
            this.groupBox1.Controls.Add(this.dataAgTextBox);
            this.groupBox1.Controls.Add(horarioLabel);
            this.groupBox1.Controls.Add(this.horarioTextBox);
            this.groupBox1.Controls.Add(idAnimalLabel);
            this.groupBox1.Controls.Add(this.idAnimalTextBox);
            this.groupBox1.Controls.Add(idProfissionalLabel);
            this.groupBox1.Controls.Add(this.idProfissionalTextBox);
            this.groupBox1.Controls.Add(idSituacaoLabel);
            this.groupBox1.Controls.Add(this.idSituacaoTextBox);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
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
            // dataGridView_ServicoBindingSource
            // 
            this.dataGridView_ServicoBindingSource.DataSource = typeof(Models.AgendamentoServico);
            // 
            // dataGridView_ServicoDataGridView
            // 
            this.dataGridView_ServicoDataGridView.AllowUserToAddRows = false;
            this.dataGridView_ServicoDataGridView.AllowUserToDeleteRows = false;
            this.dataGridView_ServicoDataGridView.AllowUserToOrderColumns = true;
            this.dataGridView_ServicoDataGridView.AutoGenerateColumns = false;
            this.dataGridView_ServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_ServicoDataGridView.DataSource = this.dataGridView_ServicoBindingSource;
            this.dataGridView_ServicoDataGridView.Location = new System.Drawing.Point(5, 331);
            this.dataGridView_ServicoDataGridView.Name = "dataGridView_ServicoDataGridView";
            this.dataGridView_ServicoDataGridView.ReadOnly = true;
            this.dataGridView_ServicoDataGridView.RowHeadersVisible = false;
            this.dataGridView_ServicoDataGridView.RowHeadersWidth = 51;
            this.dataGridView_ServicoDataGridView.Size = new System.Drawing.Size(779, 234);
            this.dataGridView_ServicoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValorUnitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor Unitário";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorComDesconto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor com Desconto";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ValorTotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(648, 269);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(59, 22);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(696, 578);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(56, 19);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(673, 33);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(34, 13);
            ativoLabel.TabIndex = 0;
            ativoLabel.Text = "Ativo:";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendamentoBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(719, 28);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(28, 24);
            this.ativoCheckBox.TabIndex = 1;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(17, 32);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(49, 13);
            dataAgLabel.TabIndex = 2;
            dataAgLabel.Text = "Data Ag:";
            // 
            // dataAgTextBox
            // 
            this.dataAgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgTextBox.Location = new System.Drawing.Point(98, 29);
            this.dataAgTextBox.Name = "dataAgTextBox";
            this.dataAgTextBox.Size = new System.Drawing.Size(104, 20);
            this.dataAgTextBox.TabIndex = 3;
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(226, 32);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(44, 13);
            horarioLabel.TabIndex = 4;
            horarioLabel.Text = "Horario:";
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Horario", true));
            this.horarioTextBox.Location = new System.Drawing.Point(274, 29);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(104, 20);
            this.horarioTextBox.TabIndex = 5;
            // 
            // idAnimalLabel
            // 
            idAnimalLabel.AutoSize = true;
            idAnimalLabel.Location = new System.Drawing.Point(17, 69);
            idAnimalLabel.Name = "idAnimalLabel";
            idAnimalLabel.Size = new System.Drawing.Size(53, 13);
            idAnimalLabel.TabIndex = 8;
            idAnimalLabel.Text = "Id Animal:";
            // 
            // idAnimalTextBox
            // 
            this.idAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.idAnimalTextBox.Location = new System.Drawing.Point(98, 66);
            this.idAnimalTextBox.Name = "idAnimalTextBox";
            this.idAnimalTextBox.Size = new System.Drawing.Size(60, 20);
            this.idAnimalTextBox.TabIndex = 9;
            // 
            // idProfissionalLabel
            // 
            idProfissionalLabel.AutoSize = true;
            idProfissionalLabel.Location = new System.Drawing.Point(22, 110);
            idProfissionalLabel.Name = "idProfissionalLabel";
            idProfissionalLabel.Size = new System.Drawing.Size(75, 13);
            idProfissionalLabel.TabIndex = 10;
            idProfissionalLabel.Text = "Id Profissional:";
            // 
            // idProfissionalTextBox
            // 
            this.idProfissionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdProfissional", true));
            this.idProfissionalTextBox.Location = new System.Drawing.Point(98, 103);
            this.idProfissionalTextBox.Name = "idProfissionalTextBox";
            this.idProfissionalTextBox.Size = new System.Drawing.Size(60, 20);
            this.idProfissionalTextBox.TabIndex = 11;
            // 
            // idSituacaoLabel
            // 
            idSituacaoLabel.AutoSize = true;
            idSituacaoLabel.Location = new System.Drawing.Point(439, 36);
            idSituacaoLabel.Name = "idSituacaoLabel";
            idSituacaoLabel.Size = new System.Drawing.Size(64, 13);
            idSituacaoLabel.TabIndex = 12;
            idSituacaoLabel.Text = "Id Situacao:";
            // 
            // idSituacaoTextBox
            // 
            this.idSituacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdSituacao", true));
            this.idSituacaoTextBox.Location = new System.Drawing.Point(520, 33);
            this.idSituacaoTextBox.Name = "idSituacaoTextBox";
            this.idSituacaoTextBox.Size = new System.Drawing.Size(104, 20);
            this.idSituacaoTextBox.TabIndex = 13;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(567, 133);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 14;
            totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(648, 130);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(104, 20);
            this.totalTextBox.TabIndex = 15;
            // 
            // labelNomedoAnimal
            // 
            this.labelNomedoAnimal.AutoSize = true;
            this.labelNomedoAnimal.Location = new System.Drawing.Point(181, 69);
            this.labelNomedoAnimal.Name = "labelNomedoAnimal";
            this.labelNomedoAnimal.Size = new System.Drawing.Size(84, 13);
            this.labelNomedoAnimal.TabIndex = 16;
            this.labelNomedoAnimal.Text = "Nome do Animal";
            // 
            // textBoxNomedoAnimal
            // 
            this.textBoxNomedoAnimal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.textBoxNomedoAnimal.Location = new System.Drawing.Point(274, 66);
            this.textBoxNomedoAnimal.Name = "textBoxNomedoAnimal";
            this.textBoxNomedoAnimal.Size = new System.Drawing.Size(147, 20);
            this.textBoxNomedoAnimal.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.textBox1.Location = new System.Drawing.Point(520, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 19;
            // 
            // labelNomedoCliente
            // 
            this.labelNomedoCliente.AutoSize = true;
            this.labelNomedoCliente.Location = new System.Drawing.Point(429, 69);
            this.labelNomedoCliente.Name = "labelNomedoCliente";
            this.labelNomedoCliente.Size = new System.Drawing.Size(85, 13);
            this.labelNomedoCliente.TabIndex = 18;
            this.labelNomedoCliente.Text = "Nome do Cliente";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.textBox2.Location = new System.Drawing.Point(274, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 21;
            // 
            // labelNomedoProfissional
            // 
            this.labelNomedoProfissional.AutoSize = true;
            this.labelNomedoProfissional.Location = new System.Drawing.Point(166, 106);
            this.labelNomedoProfissional.Name = "labelNomedoProfissional";
            this.labelNomedoProfissional.Size = new System.Drawing.Size(106, 13);
            this.labelNomedoProfissional.TabIndex = 20;
            this.labelNomedoProfissional.Text = "Nome do Profissional";
            // 
            // buttonEscluirServico
            // 
            this.buttonEscluirServico.Location = new System.Drawing.Point(689, 302);
            this.buttonEscluirServico.Name = "buttonEscluirServico";
            this.buttonEscluirServico.Size = new System.Drawing.Size(95, 23);
            this.buttonEscluirServico.TabIndex = 29;
            this.buttonEscluirServico.Text = "Excluir Serviço";
            this.buttonEscluirServico.UseVisualStyleBackColor = true;
            // 
            // FormCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 609);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FormCadastroAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
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
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.TextBox dataAgTextBox;
        private System.Windows.Forms.TextBox horarioTextBox;
        private System.Windows.Forms.TextBox idAnimalTextBox;
        private System.Windows.Forms.TextBox idProfissionalTextBox;
        private System.Windows.Forms.TextBox idSituacaoTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNomedoProfissional;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNomedoCliente;
        private System.Windows.Forms.TextBox textBoxNomedoAnimal;
        private System.Windows.Forms.Label labelNomedoAnimal;
        private System.Windows.Forms.Button buttonEscluirServico;
    }
}