namespace GestaoPetShop
{
    partial class FormConsultaServico
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
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox_EscolhaBuscarServico = new System.Windows.Forms.ComboBox();
            this.textBox_BuscarServico = new System.Windows.Forms.TextBox();
            this.button_BucarServico = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // servicoDataGridView
            // 
            this.servicoDataGridView.AllowUserToAddRows = false;
            this.servicoDataGridView.AllowUserToDeleteRows = false;
            this.servicoDataGridView.AllowUserToOrderColumns = true;
            this.servicoDataGridView.AutoGenerateColumns = false;
            this.servicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Preco,
            this.Tempo,
            this.Ativo});
            this.servicoDataGridView.DataSource = this.servicoBindingSource;
            this.servicoDataGridView.Location = new System.Drawing.Point(12, 179);
            this.servicoDataGridView.Name = "servicoDataGridView";
            this.servicoDataGridView.ReadOnly = true;
            this.servicoDataGridView.RowHeadersVisible = false;
            this.servicoDataGridView.Size = new System.Drawing.Size(750, 252);
            this.servicoDataGridView.TabIndex = 3;
            // 
            // comboBox_EscolhaBuscarServico
            // 
            this.comboBox_EscolhaBuscarServico.FormattingEnabled = true;
            this.comboBox_EscolhaBuscarServico.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Descrição"});
            this.comboBox_EscolhaBuscarServico.Location = new System.Drawing.Point(12, 135);
            this.comboBox_EscolhaBuscarServico.Name = "comboBox_EscolhaBuscarServico";
            this.comboBox_EscolhaBuscarServico.Size = new System.Drawing.Size(121, 21);
            this.comboBox_EscolhaBuscarServico.TabIndex = 4;
            // 
            // textBox_BuscarServico
            // 
            this.textBox_BuscarServico.Location = new System.Drawing.Point(139, 136);
            this.textBox_BuscarServico.Name = "textBox_BuscarServico";
            this.textBox_BuscarServico.Size = new System.Drawing.Size(411, 20);
            this.textBox_BuscarServico.TabIndex = 5;
            // 
            // button_BucarServico
            // 
            this.button_BucarServico.Location = new System.Drawing.Point(556, 136);
            this.button_BucarServico.Name = "button_BucarServico";
            this.button_BucarServico.Size = new System.Drawing.Size(75, 23);
            this.button_BucarServico.TabIndex = 6;
            this.button_BucarServico.Text = "Buscar";
            this.button_BucarServico.UseVisualStyleBackColor = true;
            this.button_BucarServico.Click += new System.EventHandler(this.button_BucarServico_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Tempo
            // 
            this.Tempo.DataPropertyName = "Tempo";
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 60;
            // 
            // FormConsultaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.button_BucarServico);
            this.Controls.Add(this.textBox_BuscarServico);
            this.Controls.Add(this.comboBox_EscolhaBuscarServico);
            this.Controls.Add(this.servicoDataGridView);
            this.Name = "FormConsultaServico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.DataGridView servicoDataGridView;
        private System.Windows.Forms.ComboBox comboBox_EscolhaBuscarServico;
        private System.Windows.Forms.TextBox textBox_BuscarServico;
        private System.Windows.Forms.Button button_BucarServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
    }
}