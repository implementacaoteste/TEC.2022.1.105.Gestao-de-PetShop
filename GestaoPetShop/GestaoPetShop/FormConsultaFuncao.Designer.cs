namespace GestaoPetShop
{
    partial class FormConsultaFuncao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaFuncao));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblConsultaFuncao = new System.Windows.Forms.Label();
            this.comboBoxEscolhaBuscarFuncao = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarFuncao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscarFuncao = new System.Windows.Forms.Button();
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVincularPermissaoEmFuncao = new System.Windows.Forms.Button();
            this.buttonDesvincularPermissaoDeFuncao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fechar-removebg-preview.ico");
            this.imageList1.Images.SetKeyName(1, "buscar-removebg-preview.ico");
            this.imageList1.Images.SetKeyName(2, "add-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "editar-removebg-preview.ico");
            this.imageList1.Images.SetKeyName(4, "excluir-removebg-preview.ico");
            // 
            // lblConsultaFuncao
            // 
            this.lblConsultaFuncao.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultaFuncao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaFuncao.Location = new System.Drawing.Point(14, 18);
            this.lblConsultaFuncao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultaFuncao.Name = "lblConsultaFuncao";
            this.lblConsultaFuncao.Size = new System.Drawing.Size(833, 50);
            this.lblConsultaFuncao.TabIndex = 25;
            this.lblConsultaFuncao.Text = "Consulta de Função";
            this.lblConsultaFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxEscolhaBuscarFuncao
            // 
            this.comboBoxEscolhaBuscarFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEscolhaBuscarFuncao.FormattingEnabled = true;
            this.comboBoxEscolhaBuscarFuncao.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nome"});
            this.comboBoxEscolhaBuscarFuncao.Location = new System.Drawing.Point(21, 155);
            this.comboBoxEscolhaBuscarFuncao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEscolhaBuscarFuncao.Name = "comboBoxEscolhaBuscarFuncao";
            this.comboBoxEscolhaBuscarFuncao.Size = new System.Drawing.Size(129, 28);
            this.comboBoxEscolhaBuscarFuncao.TabIndex = 26;
            // 
            // textBoxBuscarFuncao
            // 
            this.textBoxBuscarFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarFuncao.Location = new System.Drawing.Point(159, 155);
            this.textBoxBuscarFuncao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBuscarFuncao.Name = "textBoxBuscarFuncao";
            this.textBoxBuscarFuncao.Size = new System.Drawing.Size(319, 29);
            this.textBoxBuscarFuncao.TabIndex = 31;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageKey = "(none)";
            this.btnExcluir.Location = new System.Drawing.Point(769, 151);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 34);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.ImageKey = "(none)";
            this.btnAlterar.Location = new System.Drawing.Point(684, 151);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 34);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.ImageList = this.imageList1;
            this.btnCadastrar.Location = new System.Drawing.Point(599, 151);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(77, 34);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "Inserir";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscarFuncao
            // 
            this.btnBuscarFuncao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscarFuncao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarFuncao.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncao.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarFuncao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarFuncao.ImageKey = "(none)";
            this.btnBuscarFuncao.Location = new System.Drawing.Point(513, 151);
            this.btnBuscarFuncao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarFuncao.Name = "btnBuscarFuncao";
            this.btnBuscarFuncao.Size = new System.Drawing.Size(77, 34);
            this.btnBuscarFuncao.TabIndex = 28;
            this.btnBuscarFuncao.Text = "Buscar";
            this.btnBuscarFuncao.UseVisualStyleBackColor = false;
            this.btnBuscarFuncao.Click += new System.EventHandler(this.btnBuscarFuncao_Click);
            // 
            // funcaoBindingSource
            // 
            this.funcaoBindingSource.DataSource = typeof(Models.Funcao);
            // 
            // funcaoDataGridView
            // 
            this.funcaoDataGridView.AllowUserToAddRows = false;
            this.funcaoDataGridView.AllowUserToDeleteRows = false;
            this.funcaoDataGridView.AllowUserToOrderColumns = true;
            this.funcaoDataGridView.AllowUserToResizeColumns = false;
            this.funcaoDataGridView.AllowUserToResizeRows = false;
            this.funcaoDataGridView.AutoGenerateColumns = false;
            this.funcaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.funcaoDataGridView.DataSource = this.funcaoBindingSource;
            this.funcaoDataGridView.Location = new System.Drawing.Point(13, 253);
            this.funcaoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funcaoDataGridView.Name = "funcaoDataGridView";
            this.funcaoDataGridView.ReadOnly = true;
            this.funcaoDataGridView.RowHeadersVisible = false;
            this.funcaoDataGridView.RowHeadersWidth = 51;
            this.funcaoDataGridView.RowTemplate.Height = 24;
            this.funcaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.funcaoDataGridView.Size = new System.Drawing.Size(465, 329);
            this.funcaoDataGridView.TabIndex = 39;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.funcaoBindingSource;
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AllowUserToResizeColumns = false;
            this.permissoesDataGridView.AllowUserToResizeRows = false;
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(484, 253);
            this.permissoesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.permissoesDataGridView.Size = new System.Drawing.Size(363, 329);
            this.permissoesDataGridView.TabIndex = 39;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // buttonVincularPermissaoEmFuncao
            // 
            this.buttonVincularPermissaoEmFuncao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonVincularPermissaoEmFuncao.Location = new System.Drawing.Point(656, 211);
            this.buttonVincularPermissaoEmFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVincularPermissaoEmFuncao.Name = "buttonVincularPermissaoEmFuncao";
            this.buttonVincularPermissaoEmFuncao.Size = new System.Drawing.Size(77, 34);
            this.buttonVincularPermissaoEmFuncao.TabIndex = 40;
            this.buttonVincularPermissaoEmFuncao.Text = "Vincular";
            this.buttonVincularPermissaoEmFuncao.UseVisualStyleBackColor = false;
            this.buttonVincularPermissaoEmFuncao.Click += new System.EventHandler(this.buttonVincularPermissaoEmFuncao_Click);
            // 
            // buttonDesvincularPermissaoDeFuncao
            // 
            this.buttonDesvincularPermissaoDeFuncao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDesvincularPermissaoDeFuncao.Location = new System.Drawing.Point(738, 211);
            this.buttonDesvincularPermissaoDeFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDesvincularPermissaoDeFuncao.Name = "buttonDesvincularPermissaoDeFuncao";
            this.buttonDesvincularPermissaoDeFuncao.Size = new System.Drawing.Size(109, 34);
            this.buttonDesvincularPermissaoDeFuncao.TabIndex = 41;
            this.buttonDesvincularPermissaoDeFuncao.Text = "Desvincular";
            this.buttonDesvincularPermissaoDeFuncao.UseVisualStyleBackColor = false;
            this.buttonDesvincularPermissaoDeFuncao.Click += new System.EventHandler(this.buttonDesvincularPermissaoDeFuncao_Click);
            // 
            // FormConsultaFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 614);
            this.Controls.Add(this.buttonDesvincularPermissaoDeFuncao);
            this.Controls.Add(this.buttonVincularPermissaoEmFuncao);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.funcaoDataGridView);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textBoxBuscarFuncao);
            this.Controls.Add(this.btnBuscarFuncao);
            this.Controls.Add(this.comboBoxEscolhaBuscarFuncao);
            this.Controls.Add(this.lblConsultaFuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(878, 661);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(878, 661);
            this.Name = "FormConsultaFuncao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblConsultaFuncao;
        private System.Windows.Forms.ComboBox comboBoxEscolhaBuscarFuncao;
        private System.Windows.Forms.Button btnBuscarFuncao;
        private System.Windows.Forms.TextBox textBoxBuscarFuncao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.BindingSource funcaoBindingSource;
        private System.Windows.Forms.DataGridView funcaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonVincularPermissaoEmFuncao;
        private System.Windows.Forms.Button buttonDesvincularPermissaoDeFuncao;
    }
}