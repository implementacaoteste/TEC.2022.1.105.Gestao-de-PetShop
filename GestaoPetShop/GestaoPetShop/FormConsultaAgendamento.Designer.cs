namespace GestaoPetShop
{
    partial class FormConsultaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaAgendamento));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SelecionarTipoBusca = new System.Windows.Forms.ComboBox();
            this.textBox_BuscarAgendamento = new System.Windows.Forms.TextBox();
            this.button_BuscarAgendamentos = new System.Windows.Forms.Button();
            this.button_InserirAgendamentos = new System.Windows.Forms.Button();
            this.button_AlterarAgendamentos = new System.Windows.Forms.Button();
            this.button_ExcluirAgendamento = new System.Windows.Forms.Button();
            this.textBox_BuscarData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AbrirCalendario = new System.Windows.Forms.Button();
            this.monthCalendar_Agendamento = new System.Windows.Forms.MonthCalendar();
            this.button_SelecionarData = new System.Windows.Forms.Button();
            this.dataGridView1_FormsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoServicosDataGridView = new System.Windows.Forms.DataGridView();
            this.IdServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFecharCalendario = new System.Windows.Forms.Button();
            this.comboBox_SelecionarSituacaoBusca = new System.Windows.Forms.ComboBox();
            this.comboBoxSelecionarAtivoBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta de Agendamentos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_SelecionarTipoBusca
            // 
            this.comboBox_SelecionarTipoBusca.FormattingEnabled = true;
            this.comboBox_SelecionarTipoBusca.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nome Profisisonal",
            "Nome Cliente",
            "Dia/Mês/Ano",
            "Mês/Ano",
            "Ano",
            "Serviço Dia/Mês/Ano",
            "Serviço Ano",
            "Serviço Mês/Ano",
            "Serviço",
            "Profissional Dia/Mês/Ano",
            "Profissional Mês/Ano",
            "Profissional Ano"});
            this.comboBox_SelecionarTipoBusca.Location = new System.Drawing.Point(29, 168);
            this.comboBox_SelecionarTipoBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_SelecionarTipoBusca.Name = "comboBox_SelecionarTipoBusca";
            this.comboBox_SelecionarTipoBusca.Size = new System.Drawing.Size(216, 24);
            this.comboBox_SelecionarTipoBusca.TabIndex = 8;
            this.comboBox_SelecionarTipoBusca.Text = "Buscar por";
            // 
            // textBox_BuscarAgendamento
            // 
            this.textBox_BuscarAgendamento.Location = new System.Drawing.Point(29, 319);
            this.textBox_BuscarAgendamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_BuscarAgendamento.Name = "textBox_BuscarAgendamento";
            this.textBox_BuscarAgendamento.Size = new System.Drawing.Size(216, 22);
            this.textBox_BuscarAgendamento.TabIndex = 9;
            // 
            // button_BuscarAgendamentos
            // 
            this.button_BuscarAgendamentos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_BuscarAgendamentos.FlatAppearance.BorderSize = 0;
            this.button_BuscarAgendamentos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuscarAgendamentos.ImageKey = "(none)";
            this.button_BuscarAgendamentos.Location = new System.Drawing.Point(123, 109);
            this.button_BuscarAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BuscarAgendamentos.Name = "button_BuscarAgendamentos";
            this.button_BuscarAgendamentos.Size = new System.Drawing.Size(99, 30);
            this.button_BuscarAgendamentos.TabIndex = 10;
            this.button_BuscarAgendamentos.Text = "Buscar";
            this.button_BuscarAgendamentos.UseVisualStyleBackColor = false;
            this.button_BuscarAgendamentos.Click += new System.EventHandler(this.button_BuscarAgendamentos_Click);
            // 
            // button_InserirAgendamentos
            // 
            this.button_InserirAgendamentos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_InserirAgendamentos.FlatAppearance.BorderSize = 0;
            this.button_InserirAgendamentos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InserirAgendamentos.ImageKey = "(none)";
            this.button_InserirAgendamentos.Location = new System.Drawing.Point(264, 109);
            this.button_InserirAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_InserirAgendamentos.Name = "button_InserirAgendamentos";
            this.button_InserirAgendamentos.Size = new System.Drawing.Size(99, 30);
            this.button_InserirAgendamentos.TabIndex = 11;
            this.button_InserirAgendamentos.Text = "Inserir";
            this.button_InserirAgendamentos.UseVisualStyleBackColor = false;
            this.button_InserirAgendamentos.Click += new System.EventHandler(this.button_InserirAgendamentos_Click);
            // 
            // button_AlterarAgendamentos
            // 
            this.button_AlterarAgendamentos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_AlterarAgendamentos.FlatAppearance.BorderSize = 0;
            this.button_AlterarAgendamentos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AlterarAgendamentos.ImageKey = "(none)";
            this.button_AlterarAgendamentos.Location = new System.Drawing.Point(406, 109);
            this.button_AlterarAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AlterarAgendamentos.Name = "button_AlterarAgendamentos";
            this.button_AlterarAgendamentos.Size = new System.Drawing.Size(99, 30);
            this.button_AlterarAgendamentos.TabIndex = 12;
            this.button_AlterarAgendamentos.Text = "Alterar";
            this.button_AlterarAgendamentos.UseVisualStyleBackColor = false;
            this.button_AlterarAgendamentos.Click += new System.EventHandler(this.button_AlterarAgendamentos_Click);
            // 
            // button_ExcluirAgendamento
            // 
            this.button_ExcluirAgendamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_ExcluirAgendamento.FlatAppearance.BorderSize = 0;
            this.button_ExcluirAgendamento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExcluirAgendamento.ImageKey = "(none)";
            this.button_ExcluirAgendamento.Location = new System.Drawing.Point(548, 109);
            this.button_ExcluirAgendamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ExcluirAgendamento.Name = "button_ExcluirAgendamento";
            this.button_ExcluirAgendamento.Size = new System.Drawing.Size(99, 30);
            this.button_ExcluirAgendamento.TabIndex = 13;
            this.button_ExcluirAgendamento.Text = "Excluir";
            this.button_ExcluirAgendamento.UseVisualStyleBackColor = false;
            this.button_ExcluirAgendamento.Click += new System.EventHandler(this.button_ExcluirAgendamento_Click);
            // 
            // textBox_BuscarData
            // 
            this.textBox_BuscarData.Location = new System.Drawing.Point(302, 262);
            this.textBox_BuscarData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_BuscarData.Name = "textBox_BuscarData";
            this.textBox_BuscarData.Size = new System.Drawing.Size(104, 22);
            this.textBox_BuscarData.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            // 
            // button_AbrirCalendario
            // 
            this.button_AbrirCalendario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_AbrirCalendario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AbrirCalendario.ForeColor = System.Drawing.Color.Black;
            this.button_AbrirCalendario.Location = new System.Drawing.Point(264, 219);
            this.button_AbrirCalendario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AbrirCalendario.Name = "button_AbrirCalendario";
            this.button_AbrirCalendario.Size = new System.Drawing.Size(142, 32);
            this.button_AbrirCalendario.TabIndex = 16;
            this.button_AbrirCalendario.Text = "Calendário";
            this.button_AbrirCalendario.UseVisualStyleBackColor = false;
            this.button_AbrirCalendario.Click += new System.EventHandler(this.button_AbrirCalendario_Click);
            // 
            // monthCalendar_Agendamento
            // 
            this.monthCalendar_Agendamento.Location = new System.Drawing.Point(544, 150);
            this.monthCalendar_Agendamento.Name = "monthCalendar_Agendamento";
            this.monthCalendar_Agendamento.TabIndex = 17;
            this.monthCalendar_Agendamento.Visible = false;
            // 
            // button_SelecionarData
            // 
            this.button_SelecionarData.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_SelecionarData.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelecionarData.Location = new System.Drawing.Point(433, 220);
            this.button_SelecionarData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SelecionarData.Name = "button_SelecionarData";
            this.button_SelecionarData.Size = new System.Drawing.Size(99, 31);
            this.button_SelecionarData.TabIndex = 18;
            this.button_SelecionarData.Text = "Selecionar";
            this.button_SelecionarData.UseVisualStyleBackColor = false;
            this.button_SelecionarData.Visible = false;
            this.button_SelecionarData.Click += new System.EventHandler(this.button_SelecionarData_Click);
            // 
            // agendamentoDataGridView
            // 
            this.agendamentoDataGridView.AllowUserToAddRows = false;
            this.agendamentoDataGridView.AllowUserToDeleteRows = false;
            this.agendamentoDataGridView.AllowUserToOrderColumns = true;
            this.agendamentoDataGridView.AllowUserToResizeColumns = false;
            this.agendamentoDataGridView.AllowUserToResizeRows = false;
            this.agendamentoDataGridView.AutoGenerateColumns = false;
            this.agendamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.NomeAnimal,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewCheckBoxColumn2});
            this.agendamentoDataGridView.DataSource = this.agendamentoBindingSource;
            this.agendamentoDataGridView.Location = new System.Drawing.Point(15, 370);
            this.agendamentoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.agendamentoDataGridView.Name = "agendamentoDataGridView";
            this.agendamentoDataGridView.ReadOnly = true;
            this.agendamentoDataGridView.RowHeadersVisible = false;
            this.agendamentoDataGridView.RowHeadersWidth = 51;
            this.agendamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agendamentoDataGridView.Size = new System.Drawing.Size(411, 220);
            this.agendamentoDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 40;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "DataAg";
            this.dataGridViewTextBoxColumn20.HeaderText = "Data";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 80;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Horario";
            this.dataGridViewTextBoxColumn21.HeaderText = "Horário";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 60;
            // 
            // NomeAnimal
            // 
            this.NomeAnimal.DataPropertyName = "NomeAnimal";
            this.NomeAnimal.HeaderText = "Animal";
            this.NomeAnimal.MinimumWidth = 6;
            this.NomeAnimal.Name = "NomeAnimal";
            this.NomeAnimal.ReadOnly = true;
            this.NomeAnimal.Width = 120;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn24.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "NomeProfissional";
            this.dataGridViewTextBoxColumn17.HeaderText = "Profissional";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn22.HeaderText = "Total";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 60;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DescricaoSituacao";
            this.dataGridViewTextBoxColumn19.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 40;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // agendamentoServicosBindingSource
            // 
            this.agendamentoServicosBindingSource.DataMember = "AgendamentoServicos";
            this.agendamentoServicosBindingSource.DataSource = this.agendamentoBindingSource;
            // 
            // agendamentoServicosDataGridView
            // 
            this.agendamentoServicosDataGridView.AllowUserToAddRows = false;
            this.agendamentoServicosDataGridView.AllowUserToDeleteRows = false;
            this.agendamentoServicosDataGridView.AllowUserToOrderColumns = true;
            this.agendamentoServicosDataGridView.AllowUserToResizeColumns = false;
            this.agendamentoServicosDataGridView.AllowUserToResizeRows = false;
            this.agendamentoServicosDataGridView.AutoGenerateColumns = false;
            this.agendamentoServicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendamentoServicosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdServico,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn27});
            this.agendamentoServicosDataGridView.DataSource = this.agendamentoServicosBindingSource;
            this.agendamentoServicosDataGridView.Location = new System.Drawing.Point(434, 370);
            this.agendamentoServicosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.agendamentoServicosDataGridView.Name = "agendamentoServicosDataGridView";
            this.agendamentoServicosDataGridView.ReadOnly = true;
            this.agendamentoServicosDataGridView.RowHeadersVisible = false;
            this.agendamentoServicosDataGridView.RowHeadersWidth = 51;
            this.agendamentoServicosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agendamentoServicosDataGridView.Size = new System.Drawing.Size(415, 220);
            this.agendamentoServicosDataGridView.TabIndex = 28;
            // 
            // IdServico
            // 
            this.IdServico.DataPropertyName = "IdServico";
            this.IdServico.HeaderText = "Id";
            this.IdServico.MinimumWidth = 6;
            this.IdServico.Name = "IdServico";
            this.IdServico.ReadOnly = true;
            this.IdServico.Width = 40;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn15.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn16.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ValorUnitario";
            this.dataGridViewTextBoxColumn18.HeaderText = "Valor Uni($)";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Tempo";
            this.dataGridViewTextBoxColumn27.HeaderText = "Tempo";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // buttonFecharCalendario
            // 
            this.buttonFecharCalendario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonFecharCalendario.Location = new System.Drawing.Point(467, 257);
            this.buttonFecharCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFecharCalendario.Name = "buttonFecharCalendario";
            this.buttonFecharCalendario.Size = new System.Drawing.Size(39, 28);
            this.buttonFecharCalendario.TabIndex = 29;
            this.buttonFecharCalendario.Text = "X";
            this.buttonFecharCalendario.UseVisualStyleBackColor = false;
            this.buttonFecharCalendario.Visible = false;
            this.buttonFecharCalendario.Click += new System.EventHandler(this.buttonFecharCalendario_Click);
            // 
            // comboBox_SelecionarSituacaoBusca
            // 
            this.comboBox_SelecionarSituacaoBusca.FormattingEnabled = true;
            this.comboBox_SelecionarSituacaoBusca.Items.AddRange(new object[] {
            "Todos",
            "Agendado",
            "Em andamento",
            "Finalizado"});
            this.comboBox_SelecionarSituacaoBusca.Location = new System.Drawing.Point(29, 220);
            this.comboBox_SelecionarSituacaoBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_SelecionarSituacaoBusca.Name = "comboBox_SelecionarSituacaoBusca";
            this.comboBox_SelecionarSituacaoBusca.Size = new System.Drawing.Size(216, 24);
            this.comboBox_SelecionarSituacaoBusca.TabIndex = 30;
            this.comboBox_SelecionarSituacaoBusca.Text = "Situação";
            // 
            // comboBoxSelecionarAtivoBuscar
            // 
            this.comboBoxSelecionarAtivoBuscar.FormattingEnabled = true;
            this.comboBoxSelecionarAtivoBuscar.Items.AddRange(new object[] {
            "Todos",
            "Ativo",
            "Inativo"});
            this.comboBoxSelecionarAtivoBuscar.Location = new System.Drawing.Point(29, 266);
            this.comboBoxSelecionarAtivoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSelecionarAtivoBuscar.Name = "comboBoxSelecionarAtivoBuscar";
            this.comboBoxSelecionarAtivoBuscar.Size = new System.Drawing.Size(216, 24);
            this.comboBoxSelecionarAtivoBuscar.TabIndex = 31;
            // 
            // FormConsultaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 614);
            this.Controls.Add(this.comboBoxSelecionarAtivoBuscar);
            this.Controls.Add(this.comboBox_SelecionarSituacaoBusca);
            this.Controls.Add(this.buttonFecharCalendario);
            this.Controls.Add(this.agendamentoServicosDataGridView);
            this.Controls.Add(this.agendamentoDataGridView);
            this.Controls.Add(this.button_SelecionarData);
            this.Controls.Add(this.monthCalendar_Agendamento);
            this.Controls.Add(this.button_AbrirCalendario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BuscarData);
            this.Controls.Add(this.button_InserirAgendamentos);
            this.Controls.Add(this.textBox_BuscarAgendamento);
            this.Controls.Add(this.comboBox_SelecionarTipoBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_BuscarAgendamentos);
            this.Controls.Add(this.button_AlterarAgendamentos);
            this.Controls.Add(this.button_ExcluirAgendamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(878, 661);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(878, 661);
            this.Name = "FormConsultaAgendamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoServicosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SelecionarTipoBusca;
        private System.Windows.Forms.TextBox textBox_BuscarAgendamento;
        private System.Windows.Forms.Button button_BuscarAgendamentos;
        private System.Windows.Forms.Button button_InserirAgendamentos;
        private System.Windows.Forms.Button button_AlterarAgendamentos;
        private System.Windows.Forms.Button button_ExcluirAgendamento;
        private System.Windows.Forms.TextBox textBox_BuscarData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AbrirCalendario;
        private System.Windows.Forms.MonthCalendar monthCalendar_Agendamento;
        private System.Windows.Forms.Button button_SelecionarData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.BindingSource dataGridView1_FormsPrincipalBindingSource;
        private System.Windows.Forms.DataGridView agendamentoDataGridView;
        private System.Windows.Forms.BindingSource agendamentoServicosBindingSource;
        private System.Windows.Forms.DataGridView agendamentoServicosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.Button buttonFecharCalendario;
        private System.Windows.Forms.ComboBox comboBox_SelecionarSituacaoBusca;
        private System.Windows.Forms.ComboBox comboBoxSelecionarAtivoBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
    }
}