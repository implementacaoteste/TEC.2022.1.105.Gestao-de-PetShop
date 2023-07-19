namespace GestaoPetShop
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1_Agendamentos = new System.Windows.Forms.DataGridView();
            this.dataAgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1FormsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_BuscarAgendamento = new System.Windows.Forms.Button();
            this.button1_FecharViewAgendamento = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Agendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1FormsPrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.gruposDeUsuáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // gruposDeUsuáriosToolStripMenuItem
            // 
            this.gruposDeUsuáriosToolStripMenuItem.Name = "gruposDeUsuáriosToolStripMenuItem";
            this.gruposDeUsuáriosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gruposDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gruposDeUsuáriosToolStripMenuItem.Text = "Grupos de usuários";
            this.gruposDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gruposDeUsuáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(343, 4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dataGridView1_Agendamentos
            // 
            this.dataGridView1_Agendamentos.AllowUserToAddRows = false;
            this.dataGridView1_Agendamentos.AllowUserToDeleteRows = false;
            this.dataGridView1_Agendamentos.AllowUserToOrderColumns = true;
            this.dataGridView1_Agendamentos.AutoGenerateColumns = false;
            this.dataGridView1_Agendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Agendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataAgDataGridViewTextBoxColumn,
            this.nomeAnimalDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.servicoDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn,
            this.profissionalDataGridViewTextBoxColumn,
            this.telClienteDataGridViewTextBoxColumn});
            this.dataGridView1_Agendamentos.DataSource = this.dataGridView1FormsPrincipalBindingSource;
            this.dataGridView1_Agendamentos.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1_Agendamentos.Name = "dataGridView1_Agendamentos";
            this.dataGridView1_Agendamentos.ReadOnly = true;
            this.dataGridView1_Agendamentos.RowHeadersVisible = false;
            this.dataGridView1_Agendamentos.Size = new System.Drawing.Size(630, 205);
            this.dataGridView1_Agendamentos.TabIndex = 2;
            this.dataGridView1_Agendamentos.Visible = false;
            // 
            // dataAgDataGridViewTextBoxColumn
            // 
            this.dataAgDataGridViewTextBoxColumn.DataPropertyName = "DataAg";
            this.dataAgDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataAgDataGridViewTextBoxColumn.Name = "dataAgDataGridViewTextBoxColumn";
            this.dataAgDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAgDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeAnimalDataGridViewTextBoxColumn
            // 
            this.nomeAnimalDataGridViewTextBoxColumn.DataPropertyName = "NomeAnimal";
            this.nomeAnimalDataGridViewTextBoxColumn.HeaderText = "Nome do Animal";
            this.nomeAnimalDataGridViewTextBoxColumn.Name = "nomeAnimalDataGridViewTextBoxColumn";
            this.nomeAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome do Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicoDataGridViewTextBoxColumn
            // 
            this.servicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servicoDataGridViewTextBoxColumn.DataPropertyName = "Servico";
            this.servicoDataGridViewTextBoxColumn.HeaderText = "Serviço";
            this.servicoDataGridViewTextBoxColumn.Name = "servicoDataGridViewTextBoxColumn";
            this.servicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horário";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioDataGridViewTextBoxColumn.Width = 60;
            // 
            // profissionalDataGridViewTextBoxColumn
            // 
            this.profissionalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profissionalDataGridViewTextBoxColumn.DataPropertyName = "Profissional";
            this.profissionalDataGridViewTextBoxColumn.HeaderText = "Profissional";
            this.profissionalDataGridViewTextBoxColumn.Name = "profissionalDataGridViewTextBoxColumn";
            this.profissionalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telClienteDataGridViewTextBoxColumn
            // 
            this.telClienteDataGridViewTextBoxColumn.DataPropertyName = "TelCliente";
            this.telClienteDataGridViewTextBoxColumn.HeaderText = "Contato do Cliente";
            this.telClienteDataGridViewTextBoxColumn.Name = "telClienteDataGridViewTextBoxColumn";
            this.telClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1FormsPrincipalBindingSource
            // 
            this.dataGridView1FormsPrincipalBindingSource.DataSource = typeof(Models.DataGridView1_FormsPrincipal);
            // 
            // button_BuscarAgendamento
            // 
            this.button_BuscarAgendamento.Location = new System.Drawing.Point(570, 52);
            this.button_BuscarAgendamento.Name = "button_BuscarAgendamento";
            this.button_BuscarAgendamento.Size = new System.Drawing.Size(60, 23);
            this.button_BuscarAgendamento.TabIndex = 3;
            this.button_BuscarAgendamento.Text = "Buscar";
            this.button_BuscarAgendamento.UseVisualStyleBackColor = true;
            this.button_BuscarAgendamento.Click += new System.EventHandler(this.button_BuscarAgendamento_Click);
            // 
            // button1_FecharViewAgendamento
            // 
            this.button1_FecharViewAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1_FecharViewAgendamento.Location = new System.Drawing.Point(601, 167);
            this.button1_FecharViewAgendamento.Name = "button1_FecharViewAgendamento";
            this.button1_FecharViewAgendamento.Size = new System.Drawing.Size(29, 23);
            this.button1_FecharViewAgendamento.TabIndex = 4;
            this.button1_FecharViewAgendamento.Text = "X";
            this.button1_FecharViewAgendamento.UseVisualStyleBackColor = false;
            this.button1_FecharViewAgendamento.Visible = false;
            this.button1_FecharViewAgendamento.Click += new System.EventHandler(this.button1_FecharViewAgendamento_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 384);
            this.Controls.Add(this.button1_FecharViewAgendamento);
            this.Controls.Add(this.button_BuscarAgendamento);
            this.Controls.Add(this.dataGridView1_Agendamentos);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo configuração";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Agendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1FormsPrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1_Agendamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataGridView1FormsPrincipalBindingSource;
        private System.Windows.Forms.Button button_BuscarAgendamento;
        private System.Windows.Forms.Button button1_FecharViewAgendamento;
    }
}

