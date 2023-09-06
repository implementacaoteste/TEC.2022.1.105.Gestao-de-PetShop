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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblConsultaFuncao = new System.Windows.Forms.Label();
            this.comboBoxEscolhaBuscarFuncao = new System.Windows.Forms.ComboBox();
            this.btnBuscarFuncao = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscarFuncao = new System.Windows.Forms.TextBox();
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestaoPetShop.Properties.Resources.bicho_de_estimacao;
            this.pictureBox3.Location = new System.Drawing.Point(11, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 41);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.lblConsultaFuncao.Size = new System.Drawing.Size(542, 41);
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
            this.comboBoxEscolhaBuscarFuncao.Location = new System.Drawing.Point(11, 141);
            this.comboBoxEscolhaBuscarFuncao.Name = "comboBoxEscolhaBuscarFuncao";
            this.comboBoxEscolhaBuscarFuncao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEscolhaBuscarFuncao.TabIndex = 26;
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
            this.btnBuscarFuncao.Location = new System.Drawing.Point(104, 58);
            this.btnBuscarFuncao.Name = "btnBuscarFuncao";
            this.btnBuscarFuncao.Size = new System.Drawing.Size(59, 50);
            this.btnBuscarFuncao.TabIndex = 28;
            this.btnBuscarFuncao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarFuncao.UseVisualStyleBackColor = false;
            this.btnBuscarFuncao.Click += new System.EventHandler(this.btnBuscarFuncao_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(103, 111);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(60, 19);
            this.lblBuscar.TabIndex = 29;
            this.lblBuscar.Text = "Buscar";
            // 
            // textBoxBuscarFuncao
            // 
            this.textBoxBuscarFuncao.Location = new System.Drawing.Point(138, 141);
            this.textBoxBuscarFuncao.Name = "textBoxBuscarFuncao";
            this.textBoxBuscarFuncao.Size = new System.Drawing.Size(227, 20);
            this.textBoxBuscarFuncao.TabIndex = 31;
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
            this.funcaoDataGridView.Location = new System.Drawing.Point(12, 182);
            this.funcaoDataGridView.Name = "funcaoDataGridView";
            this.funcaoDataGridView.ReadOnly = true;
            this.funcaoDataGridView.RowHeadersVisible = false;
            this.funcaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.funcaoDataGridView.Size = new System.Drawing.Size(514, 220);
            this.funcaoDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            this.lblAlterar.Location = new System.Drawing.Point(285, 111);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(60, 19);
            this.lblAlterar.TabIndex = 36;
            this.lblAlterar.Text = "Alterar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "editar-removebg-preview.ico";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(281, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 50);
            this.button1.TabIndex = 35;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.Location = new System.Drawing.Point(380, 111);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(59, 19);
            this.lblExcluir.TabIndex = 38;
            this.lblExcluir.Text = "Excluir";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "excluir-removebg-preview.ico";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(376, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 50);
            this.button2.TabIndex = 37;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormBuscarFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 506);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.funcaoDataGridView);
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
        private System.Windows.Forms.BindingSource funcaoBindingSource;
        private System.Windows.Forms.DataGridView funcaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.Button button2;
    }
}