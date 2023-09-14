namespace GestaoPetShop
{
    partial class FormBuscarFuncao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarFuncao));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblConsultaFuncao = new System.Windows.Forms.Label();
            this.comboBoxEscolhaBuscarFuncao = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscarFuncao = new System.Windows.Forms.TextBox();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscarFuncao = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.lblConsultaFuncao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConsultaFuncao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaFuncao.Location = new System.Drawing.Point(0, 0);
            this.lblConsultaFuncao.Name = "lblConsultaFuncao";
            this.lblConsultaFuncao.Size = new System.Drawing.Size(551, 41);
            this.lblConsultaFuncao.TabIndex = 25;
            this.lblConsultaFuncao.Text = "Consulta de Função";
            this.lblConsultaFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxEscolhaBuscarFuncao
            // 
            this.comboBoxEscolhaBuscarFuncao.FormattingEnabled = true;
            this.comboBoxEscolhaBuscarFuncao.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nome"});
            this.comboBoxEscolhaBuscarFuncao.Location = new System.Drawing.Point(11, 156);
            this.comboBoxEscolhaBuscarFuncao.Name = "comboBoxEscolhaBuscarFuncao";
            this.comboBoxEscolhaBuscarFuncao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEscolhaBuscarFuncao.TabIndex = 26;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(99, 111);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(60, 19);
            this.lblBuscar.TabIndex = 29;
            this.lblBuscar.Text = "Buscar";
            // 
            // textBoxBuscarFuncao
            // 
            this.textBoxBuscarFuncao.Location = new System.Drawing.Point(138, 156);
            this.textBoxBuscarFuncao.Name = "textBoxBuscarFuncao";
            this.textBoxBuscarFuncao.Size = new System.Drawing.Size(397, 20);
            this.textBoxBuscarFuncao.TabIndex = 31;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(181, 111);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(85, 19);
            this.lblCadastrar.TabIndex = 34;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterar.Location = new System.Drawing.Point(287, 111);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(60, 19);
            this.lblAlterar.TabIndex = 36;
            this.lblAlterar.Text = "Alterar";
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.Location = new System.Drawing.Point(384, 111);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(59, 19);
            this.lblExcluir.TabIndex = 38;
            this.lblExcluir.Text = "Excluir";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageKey = "excluir-removebg-preview.ico";
            this.btnExcluir.ImageList = this.imageList1;
            this.btnExcluir.Location = new System.Drawing.Point(379, 58);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(69, 50);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.ImageKey = "editar-removebg-preview.ico";
            this.btnAlterar.ImageList = this.imageList1;
            this.btnAlterar.Location = new System.Drawing.Point(283, 58);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(69, 50);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.ImageKey = "add-removebg-preview.png";
            this.btnCadastrar.ImageList = this.imageList1;
            this.btnCadastrar.Location = new System.Drawing.Point(189, 58);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(69, 50);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscarFuncao
            // 
            this.btnBuscarFuncao.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarFuncao.FlatAppearance.BorderSize = 0;
            this.btnBuscarFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncao.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarFuncao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarFuncao.ImageKey = "buscar-removebg-preview.ico";
            this.btnBuscarFuncao.ImageList = this.imageList1;
            this.btnBuscarFuncao.Location = new System.Drawing.Point(100, 58);
            this.btnBuscarFuncao.Name = "btnBuscarFuncao";
            this.btnBuscarFuncao.Size = new System.Drawing.Size(59, 50);
            this.btnBuscarFuncao.TabIndex = 28;
            this.btnBuscarFuncao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarFuncao.UseVisualStyleBackColor = false;
            this.btnBuscarFuncao.Click += new System.EventHandler(this.btnBuscarFuncao_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestaoPetShop.Properties.Resources.bicho_de_estimacao;
            this.pictureBox3.Location = new System.Drawing.Point(11, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.ImageKey = "fechar-removebg-preview.ico";
            this.btnFechar.ImageList = this.imageList1;
            this.btnFechar.Location = new System.Drawing.Point(485, 3);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 41);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.funcaoDataGridView.AutoGenerateColumns = false;
            this.funcaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.funcaoDataGridView.DataSource = this.funcaoBindingSource;
            this.funcaoDataGridView.Location = new System.Drawing.Point(11, 212);
            this.funcaoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.funcaoDataGridView.Name = "funcaoDataGridView";
            this.funcaoDataGridView.ReadOnly = true;
            this.funcaoDataGridView.RowHeadersVisible = false;
            this.funcaoDataGridView.RowHeadersWidth = 51;
            this.funcaoDataGridView.RowTemplate.Height = 24;
            this.funcaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.funcaoDataGridView.Size = new System.Drawing.Size(295, 179);
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
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(322, 212);
            this.permissoesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersVisible = false;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.permissoesDataGridView.Size = new System.Drawing.Size(213, 179);
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
            this.buttonVincularPermissaoEmFuncao.Location = new System.Drawing.Point(399, 181);
            this.buttonVincularPermissaoEmFuncao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVincularPermissaoEmFuncao.Name = "buttonVincularPermissaoEmFuncao";
            this.buttonVincularPermissaoEmFuncao.Size = new System.Drawing.Size(56, 26);
            this.buttonVincularPermissaoEmFuncao.TabIndex = 40;
            this.buttonVincularPermissaoEmFuncao.Text = "Vincular";
            this.buttonVincularPermissaoEmFuncao.UseVisualStyleBackColor = true;
            this.buttonVincularPermissaoEmFuncao.Click += new System.EventHandler(this.buttonVincularPermissaoEmFuncao_Click);
            // 
            // buttonDesvincularPermissaoDeFuncao
            // 
            this.buttonDesvincularPermissaoDeFuncao.Location = new System.Drawing.Point(460, 181);
            this.buttonDesvincularPermissaoDeFuncao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDesvincularPermissaoDeFuncao.Name = "buttonDesvincularPermissaoDeFuncao";
            this.buttonDesvincularPermissaoDeFuncao.Size = new System.Drawing.Size(76, 26);
            this.buttonDesvincularPermissaoDeFuncao.TabIndex = 41;
            this.buttonDesvincularPermissaoDeFuncao.Text = "Desvincular";
            this.buttonDesvincularPermissaoDeFuncao.UseVisualStyleBackColor = true;
            // 
            // FormBuscarFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 404);
            this.Controls.Add(this.buttonDesvincularPermissaoDeFuncao);
            this.Controls.Add(this.buttonVincularPermissaoEmFuncao);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.funcaoDataGridView);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textBoxBuscarFuncao);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscarFuncao);
            this.Controls.Add(this.comboBoxEscolhaBuscarFuncao);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblConsultaFuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarFuncao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblConsultaFuncao;
        private System.Windows.Forms.ComboBox comboBoxEscolhaBuscarFuncao;
        private System.Windows.Forms.Button btnBuscarFuncao;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox textBoxBuscarFuncao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblExcluir;
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