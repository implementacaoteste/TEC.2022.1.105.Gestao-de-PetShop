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
            this.textBoxNomeProfissional = new System.Windows.Forms.TextBox();
            this.labelNomedoProfissional = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelNomedoCliente = new System.Windows.Forms.Label();
            this.textBoxNomedoAnimal = new System.Windows.Forms.TextBox();
            this.labelNomedoAnimal = new System.Windows.Forms.Label();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.dataAgTextBox = new System.Windows.Forms.TextBox();
            this.horarioTextBox = new System.Windows.Forms.TextBox();
            this.idAnimalTextBox = new System.Windows.Forms.TextBox();
            this.idProfissionalTextBox = new System.Windows.Forms.TextBox();
            this.idSituacaoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxPrecoAplicado = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.button_InserirServicoAgendamento = new System.Windows.Forms.Button();
            this.dataGridView_ServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEscluirServico = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPesquisarAnimal = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(84, 311);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 15;
            descricaoLabel.Text = "Descricao:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 311);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 17;
            idLabel.Text = "Id:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(467, 314);
            label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(96, 16);
            label.TabIndex = 19;
            label.Text = "Preço /Unitário";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(599, 311);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 16);
            label8.TabIndex = 23;
            label8.Text = "Preço Aplicado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(387, 311);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 16);
            label9.TabIndex = 24;
            label9.Text = "Quantidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(747, 311);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 16);
            label10.TabIndex = 27;
            label10.Text = "Subtotal";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(897, 41);
            ativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(40, 16);
            ativoLabel.TabIndex = 0;
            ativoLabel.Text = "Ativo:";
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(23, 39);
            dataAgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(59, 16);
            dataAgLabel.TabIndex = 2;
            dataAgLabel.Text = "Data Ag:";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(301, 39);
            horarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(55, 16);
            horarioLabel.TabIndex = 4;
            horarioLabel.Text = "Horario:";
            // 
            // idAnimalLabel
            // 
            idAnimalLabel.AutoSize = true;
            idAnimalLabel.Location = new System.Drawing.Point(23, 85);
            idAnimalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAnimalLabel.Name = "idAnimalLabel";
            idAnimalLabel.Size = new System.Drawing.Size(65, 16);
            idAnimalLabel.TabIndex = 8;
            idAnimalLabel.Text = "Id Animal:";
            // 
            // idProfissionalLabel
            // 
            idProfissionalLabel.AutoSize = true;
            idProfissionalLabel.Location = new System.Drawing.Point(29, 135);
            idProfissionalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idProfissionalLabel.Name = "idProfissionalLabel";
            idProfissionalLabel.Size = new System.Drawing.Size(94, 16);
            idProfissionalLabel.TabIndex = 10;
            idProfissionalLabel.Text = "Id Profissional:";
            // 
            // idSituacaoLabel
            // 
            idSituacaoLabel.AutoSize = true;
            idSituacaoLabel.Location = new System.Drawing.Point(620, 44);
            idSituacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idSituacaoLabel.Name = "idSituacaoLabel";
            idSituacaoLabel.Size = new System.Drawing.Size(77, 16);
            idSituacaoLabel.TabIndex = 12;
            idSituacaoLabel.Text = "Id Situacao:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(756, 164);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(41, 16);
            totalLabel.TabIndex = 14;
            totalLabel.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPesquisarAnimal);
            this.groupBox1.Controls.Add(this.textBoxNomeProfissional);
            this.groupBox1.Controls.Add(this.labelNomedoProfissional);
            this.groupBox1.Controls.Add(this.textBoxNomeCliente);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1041, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxNomeProfissional
            // 
            this.textBoxNomeProfissional.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.textBoxNomeProfissional.Location = new System.Drawing.Point(365, 127);
            this.textBoxNomeProfissional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomeProfissional.Name = "textBoxNomeProfissional";
            this.textBoxNomeProfissional.Size = new System.Drawing.Size(195, 22);
            this.textBoxNomeProfissional.TabIndex = 21;
            // 
            // labelNomedoProfissional
            // 
            this.labelNomedoProfissional.AutoSize = true;
            this.labelNomedoProfissional.Location = new System.Drawing.Point(221, 130);
            this.labelNomedoProfissional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomedoProfissional.Name = "labelNomedoProfissional";
            this.labelNomedoProfissional.Size = new System.Drawing.Size(136, 16);
            this.labelNomedoProfissional.TabIndex = 20;
            this.labelNomedoProfissional.Text = "Nome do Profissional";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.textBoxNomeCliente.Location = new System.Drawing.Point(728, 81);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(195, 22);
            this.textBoxNomeCliente.TabIndex = 19;
            // 
            // labelNomedoCliente
            // 
            this.labelNomedoCliente.AutoSize = true;
            this.labelNomedoCliente.Location = new System.Drawing.Point(607, 85);
            this.labelNomedoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomedoCliente.Name = "labelNomedoCliente";
            this.labelNomedoCliente.Size = new System.Drawing.Size(107, 16);
            this.labelNomedoCliente.TabIndex = 18;
            this.labelNomedoCliente.Text = "Nome do Cliente";
            // 
            // textBoxNomedoAnimal
            // 
            this.textBoxNomedoAnimal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.textBoxNomedoAnimal.Location = new System.Drawing.Point(369, 81);
            this.textBoxNomedoAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomedoAnimal.Name = "textBoxNomedoAnimal";
            this.textBoxNomedoAnimal.Size = new System.Drawing.Size(195, 22);
            this.textBoxNomedoAnimal.TabIndex = 17;
            // 
            // labelNomedoAnimal
            // 
            this.labelNomedoAnimal.AutoSize = true;
            this.labelNomedoAnimal.Location = new System.Drawing.Point(245, 85);
            this.labelNomedoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomedoAnimal.Name = "labelNomedoAnimal";
            this.labelNomedoAnimal.Size = new System.Drawing.Size(107, 16);
            this.labelNomedoAnimal.TabIndex = 16;
            this.labelNomedoAnimal.Text = "Nome do Animal";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendamentoBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(959, 34);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(37, 30);
            this.ativoCheckBox.TabIndex = 1;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataAgTextBox
            // 
            this.dataAgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgTextBox.Location = new System.Drawing.Point(131, 36);
            this.dataAgTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataAgTextBox.Name = "dataAgTextBox";
            this.dataAgTextBox.Size = new System.Drawing.Size(137, 22);
            this.dataAgTextBox.TabIndex = 3;
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Horario", true));
            this.horarioTextBox.Location = new System.Drawing.Point(365, 36);
            this.horarioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(137, 22);
            this.horarioTextBox.TabIndex = 5;
            // 
            // idAnimalTextBox
            // 
            this.idAnimalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdAnimal", true));
            this.idAnimalTextBox.Location = new System.Drawing.Point(131, 81);
            this.idAnimalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idAnimalTextBox.Name = "idAnimalTextBox";
            this.idAnimalTextBox.Size = new System.Drawing.Size(79, 22);
            this.idAnimalTextBox.TabIndex = 9;
            // 
            // idProfissionalTextBox
            // 
            this.idProfissionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdProfissional", true));
            this.idProfissionalTextBox.Location = new System.Drawing.Point(131, 127);
            this.idProfissionalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idProfissionalTextBox.Name = "idProfissionalTextBox";
            this.idProfissionalTextBox.Size = new System.Drawing.Size(79, 22);
            this.idProfissionalTextBox.TabIndex = 11;
            // 
            // idSituacaoTextBox
            // 
            this.idSituacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdSituacao", true));
            this.idSituacaoTextBox.Location = new System.Drawing.Point(728, 41);
            this.idSituacaoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idSituacaoTextBox.Name = "idSituacaoTextBox";
            this.idSituacaoTextBox.Size = new System.Drawing.Size(137, 22);
            this.idSituacaoTextBox.TabIndex = 13;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(864, 160);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(137, 22);
            this.totalTextBox.TabIndex = 15;
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoComboBox.FormattingEnabled = true;
            this.descricaoComboBox.Location = new System.Drawing.Point(87, 332);
            this.descricaoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(293, 24);
            this.descricaoComboBox.TabIndex = 1;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(744, 332);
            this.textBoxSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(109, 22);
            this.textBoxSubtotal.TabIndex = 5;
            // 
            // textBoxPrecoAplicado
            // 
            this.textBoxPrecoAplicado.Location = new System.Drawing.Point(603, 334);
            this.textBoxPrecoAplicado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrecoAplicado.Name = "textBoxPrecoAplicado";
            this.textBoxPrecoAplicado.Size = new System.Drawing.Size(105, 22);
            this.textBoxPrecoAplicado.TabIndex = 4;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(391, 334);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(73, 22);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.Text = "1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(4, 332);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(59, 22);
            this.idTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(471, 334);
            this.precoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(104, 22);
            this.precoTextBox.TabIndex = 3;
            // 
            // button_InserirServicoAgendamento
            // 
            this.button_InserirServicoAgendamento.Location = new System.Drawing.Point(949, 329);
            this.button_InserirServicoAgendamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_InserirServicoAgendamento.Name = "button_InserirServicoAgendamento";
            this.button_InserirServicoAgendamento.Size = new System.Drawing.Size(85, 28);
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
            this.dataGridView_ServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_ServicoDataGridView.DataSource = this.dataGridView_ServicoBindingSource;
            this.dataGridView_ServicoDataGridView.Location = new System.Drawing.Point(7, 407);
            this.dataGridView_ServicoDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_ServicoDataGridView.Name = "dataGridView_ServicoDataGridView";
            this.dataGridView_ServicoDataGridView.ReadOnly = true;
            this.dataGridView_ServicoDataGridView.RowHeadersVisible = false;
            this.dataGridView_ServicoDataGridView.RowHeadersWidth = 51;
            this.dataGridView_ServicoDataGridView.Size = new System.Drawing.Size(1039, 288);
            this.dataGridView_ServicoDataGridView.TabIndex = 0;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(864, 331);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(79, 27);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(928, 711);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEscluirServico
            // 
            this.buttonEscluirServico.Location = new System.Drawing.Point(919, 372);
            this.buttonEscluirServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEscluirServico.Name = "buttonEscluirServico";
            this.buttonEscluirServico.Size = new System.Drawing.Size(127, 28);
            this.buttonEscluirServico.TabIndex = 29;
            this.buttonEscluirServico.Text = "Excluir Serviço";
            this.buttonEscluirServico.UseVisualStyleBackColor = true;
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
            // dataGridView_ServicoBindingSource
            // 
            this.dataGridView_ServicoBindingSource.DataSource = typeof(Models.AgendamentoServico);
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // buttonPesquisarAnimal
            // 
            this.buttonPesquisarAnimal.Location = new System.Drawing.Point(952, 82);
            this.buttonPesquisarAnimal.Name = "buttonPesquisarAnimal";
            this.buttonPesquisarAnimal.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarAnimal.TabIndex = 22;
            this.buttonPesquisarAnimal.Text = "Pesq";
            this.buttonPesquisarAnimal.UseVisualStyleBackColor = true;
            // 
            // FormCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 750);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCadastroAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FormCadastroAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxNomeProfissional;
        private System.Windows.Forms.Label labelNomedoProfissional;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelNomedoCliente;
        private System.Windows.Forms.TextBox textBoxNomedoAnimal;
        private System.Windows.Forms.Label labelNomedoAnimal;
        private System.Windows.Forms.Button buttonEscluirServico;
        private System.Windows.Forms.Button buttonPesquisarAnimal;
    }
}