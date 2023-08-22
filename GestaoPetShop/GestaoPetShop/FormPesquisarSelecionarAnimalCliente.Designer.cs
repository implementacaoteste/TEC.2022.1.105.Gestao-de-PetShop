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
            this.buttonBuscarAnimalCliente = new System.Windows.Forms.Button();
            this.buttonSelecionarAnimalCliente = new System.Windows.Forms.Button();
            this.textBoxPesquisaAnimalCliente = new System.Windows.Forms.TextBox();
            this.comboBoxEscolherTipoPequisaAnimalCliente = new System.Windows.Forms.ComboBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarAnimalCliente
            // 
            this.buttonBuscarAnimalCliente.Location = new System.Drawing.Point(429, 66);
            this.buttonBuscarAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarAnimalCliente.Name = "buttonBuscarAnimalCliente";
            this.buttonBuscarAnimalCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarAnimalCliente.TabIndex = 2;
            this.buttonBuscarAnimalCliente.Text = "Buscar";
            this.buttonBuscarAnimalCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarAnimalCliente.Click += new System.EventHandler(this.buttonBuscarAnimalCliente_Click);
            // 
            // buttonSelecionarAnimalCliente
            // 
            this.buttonSelecionarAnimalCliente.Location = new System.Drawing.Point(509, 66);
            this.buttonSelecionarAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionarAnimalCliente.Name = "buttonSelecionarAnimalCliente";
            this.buttonSelecionarAnimalCliente.Size = new System.Drawing.Size(95, 23);
            this.buttonSelecionarAnimalCliente.TabIndex = 3;
            this.buttonSelecionarAnimalCliente.Text = "Selecionar";
            this.buttonSelecionarAnimalCliente.UseVisualStyleBackColor = true;
            this.buttonSelecionarAnimalCliente.Click += new System.EventHandler(this.buttonSelecionarAnimalCliente_Click);
            // 
            // textBoxPesquisaAnimalCliente
            // 
            this.textBoxPesquisaAnimalCliente.Location = new System.Drawing.Point(151, 66);
            this.textBoxPesquisaAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPesquisaAnimalCliente.Name = "textBoxPesquisaAnimalCliente";
            this.textBoxPesquisaAnimalCliente.Size = new System.Drawing.Size(272, 22);
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
            this.comboBoxEscolherTipoPequisaAnimalCliente.Location = new System.Drawing.Point(12, 66);
            this.comboBoxEscolherTipoPequisaAnimalCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEscolherTipoPequisaAnimalCliente.Name = "comboBoxEscolherTipoPequisaAnimalCliente";
            this.comboBoxEscolherTipoPequisaAnimalCliente.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEscolherTipoPequisaAnimalCliente.TabIndex = 5;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // agendamentoDataGridView
            // 
            this.agendamentoDataGridView.AllowUserToAddRows = false;
            this.agendamentoDataGridView.AllowUserToDeleteRows = false;
            this.agendamentoDataGridView.AllowUserToOrderColumns = true;
            this.agendamentoDataGridView.AutoGenerateColumns = false;
            this.agendamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.agendamentoDataGridView.DataSource = this.agendamentoBindingSource;
            this.agendamentoDataGridView.Location = new System.Drawing.Point(9, 113);
            this.agendamentoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agendamentoDataGridView.Name = "agendamentoDataGridView";
            this.agendamentoDataGridView.ReadOnly = true;
            this.agendamentoDataGridView.RowHeadersVisible = false;
            this.agendamentoDataGridView.RowHeadersWidth = 51;
            this.agendamentoDataGridView.RowTemplate.Height = 24;
            this.agendamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agendamentoDataGridView.Size = new System.Drawing.Size(621, 220);
            this.agendamentoDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAnimal";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id do Animal";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeAnimal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Animal";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id do Cliente";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn11.HeaderText = "NomeCliente";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPesquisarSelecionarAnimalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agendamentoDataGridView);
            this.Controls.Add(this.comboBoxEscolherTipoPequisaAnimalCliente);
            this.Controls.Add(this.textBoxPesquisaAnimalCliente);
            this.Controls.Add(this.buttonSelecionarAnimalCliente);
            this.Controls.Add(this.buttonBuscarAnimalCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPesquisarSelecionarAnimalCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarSelecionarAnimalCliente";
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBuscarAnimalCliente;
        private System.Windows.Forms.Button buttonSelecionarAnimalCliente;
        private System.Windows.Forms.TextBox textBoxPesquisaAnimalCliente;
        private System.Windows.Forms.ComboBox comboBoxEscolherTipoPequisaAnimalCliente;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.DataGridView agendamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button1;
    }
}