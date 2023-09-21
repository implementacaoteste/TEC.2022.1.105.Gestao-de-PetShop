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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVincularPermissaoEmFuncao));
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.comboBoxSelecionarBuscaPermissao = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarPermissao = new System.Windows.Forms.TextBox();
            this.buttonInserirPermissao = new System.Windows.Forms.Button();
            this.labelfuncao = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxIdFuncao = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxFuncao = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AllowUserToResizeColumns = false;
            this.permissaoDataGridView.AllowUserToResizeRows = false;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 147);
            this.permissaoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersVisible = false;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.permissaoDataGridView.Size = new System.Drawing.Size(508, 155);
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
            this.buttonBuscarPermissao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(439, 117);
            this.buttonBuscarPermissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(81, 26);
            this.buttonBuscarPermissao.TabIndex = 2;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = false;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // comboBoxSelecionarBuscaPermissao
            // 
            this.comboBoxSelecionarBuscaPermissao.FormattingEnabled = true;
            this.comboBoxSelecionarBuscaPermissao.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nome"});
            this.comboBoxSelecionarBuscaPermissao.Location = new System.Drawing.Point(12, 117);
            this.comboBoxSelecionarBuscaPermissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSelecionarBuscaPermissao.Name = "comboBoxSelecionarBuscaPermissao";
            this.comboBoxSelecionarBuscaPermissao.Size = new System.Drawing.Size(95, 24);
            this.comboBoxSelecionarBuscaPermissao.TabIndex = 3;
            // 
            // textBoxBuscarPermissao
            // 
            this.textBoxBuscarPermissao.Location = new System.Drawing.Point(139, 117);
            this.textBoxBuscarPermissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscarPermissao.Name = "textBoxBuscarPermissao";
            this.textBoxBuscarPermissao.Size = new System.Drawing.Size(236, 22);
            this.textBoxBuscarPermissao.TabIndex = 4;
            // 
            // buttonInserirPermissao
            // 
            this.buttonInserirPermissao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserirPermissao.Location = new System.Drawing.Point(352, 316);
            this.buttonInserirPermissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirPermissao.Name = "buttonInserirPermissao";
            this.buttonInserirPermissao.Size = new System.Drawing.Size(81, 26);
            this.buttonInserirPermissao.TabIndex = 5;
            this.buttonInserirPermissao.Text = "Inserir";
            this.buttonInserirPermissao.UseVisualStyleBackColor = false;
            this.buttonInserirPermissao.Click += new System.EventHandler(this.buttonInserirPermissao_Click);
            // 
            // labelfuncao
            // 
            this.labelfuncao.AutoSize = true;
            this.labelfuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfuncao.Location = new System.Drawing.Point(147, 72);
            this.labelfuncao.Name = "labelfuncao";
            this.labelfuncao.Size = new System.Drawing.Size(58, 16);
            this.labelfuncao.TabIndex = 7;
            this.labelfuncao.Text = "Função";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.Location = new System.Drawing.Point(439, 316);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(81, 26);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxIdFuncao
            // 
            this.textBoxIdFuncao.Enabled = false;
            this.textBoxIdFuncao.Location = new System.Drawing.Point(12, 91);
            this.textBoxIdFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdFuncao.Name = "textBoxIdFuncao";
            this.textBoxIdFuncao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxIdFuncao.Size = new System.Drawing.Size(63, 22);
            this.textBoxIdFuncao.TabIndex = 9;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(10, 72);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 16);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id";
            // 
            // textBoxFuncao
            // 
            this.textBoxFuncao.Enabled = false;
            this.textBoxFuncao.Location = new System.Drawing.Point(139, 91);
            this.textBoxFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFuncao.Name = "textBoxFuncao";
            this.textBoxFuncao.Size = new System.Drawing.Size(185, 22);
            this.textBoxFuncao.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Vincular Permissão - Função";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormVincularPermissaoEmFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxFuncao);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxIdFuncao);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelfuncao);
            this.Controls.Add(this.buttonInserirPermissao);
            this.Controls.Add(this.textBoxBuscarPermissao);
            this.Controls.Add(this.comboBoxSelecionarBuscaPermissao);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.permissaoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormVincularPermissaoEmFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button buttonInserirPermissao;
        private System.Windows.Forms.Label labelfuncao;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxIdFuncao;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxFuncao;
        private System.Windows.Forms.TextBox textBox1;
    }
}