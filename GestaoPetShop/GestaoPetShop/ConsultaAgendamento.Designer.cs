namespace GestaoPetShop
{
    partial class ConsultaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAgendamento));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SelecionarTipoBusca = new System.Windows.Forms.ComboBox();
            this.textBox_BuscarAgendamento = new System.Windows.Forms.TextBox();
            this.button_BuscarAgendamentos = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_InserirAgendamentos = new System.Windows.Forms.Button();
            this.button_AlterarAgendamentos = new System.Windows.Forms.Button();
            this.button_ExcluirAgendamento = new System.Windows.Forms.Button();
            this.textBox_BuscarData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AbrirCalendario = new System.Windows.Forms.Button();
            this.monthCalendar_Agendamento = new System.Windows.Forms.MonthCalendar();
            this.button_SelecionarData = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1_FormsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1_FormsPrincipalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta de Agendamentos";
            // 
            // comboBox_SelecionarTipoBusca
            // 
            this.comboBox_SelecionarTipoBusca.FormattingEnabled = true;
            this.comboBox_SelecionarTipoBusca.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nome Animal",
            "Nome Cliente",
            "Dia/Mês/Ano",
            "Mês/Ano",
            "Ano",
            "Profissional"});
            this.comboBox_SelecionarTipoBusca.Location = new System.Drawing.Point(16, 230);
            this.comboBox_SelecionarTipoBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_SelecionarTipoBusca.Name = "comboBox_SelecionarTipoBusca";
            this.comboBox_SelecionarTipoBusca.Size = new System.Drawing.Size(121, 24);
            this.comboBox_SelecionarTipoBusca.TabIndex = 8;
            this.comboBox_SelecionarTipoBusca.Text = "Buscar por";
            // 
            // textBox_BuscarAgendamento
            // 
            this.textBox_BuscarAgendamento.Location = new System.Drawing.Point(143, 230);
            this.textBox_BuscarAgendamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_BuscarAgendamento.Name = "textBox_BuscarAgendamento";
            this.textBox_BuscarAgendamento.Size = new System.Drawing.Size(288, 22);
            this.textBox_BuscarAgendamento.TabIndex = 9;
            // 
            // button_BuscarAgendamentos
            // 
            this.button_BuscarAgendamentos.BackColor = System.Drawing.Color.Transparent;
            this.button_BuscarAgendamentos.FlatAppearance.BorderSize = 0;
            this.button_BuscarAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BuscarAgendamentos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuscarAgendamentos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_BuscarAgendamentos.ImageKey = "buscar-removebg-preview.png";
            this.button_BuscarAgendamentos.ImageList = this.imageList1;
            this.button_BuscarAgendamentos.Location = new System.Drawing.Point(211, 112);
            this.button_BuscarAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BuscarAgendamentos.Name = "button_BuscarAgendamentos";
            this.button_BuscarAgendamentos.Size = new System.Drawing.Size(75, 62);
            this.button_BuscarAgendamentos.TabIndex = 10;
            this.button_BuscarAgendamentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_BuscarAgendamentos.UseVisualStyleBackColor = false;
            this.button_BuscarAgendamentos.Click += new System.EventHandler(this.button_BuscarAgendamentos_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "add-removebg-preview.png");
            this.imageList1.Images.SetKeyName(2, "editar-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "excluir-removebg-preview.png");
            // 
            // button_InserirAgendamentos
            // 
            this.button_InserirAgendamentos.BackColor = System.Drawing.Color.Transparent;
            this.button_InserirAgendamentos.FlatAppearance.BorderSize = 0;
            this.button_InserirAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InserirAgendamentos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InserirAgendamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_InserirAgendamentos.ImageKey = "add-removebg-preview.png";
            this.button_InserirAgendamentos.ImageList = this.imageList1;
            this.button_InserirAgendamentos.Location = new System.Drawing.Point(355, 106);
            this.button_InserirAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_InserirAgendamentos.Name = "button_InserirAgendamentos";
            this.button_InserirAgendamentos.Size = new System.Drawing.Size(77, 62);
            this.button_InserirAgendamentos.TabIndex = 11;
            this.button_InserirAgendamentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_InserirAgendamentos.UseVisualStyleBackColor = false;
            this.button_InserirAgendamentos.Click += new System.EventHandler(this.button_InserirAgendamentos_Click);
            // 
            // button_AlterarAgendamentos
            // 
            this.button_AlterarAgendamentos.BackColor = System.Drawing.Color.Transparent;
            this.button_AlterarAgendamentos.FlatAppearance.BorderSize = 0;
            this.button_AlterarAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AlterarAgendamentos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AlterarAgendamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AlterarAgendamentos.ImageKey = "editar-removebg-preview.png";
            this.button_AlterarAgendamentos.ImageList = this.imageList1;
            this.button_AlterarAgendamentos.Location = new System.Drawing.Point(507, 100);
            this.button_AlterarAgendamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AlterarAgendamentos.Name = "button_AlterarAgendamentos";
            this.button_AlterarAgendamentos.Size = new System.Drawing.Size(67, 62);
            this.button_AlterarAgendamentos.TabIndex = 12;
            this.button_AlterarAgendamentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AlterarAgendamentos.UseVisualStyleBackColor = false;
            this.button_AlterarAgendamentos.Click += new System.EventHandler(this.button_AlterarAgendamentos_Click);
            // 
            // button_ExcluirAgendamento
            // 
            this.button_ExcluirAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.button_ExcluirAgendamento.FlatAppearance.BorderSize = 0;
            this.button_ExcluirAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExcluirAgendamento.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExcluirAgendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ExcluirAgendamento.ImageKey = "excluir-removebg-preview.png";
            this.button_ExcluirAgendamento.ImageList = this.imageList1;
            this.button_ExcluirAgendamento.Location = new System.Drawing.Point(657, 100);
            this.button_ExcluirAgendamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ExcluirAgendamento.Name = "button_ExcluirAgendamento";
            this.button_ExcluirAgendamento.Size = new System.Drawing.Size(61, 62);
            this.button_ExcluirAgendamento.TabIndex = 13;
            this.button_ExcluirAgendamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ExcluirAgendamento.UseVisualStyleBackColor = false;
            // 
            // textBox_BuscarData
            // 
            this.textBox_BuscarData.Location = new System.Drawing.Point(507, 230);
            this.textBox_BuscarData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_BuscarData.Name = "textBox_BuscarData";
            this.textBox_BuscarData.Size = new System.Drawing.Size(104, 22);
            this.textBox_BuscarData.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            // 
            // button_AbrirCalendario
            // 
            this.button_AbrirCalendario.BackColor = System.Drawing.Color.Transparent;
            this.button_AbrirCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AbrirCalendario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_AbrirCalendario.ForeColor = System.Drawing.Color.Black;
            this.button_AbrirCalendario.Location = new System.Drawing.Point(627, 230);
            this.button_AbrirCalendario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AbrirCalendario.Name = "button_AbrirCalendario";
            this.button_AbrirCalendario.Size = new System.Drawing.Size(119, 25);
            this.button_AbrirCalendario.TabIndex = 16;
            this.button_AbrirCalendario.Text = "Calendário";
            this.button_AbrirCalendario.UseVisualStyleBackColor = false;
            this.button_AbrirCalendario.Click += new System.EventHandler(this.button_AbrirCalendario_Click);
            // 
            // monthCalendar_Agendamento
            // 
            this.monthCalendar_Agendamento.Location = new System.Drawing.Point(758, 73);
            this.monthCalendar_Agendamento.Name = "monthCalendar_Agendamento";
            this.monthCalendar_Agendamento.TabIndex = 17;
            this.monthCalendar_Agendamento.Visible = false;
            // 
            // button_SelecionarData
            // 
            this.button_SelecionarData.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelecionarData.Location = new System.Drawing.Point(849, 286);
            this.button_SelecionarData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SelecionarData.Name = "button_SelecionarData";
            this.button_SelecionarData.Size = new System.Drawing.Size(99, 31);
            this.button_SelecionarData.TabIndex = 18;
            this.button_SelecionarData.Text = "Selecionar";
            this.button_SelecionarData.UseVisualStyleBackColor = true;
            this.button_SelecionarData.Visible = false;
            this.button_SelecionarData.Click += new System.EventHandler(this.button_SelecionarData_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ImageKey = "fechar-removebg-preview.png";
            this.btnFechar.ImageList = this.imageList2;
            this.btnFechar.Location = new System.Drawing.Point(949, 12);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(67, 50);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "fechar-removebg-preview.png");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GestaoPetShop.Properties.Resources.bicho_de_estimacao;
            this.pictureBox3.Location = new System.Drawing.Point(12, 16);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(211, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(647, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Excluir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(499, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Alterar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(331, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cadastrar";
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // dataGridView1_FormsPrincipalBindingSource
            // 
            this.dataGridView1_FormsPrincipalBindingSource.DataSource = typeof(Models.DataGridView1_FormsPrincipal);
            // 
            // dataGridView1_FormsPrincipalDataGridView
            // 
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToAddRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToDeleteRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToOrderColumns = true;
            this.dataGridView1_FormsPrincipalDataGridView.AutoGenerateColumns = false;
            this.dataGridView1_FormsPrincipalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_FormsPrincipalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.dataGridView1_FormsPrincipalDataGridView.DataSource = this.dataGridView1_FormsPrincipalBindingSource;
            this.dataGridView1_FormsPrincipalDataGridView.Location = new System.Drawing.Point(16, 322);
            this.dataGridView1_FormsPrincipalDataGridView.Name = "dataGridView1_FormsPrincipalDataGridView";
            this.dataGridView1_FormsPrincipalDataGridView.ReadOnly = true;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersVisible = false;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersWidth = 51;
            this.dataGridView1_FormsPrincipalDataGridView.RowTemplate.Height = 24;
            this.dataGridView1_FormsPrincipalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_FormsPrincipalDataGridView.Size = new System.Drawing.Size(1031, 292);
            this.dataGridView1_FormsPrincipalDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DataAg";
            this.dataGridViewTextBoxColumn13.HeaderText = "DataAg";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "IdAgendamento";
            this.dataGridViewTextBoxColumn14.HeaderText = "IdAgendamento";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "NomeAnimal";
            this.dataGridViewTextBoxColumn15.HeaderText = "NomeAnimal";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn16.HeaderText = "NomeCliente";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn17.HeaderText = "Servico";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Horario";
            this.dataGridViewTextBoxColumn18.HeaderText = "Horario";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Profissional";
            this.dataGridViewTextBoxColumn19.HeaderText = "Profissional";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TelCliente";
            this.dataGridViewTextBoxColumn20.HeaderText = "TelCliente";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn21.HeaderText = "Situacao";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // ConsultaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoPetShop.Properties.Resources.papel_de_parede_2;
            this.ClientSize = new System.Drawing.Size(1073, 647);
            this.Controls.Add(this.dataGridView1_FormsPrincipalDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFechar);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaAgendamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).EndInit();
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
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.DataGridView dataGridView1_FormsPrincipalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}