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
            this.dataGridView1_FormsPrincipalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1_FormsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_AbrirCalendario = new System.Windows.Forms.Button();
            this.monthCalendar_Agendamento = new System.Windows.Forms.MonthCalendar();
            this.button_SelecionarData = new System.Windows.Forms.Button();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 32);
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
            this.comboBox_SelecionarTipoBusca.Location = new System.Drawing.Point(12, 188);
            this.comboBox_SelecionarTipoBusca.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_SelecionarTipoBusca.Name = "comboBox_SelecionarTipoBusca";
            this.comboBox_SelecionarTipoBusca.Size = new System.Drawing.Size(92, 21);
            this.comboBox_SelecionarTipoBusca.TabIndex = 8;
            this.comboBox_SelecionarTipoBusca.Text = "Buscar por";
            // 
            // textBox_BuscarAgendamento
            // 
            this.textBox_BuscarAgendamento.Location = new System.Drawing.Point(107, 191);
            this.textBox_BuscarAgendamento.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_BuscarAgendamento.Name = "textBox_BuscarAgendamento";
            this.textBox_BuscarAgendamento.Size = new System.Drawing.Size(217, 20);
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
            this.button_BuscarAgendamentos.Location = new System.Drawing.Point(158, 91);
            this.button_BuscarAgendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.button_BuscarAgendamentos.Name = "button_BuscarAgendamentos";
            this.button_BuscarAgendamentos.Size = new System.Drawing.Size(56, 50);
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
            this.button_InserirAgendamentos.Location = new System.Drawing.Point(266, 86);
            this.button_InserirAgendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.button_InserirAgendamentos.Name = "button_InserirAgendamentos";
            this.button_InserirAgendamentos.Size = new System.Drawing.Size(44, 50);
            this.button_InserirAgendamentos.TabIndex = 11;
            this.button_InserirAgendamentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_InserirAgendamentos.UseVisualStyleBackColor = false;
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
            this.button_AlterarAgendamentos.Location = new System.Drawing.Point(380, 81);
            this.button_AlterarAgendamentos.Margin = new System.Windows.Forms.Padding(2);
            this.button_AlterarAgendamentos.Name = "button_AlterarAgendamentos";
            this.button_AlterarAgendamentos.Size = new System.Drawing.Size(50, 50);
            this.button_AlterarAgendamentos.TabIndex = 12;
            this.button_AlterarAgendamentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AlterarAgendamentos.UseVisualStyleBackColor = false;
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
            this.button_ExcluirAgendamento.Location = new System.Drawing.Point(493, 81);
            this.button_ExcluirAgendamento.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExcluirAgendamento.Name = "button_ExcluirAgendamento";
            this.button_ExcluirAgendamento.Size = new System.Drawing.Size(46, 50);
            this.button_ExcluirAgendamento.TabIndex = 13;
            this.button_ExcluirAgendamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ExcluirAgendamento.UseVisualStyleBackColor = false;
            // 
            // textBox_BuscarData
            // 
            this.textBox_BuscarData.Location = new System.Drawing.Point(380, 190);
            this.textBox_BuscarData.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_BuscarData.Name = "textBox_BuscarData";
            this.textBox_BuscarData.Size = new System.Drawing.Size(76, 20);
            this.textBox_BuscarData.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            // 
            // dataGridView1_FormsPrincipalDataGridView
            // 
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToAddRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToDeleteRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToOrderColumns = true;
            this.dataGridView1_FormsPrincipalDataGridView.AutoGenerateColumns = false;
            this.dataGridView1_FormsPrincipalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_FormsPrincipalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1_FormsPrincipalDataGridView.DataSource = this.dataGridView1_FormsPrincipalBindingSource;
            this.dataGridView1_FormsPrincipalDataGridView.Location = new System.Drawing.Point(11, 212);
            this.dataGridView1_FormsPrincipalDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1_FormsPrincipalDataGridView.MultiSelect = false;
            this.dataGridView1_FormsPrincipalDataGridView.Name = "dataGridView1_FormsPrincipalDataGridView";
            this.dataGridView1_FormsPrincipalDataGridView.ReadOnly = true;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersVisible = false;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersWidth = 51;
            this.dataGridView1_FormsPrincipalDataGridView.RowTemplate.Height = 24;
            this.dataGridView1_FormsPrincipalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_FormsPrincipalDataGridView.Size = new System.Drawing.Size(751, 338);
            this.dataGridView1_FormsPrincipalDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DataAg";
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeAnimal";
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Animal";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Horario";
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Horário";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Profissional";
            this.dataGridViewTextBoxColumn6.FillWeight = 150F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Profissional";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridView1_FormsPrincipalBindingSource
            // 
            this.dataGridView1_FormsPrincipalBindingSource.DataSource = typeof(Models.DataGridView1_FormsPrincipal);
            // 
            // button_AbrirCalendario
            // 
            this.button_AbrirCalendario.Location = new System.Drawing.Point(470, 190);
            this.button_AbrirCalendario.Margin = new System.Windows.Forms.Padding(2);
            this.button_AbrirCalendario.Name = "button_AbrirCalendario";
            this.button_AbrirCalendario.Size = new System.Drawing.Size(74, 19);
            this.button_AbrirCalendario.TabIndex = 16;
            this.button_AbrirCalendario.Text = "Calendário";
            this.button_AbrirCalendario.UseVisualStyleBackColor = true;
            this.button_AbrirCalendario.Click += new System.EventHandler(this.button_AbrirCalendario_Click);
            // 
            // monthCalendar_Agendamento
            // 
            this.monthCalendar_Agendamento.Location = new System.Drawing.Point(456, 327);
            this.monthCalendar_Agendamento.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar_Agendamento.Name = "monthCalendar_Agendamento";
            this.monthCalendar_Agendamento.TabIndex = 17;
            this.monthCalendar_Agendamento.Visible = false;
            // 
            // button_SelecionarData
            // 
            this.button_SelecionarData.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelecionarData.Location = new System.Drawing.Point(524, 500);
            this.button_SelecionarData.Margin = new System.Windows.Forms.Padding(2);
            this.button_SelecionarData.Name = "button_SelecionarData";
            this.button_SelecionarData.Size = new System.Drawing.Size(74, 19);
            this.button_SelecionarData.TabIndex = 18;
            this.button_SelecionarData.Text = "Selecionar";
            this.button_SelecionarData.UseVisualStyleBackColor = true;
            this.button_SelecionarData.Visible = false;
            this.button_SelecionarData.Click += new System.EventHandler(this.button_SelecionarData_Click);
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ImageKey = "fechar-removebg-preview.png";
            this.btnFechar.ImageList = this.imageList2;
            this.btnFechar.Location = new System.Drawing.Point(712, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 41);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.UseVisualStyleBackColor = true;
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
            this.pictureBox3.Image = global::GestaoPetShop.Properties.Resources.bicho_de_estimacao;
            this.pictureBox3.Location = new System.Drawing.Point(9, 13);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(158, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(485, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Excluir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(374, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Alterar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(248, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cadastrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.button_SelecionarData);
            this.Controls.Add(this.monthCalendar_Agendamento);
            this.Controls.Add(this.button_AbrirCalendario);
            this.Controls.Add(this.dataGridView1_FormsPrincipalDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BuscarData);
            this.Controls.Add(this.button_InserirAgendamentos);
            this.Controls.Add(this.button_BuscarAgendamentos);
            this.Controls.Add(this.textBox_BuscarAgendamento);
            this.Controls.Add(this.comboBox_SelecionarTipoBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AlterarAgendamentos);
            this.Controls.Add(this.button_ExcluirAgendamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaAgendamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SelecionarTipoBusca;
        private System.Windows.Forms.TextBox textBox_BuscarAgendamento;
        private System.Windows.Forms.Button button_BuscarAgendamentos;
        private System.Windows.Forms.Button button_InserirAgendamentos;
        private System.Windows.Forms.Button button_AlterarAgendamentos;
        private System.Windows.Forms.Button button_ExcluirAgendamento;
        private System.Windows.Forms.BindingSource dataGridView1_FormsPrincipalBindingSource;
        private System.Windows.Forms.TextBox textBox_BuscarData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_FormsPrincipalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
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
        private System.Windows.Forms.Button button1;
    }
}