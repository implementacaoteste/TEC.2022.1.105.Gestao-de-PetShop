namespace GestaoPetShop
{
    partial class FormVincularPermissaoEmFuncao
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
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.comboBoxSelecionarBuscaPermissao = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarPermissao = new System.Windows.Forms.TextBox();
            this.buttonSelecionarPermissao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(29, 130);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersVisible = false;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(569, 248);
            this.permissaoDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(523, 96);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPermissao.TabIndex = 2;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // comboBoxSelecionarBuscaPermissao
            // 
            this.comboBoxSelecionarBuscaPermissao.FormattingEnabled = true;
            this.comboBoxSelecionarBuscaPermissao.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nome"});
            this.comboBoxSelecionarBuscaPermissao.Location = new System.Drawing.Point(29, 96);
            this.comboBoxSelecionarBuscaPermissao.Name = "comboBoxSelecionarBuscaPermissao";
            this.comboBoxSelecionarBuscaPermissao.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSelecionarBuscaPermissao.TabIndex = 3;
            // 
            // textBoxBuscarPermissao
            // 
            this.textBoxBuscarPermissao.Location = new System.Drawing.Point(165, 96);
            this.textBoxBuscarPermissao.Name = "textBoxBuscarPermissao";
            this.textBoxBuscarPermissao.Size = new System.Drawing.Size(352, 22);
            this.textBoxBuscarPermissao.TabIndex = 4;
            // 
            // buttonSelecionarPermissao
            // 
            this.buttonSelecionarPermissao.Location = new System.Drawing.Point(485, 400);
            this.buttonSelecionarPermissao.Name = "buttonSelecionarPermissao";
            this.buttonSelecionarPermissao.Size = new System.Drawing.Size(113, 23);
            this.buttonSelecionarPermissao.TabIndex = 5;
            this.buttonSelecionarPermissao.Text = "Selecionar";
            this.buttonSelecionarPermissao.UseVisualStyleBackColor = true;
            // 
            // FormVincularPermissaoEmFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.buttonSelecionarPermissao);
            this.Controls.Add(this.textBoxBuscarPermissao);
            this.Controls.Add(this.comboBoxSelecionarBuscaPermissao);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.permissaoDataGridView);
            this.Name = "FormVincularPermissaoEmFuncao";
            this.Text = "FormVincularPermissaoEmFuncao";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.ComboBox comboBoxSelecionarBuscaPermissao;
        private System.Windows.Forms.TextBox textBoxBuscarPermissao;
        private System.Windows.Forms.Button buttonSelecionarPermissao;
    }
}