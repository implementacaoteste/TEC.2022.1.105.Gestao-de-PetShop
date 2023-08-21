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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1_FormsPrincipalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1_FormsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< Updated upstream
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
=======
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(861, 28);
>>>>>>> Stashed changes
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.gruposDeUsuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.servicosToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.animalToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
<<<<<<< Updated upstream
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
=======
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
>>>>>>> Stashed changes
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::GestaoPetShop.Properties.Resources.user;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.usuariosToolStripMenuItem.Text = "Usuários";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // gruposDeUsuariosToolStripMenuItem
            // 
            this.gruposDeUsuariosToolStripMenuItem.Image = global::GestaoPetShop.Properties.Resources.grupousuario;
            this.gruposDeUsuariosToolStripMenuItem.Name = "gruposDeUsuariosToolStripMenuItem";
            this.gruposDeUsuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gruposDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.gruposDeUsuariosToolStripMenuItem.Text = "Grupos de usuários";
            this.gruposDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gruposDeUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::GestaoPetShop.Properties.Resources.client;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // servicosToolStripMenuItem
            // 
            this.servicosToolStripMenuItem.Image = global::GestaoPetShop.Properties.Resources.servico;
            this.servicosToolStripMenuItem.Name = "servicosToolStripMenuItem";
            this.servicosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.servicosToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.servicosToolStripMenuItem.Text = "Serviços";
            this.servicosToolStripMenuItem.Click += new System.EventHandler(this.servicosToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Image = global::GestaoPetShop.Properties.Resources.calendar;
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.Image = global::GestaoPetShop.Properties.Resources.animal;
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.animalToolStripMenuItem.Text = "Animal";
            this.animalToolStripMenuItem.Click += new System.EventHandler(this.animalToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(310, 30);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "buscar-removebg-preview.png";
            this.button1.ImageList = this.imageList1;
<<<<<<< Updated upstream
            this.button1.Location = new System.Drawing.Point(540, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
=======
            this.button1.Location = new System.Drawing.Point(713, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 48);
>>>>>>> Stashed changes
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "fechar-removebg-preview.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "fechar-removebg-preview.png";
            this.button2.ImageList = this.imageList1;
<<<<<<< Updated upstream
            this.button2.Location = new System.Drawing.Point(540, 161);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 31);
=======
            this.button2.Location = new System.Drawing.Point(713, 198);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
>>>>>>> Stashed changes
            this.button2.TabIndex = 5;
            this.button2.Text = " Fechar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1_FormsPrincipalDataGridView
            // 
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToAddRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToDeleteRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToOrderColumns = true;
            this.dataGridView1_FormsPrincipalDataGridView.AutoGenerateColumns = false;
            this.dataGridView1_FormsPrincipalDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1_FormsPrincipalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_FormsPrincipalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView1_FormsPrincipalDataGridView.DataSource = this.dataGridView1_FormsPrincipalBindingSource;
            this.dataGridView1_FormsPrincipalDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
<<<<<<< Updated upstream
            this.dataGridView1_FormsPrincipalDataGridView.Location = new System.Drawing.Point(12, 227);
=======
            this.dataGridView1_FormsPrincipalDataGridView.Location = new System.Drawing.Point(16, 253);
            this.dataGridView1_FormsPrincipalDataGridView.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> Stashed changes
            this.dataGridView1_FormsPrincipalDataGridView.MultiSelect = false;
            this.dataGridView1_FormsPrincipalDataGridView.Name = "dataGridView1_FormsPrincipalDataGridView";
            this.dataGridView1_FormsPrincipalDataGridView.ReadOnly = true;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersVisible = false;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersWidth = 51;
            this.dataGridView1_FormsPrincipalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_FormsPrincipalDataGridView.Size = new System.Drawing.Size(618, 162);
            this.dataGridView1_FormsPrincipalDataGridView.TabIndex = 6;
            this.dataGridView1_FormsPrincipalDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataAg";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Horario";
            this.dataGridViewTextBoxColumn12.HeaderText = "Horário";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NomeAnimal";
            this.dataGridViewTextBoxColumn9.HeaderText = "Animal";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn11.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Profissional";
            this.dataGridViewTextBoxColumn13.HeaderText = "Profissional";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn15.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridView1_FormsPrincipalBindingSource
            // 
            this.dataGridView1_FormsPrincipalBindingSource.DataSource = typeof(Models.DataGridView1_FormsPrincipal);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.ForestGreen;
<<<<<<< Updated upstream
            this.lblUsuarioLogado.Location = new System.Drawing.Point(81, 404);
            this.lblUsuarioLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.lblUsuarioLogado.Location = new System.Drawing.Point(108, 464);
>>>>>>> Stashed changes
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(129, 19);
            this.lblUsuarioLogado.TabIndex = 7;
            this.lblUsuarioLogado.Text = "Usuário Logado";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUser.Location = new System.Drawing.Point(148, 404);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 19);
            this.lblUser.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
<<<<<<< Updated upstream
            this.label1.Location = new System.Drawing.Point(9, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.label1.Location = new System.Drawing.Point(12, 464);
>>>>>>> Stashed changes
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Logado:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoPetShop.Properties.Resources.papel_de_parede_21;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(639, 441);
=======
            this.ClientSize = new System.Drawing.Size(861, 503);
>>>>>>> Stashed changes
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.dataGridView1_FormsPrincipalDataGridView);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo configuração";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dataGridView1_FormsPrincipalBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1_FormsPrincipalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
    }
}

