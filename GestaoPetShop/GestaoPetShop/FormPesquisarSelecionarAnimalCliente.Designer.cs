namespace GestaoPetShop
{
    partial class FormPesquisarSelecionarAnimalCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarSelecionarAnimalCliente));
            this.buttonBuscarAnimalCliente = new System.Windows.Forms.Button();
            this.buttonSelecionarAnimalCliente = new System.Windows.Forms.Button();
            this.textBoxPesquisaAnimalCliente = new System.Windows.Forms.TextBox();
            this.comboBoxEscolherTipoPequisaAnimalCliente = new System.Windows.Forms.ComboBox();
            this.buttonCancelarPesquisaAnimalCliente = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarAnimalCliente
            // 
            this.buttonBuscarAnimalCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscarAnimalCliente.Location = new System.Drawing.Point(438, 98);
            this.buttonBuscarAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarAnimalCliente.Name = "buttonBuscarAnimalCliente";
            this.buttonBuscarAnimalCliente.Size = new System.Drawing.Size(76, 28);
            this.buttonBuscarAnimalCliente.TabIndex = 2;
            this.buttonBuscarAnimalCliente.Text = "Buscar";
            this.buttonBuscarAnimalCliente.UseVisualStyleBackColor = false;
            this.buttonBuscarAnimalCliente.Click += new System.EventHandler(this.buttonBuscarAnimalCliente_Click);
            // 
            // buttonSelecionarAnimalCliente
            // 
            this.buttonSelecionarAnimalCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSelecionarAnimalCliente.Location = new System.Drawing.Point(312, 312);
            this.buttonSelecionarAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarAnimalCliente.Name = "buttonSelecionarAnimalCliente";
            this.buttonSelecionarAnimalCliente.Size = new System.Drawing.Size(100, 28);
            this.buttonSelecionarAnimalCliente.TabIndex = 3;
            this.buttonSelecionarAnimalCliente.Text = "Selecionar";
            this.buttonSelecionarAnimalCliente.UseVisualStyleBackColor = false;
            this.buttonSelecionarAnimalCliente.Click += new System.EventHandler(this.buttonSelecionarAnimalCliente_Click);
            // 
            // textBoxPesquisaAnimalCliente
            // 
            this.textBoxPesquisaAnimalCliente.Location = new System.Drawing.Point(142, 103);
            this.textBoxPesquisaAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesquisaAnimalCliente.Name = "textBoxPesquisaAnimalCliente";
            this.textBoxPesquisaAnimalCliente.Size = new System.Drawing.Size(260, 22);
            this.textBoxPesquisaAnimalCliente.TabIndex = 4;
            // 
            // comboBoxEscolherTipoPequisaAnimalCliente
            // 
            this.comboBoxEscolherTipoPequisaAnimalCliente.FormattingEnabled = true;
            this.comboBoxEscolherTipoPequisaAnimalCliente.Items.AddRange(new object[] {
            "Id Animal",
            "Id Cliente",
            "Nome Animal",
            "Nome Cliente"});
            this.comboBoxEscolherTipoPequisaAnimalCliente.Location = new System.Drawing.Point(12, 101);
            this.comboBoxEscolherTipoPequisaAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEscolherTipoPequisaAnimalCliente.Name = "comboBoxEscolherTipoPequisaAnimalCliente";
            this.comboBoxEscolherTipoPequisaAnimalCliente.Size = new System.Drawing.Size(124, 24);
            this.comboBoxEscolherTipoPequisaAnimalCliente.TabIndex = 5;
            // 
            // buttonCancelarPesquisaAnimalCliente
            // 
            this.buttonCancelarPesquisaAnimalCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelarPesquisaAnimalCliente.Location = new System.Drawing.Point(419, 312);
            this.buttonCancelarPesquisaAnimalCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelarPesquisaAnimalCliente.Name = "buttonCancelarPesquisaAnimalCliente";
            this.buttonCancelarPesquisaAnimalCliente.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelarPesquisaAnimalCliente.TabIndex = 6;
            this.buttonCancelarPesquisaAnimalCliente.Text = "Cancelar";
            this.buttonCancelarPesquisaAnimalCliente.UseVisualStyleBackColor = false;
            this.buttonCancelarPesquisaAnimalCliente.Click += new System.EventHandler(this.buttonCancelarPesquisaAnimalCliente_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AllowUserToOrderColumns = true;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 141);
            this.clienteDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersVisible = false;
            this.clienteDataGridView.RowHeadersWidth = 51;
            this.clienteDataGridView.RowTemplate.Height = 24;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(248, 165);
            this.clienteDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataMember = "Animais";
            this.animaisBindingSource.DataSource = this.clienteBindingSource;
            // 
            // animaisDataGridView
            // 
            this.animaisDataGridView.AllowUserToAddRows = false;
            this.animaisDataGridView.AllowUserToDeleteRows = false;
            this.animaisDataGridView.AllowUserToOrderColumns = true;
            this.animaisDataGridView.AutoGenerateColumns = false;
            this.animaisDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.animaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.animaisDataGridView.DataSource = this.animaisBindingSource;
            this.animaisDataGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.animaisDataGridView.Location = new System.Drawing.Point(266, 141);
            this.animaisDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animaisDataGridView.Name = "animaisDataGridView";
            this.animaisDataGridView.ReadOnly = true;
            this.animaisDataGridView.RowHeadersVisible = false;
            this.animaisDataGridView.RowHeadersWidth = 51;
            this.animaisDataGridView.RowTemplate.Height = 24;
            this.animaisDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.animaisDataGridView.Size = new System.Drawing.Size(248, 165);
            this.animaisDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome do Animal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 29);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Pesquisar Animal";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormPesquisarSelecionarAnimalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.animaisDataGridView);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.buttonCancelarPesquisaAnimalCliente);
            this.Controls.Add(this.comboBoxEscolherTipoPequisaAnimalCliente);
            this.Controls.Add(this.textBoxPesquisaAnimalCliente);
            this.Controls.Add(this.buttonSelecionarAnimalCliente);
            this.Controls.Add(this.buttonBuscarAnimalCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormPesquisarSelecionarAnimalCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBuscarAnimalCliente;
        private System.Windows.Forms.Button buttonSelecionarAnimalCliente;
        private System.Windows.Forms.TextBox textBoxPesquisaAnimalCliente;
        private System.Windows.Forms.ComboBox comboBoxEscolherTipoPequisaAnimalCliente;
        private System.Windows.Forms.Button buttonCancelarPesquisaAnimalCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private System.Windows.Forms.DataGridView animaisDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}