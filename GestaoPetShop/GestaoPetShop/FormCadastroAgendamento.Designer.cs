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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label servicoLabel;
            System.Windows.Forms.Label valorComDescontoLabel;
            System.Windows.Forms.Label valorTotalLabel;
            System.Windows.Forms.Label valorUnitarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAgendamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.servicoComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_InserirServicoAgendamento = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.valorComDescontoTextBox = new System.Windows.Forms.TextBox();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.valorUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView_ServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_ServicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView_ServicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            servicoLabel = new System.Windows.Forms.Label();
            valorComDescontoLabel = new System.Windows.Forms.Label();
            valorTotalLabel = new System.Windows.Forms.Label();
            valorUnitarioLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingNavigator)).BeginInit();
            this.dataGridView_ServicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(273, 31);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 3;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // servicoLabel
            // 
            servicoLabel.AutoSize = true;
            servicoLabel.Location = new System.Drawing.Point(93, 31);
            servicoLabel.Name = "servicoLabel";
            servicoLabel.Size = new System.Drawing.Size(46, 13);
            servicoLabel.TabIndex = 5;
            servicoLabel.Text = "Servico:";
            // 
            // valorComDescontoLabel
            // 
            valorComDescontoLabel.AutoSize = true;
            valorComDescontoLabel.Location = new System.Drawing.Point(459, 31);
            valorComDescontoLabel.Name = "valorComDescontoLabel";
            valorComDescontoLabel.Size = new System.Drawing.Size(107, 13);
            valorComDescontoLabel.TabIndex = 7;
            valorComDescontoLabel.Text = "Valor Com Desconto:";
            // 
            // valorTotalLabel
            // 
            valorTotalLabel.AutoSize = true;
            valorTotalLabel.Location = new System.Drawing.Point(577, 31);
            valorTotalLabel.Name = "valorTotalLabel";
            valorTotalLabel.Size = new System.Drawing.Size(61, 13);
            valorTotalLabel.TabIndex = 9;
            valorTotalLabel.Text = "Valor Total:";
            // 
            // valorUnitarioLabel
            // 
            valorUnitarioLabel.AutoSize = true;
            valorUnitarioLabel.Location = new System.Drawing.Point(368, 31);
            valorUnitarioLabel.Name = "valorUnitarioLabel";
            valorUnitarioLabel.Size = new System.Drawing.Size(73, 13);
            valorUnitarioLabel.TabIndex = 11;
            valorUnitarioLabel.Text = "Valor Unitario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(648, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor Total R$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome do Cliente";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(422, 108);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Animal";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(108, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(163, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Situação";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(627, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profissional";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.servicoComboBox);
            this.groupBox2.Controls.Add(this.button_InserirServicoAgendamento);
            this.groupBox2.Controls.Add(idLabel);
            this.groupBox2.Controls.Add(this.idTextBox);
            this.groupBox2.Controls.Add(quantidadeLabel);
            this.groupBox2.Controls.Add(this.quantidadeTextBox);
            this.groupBox2.Controls.Add(servicoLabel);
            this.groupBox2.Controls.Add(valorComDescontoLabel);
            this.groupBox2.Controls.Add(this.valorComDescontoTextBox);
            this.groupBox2.Controls.Add(valorTotalLabel);
            this.groupBox2.Controls.Add(this.valorTotalTextBox);
            this.groupBox2.Controls.Add(valorUnitarioLabel);
            this.groupBox2.Controls.Add(this.valorUnitarioTextBox);
            this.groupBox2.Controls.Add(this.dataGridView_ServicoDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(5, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // servicoComboBox
            // 
            this.servicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataGridView_ServicoBindingSource, "Servico", true));
            this.servicoComboBox.FormattingEnabled = true;
            this.servicoComboBox.Location = new System.Drawing.Point(56, 47);
            this.servicoComboBox.Name = "servicoComboBox";
            this.servicoComboBox.Size = new System.Drawing.Size(214, 21);
            this.servicoComboBox.TabIndex = 15;
            this.servicoComboBox.SelectedIndexChanged += new System.EventHandler(this.servicoComboBox_SelectedIndexChanged);
            // 
            // dataGridView_ServicoBindingSource
            // 
            this.dataGridView_ServicoBindingSource.DataSource = typeof(Models.DataGridView_Servico);
            // 
            // button_InserirServicoAgendamento
            // 
            this.button_InserirServicoAgendamento.Location = new System.Drawing.Point(685, 45);
            this.button_InserirServicoAgendamento.Name = "button_InserirServicoAgendamento";
            this.button_InserirServicoAgendamento.Size = new System.Drawing.Size(75, 23);
            this.button_InserirServicoAgendamento.TabIndex = 13;
            this.button_InserirServicoAgendamento.Text = "Inserir";
            this.button_InserirServicoAgendamento.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataGridView_ServicoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(6, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(44, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataGridView_ServicoBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(276, 47);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(62, 20);
            this.quantidadeTextBox.TabIndex = 4;
            this.quantidadeTextBox.TextChanged += new System.EventHandler(this.quantidadeTextBox_TextChanged);
            // 
            // valorComDescontoTextBox
            // 
            this.valorComDescontoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataGridView_ServicoBindingSource, "ValorComDesconto", true));
            this.valorComDescontoTextBox.Location = new System.Drawing.Point(462, 47);
            this.valorComDescontoTextBox.Name = "valorComDescontoTextBox";
            this.valorComDescontoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorComDescontoTextBox.TabIndex = 8;
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataGridView_ServicoBindingSource, "ValorTotal", true));
            this.valorTotalTextBox.Location = new System.Drawing.Point(577, 47);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTotalTextBox.TabIndex = 10;
            // 
            // valorUnitarioTextBox
            // 
            this.valorUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataGridView_ServicoBindingSource, "ValorUnitario", true));
            this.valorUnitarioTextBox.Location = new System.Drawing.Point(371, 47);
            this.valorUnitarioTextBox.Name = "valorUnitarioTextBox";
            this.valorUnitarioTextBox.Size = new System.Drawing.Size(70, 20);
            this.valorUnitarioTextBox.TabIndex = 12;
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
            this.dataGridView_ServicoDataGridView.Location = new System.Drawing.Point(7, 82);
            this.dataGridView_ServicoDataGridView.Name = "dataGridView_ServicoDataGridView";
            this.dataGridView_ServicoDataGridView.ReadOnly = true;
            this.dataGridView_ServicoDataGridView.RowHeadersVisible = false;
            this.dataGridView_ServicoDataGridView.Size = new System.Drawing.Size(753, 254);
            this.dataGridView_ServicoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
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
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValorUnitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor Unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorComDesconto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor com Desconto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ValorTotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridView_ServicoBindingNavigator
            // 
            this.dataGridView_ServicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataGridView_ServicoBindingNavigator.BindingSource = this.dataGridView_ServicoBindingSource;
            this.dataGridView_ServicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataGridView_ServicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataGridView_ServicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dataGridView_ServicoBindingNavigatorSaveItem});
            this.dataGridView_ServicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ServicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataGridView_ServicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataGridView_ServicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataGridView_ServicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataGridView_ServicoBindingNavigator.Name = "dataGridView_ServicoBindingNavigator";
            this.dataGridView_ServicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataGridView_ServicoBindingNavigator.Size = new System.Drawing.Size(790, 25);
            this.dataGridView_ServicoBindingNavigator.TabIndex = 2;
            this.dataGridView_ServicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView_ServicoBindingNavigatorSaveItem
            // 
            this.dataGridView_ServicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataGridView_ServicoBindingNavigatorSaveItem.Enabled = false;
            this.dataGridView_ServicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataGridView_ServicoBindingNavigatorSaveItem.Image")));
            this.dataGridView_ServicoBindingNavigatorSaveItem.Name = "dataGridView_ServicoBindingNavigatorSaveItem";
            this.dataGridView_ServicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataGridView_ServicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // FormCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 591);
            this.Controls.Add(this.dataGridView_ServicoBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastroAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FormCadastroAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingNavigator)).EndInit();
            this.dataGridView_ServicoBindingNavigator.ResumeLayout(false);
            this.dataGridView_ServicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_InserirServicoAgendamento;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource dataGridView_ServicoBindingSource;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox valorComDescontoTextBox;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.TextBox valorUnitarioTextBox;
        private System.Windows.Forms.DataGridView dataGridView_ServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingNavigator dataGridView_ServicoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dataGridView_ServicoBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox servicoComboBox;
    }
}