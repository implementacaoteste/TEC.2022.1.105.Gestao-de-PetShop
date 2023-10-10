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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaServico));
            this.comboBox_EscolhaBuscarServico = new System.Windows.Forms.ComboBox();
            this.textBox_BuscarServico = new System.Windows.Forms.TextBox();
            this.servicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_AlterarServico = new System.Windows.Forms.Button();
            this.button_InserirServico = new System.Windows.Forms.Button();
            this.button_BucarServico = new System.Windows.Forms.Button();
            this.button_ExcluirServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_EscolhaBuscarServico
            // 
            this.comboBox_EscolhaBuscarServico.BackColor = System.Drawing.Color.White;
            this.comboBox_EscolhaBuscarServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EscolhaBuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_EscolhaBuscarServico.FormattingEnabled = true;
            this.comboBox_EscolhaBuscarServico.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Descrição"});
            this.comboBox_EscolhaBuscarServico.Location = new System.Drawing.Point(14, 50);
            this.comboBox_EscolhaBuscarServico.Name = "comboBox_EscolhaBuscarServico";
            this.comboBox_EscolhaBuscarServico.Size = new System.Drawing.Size(87, 28);
            this.comboBox_EscolhaBuscarServico.TabIndex = 4;
            this.comboBox_EscolhaBuscarServico.SelectedIndexChanged += new System.EventHandler(this.comboBox_EscolhaBuscarServico_SelectedIndexChanged);
            // 
            // textBox_BuscarServico
            // 
            this.textBox_BuscarServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_BuscarServico.BackColor = System.Drawing.Color.White;
            this.textBox_BuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BuscarServico.Location = new System.Drawing.Point(107, 50);
            this.textBox_BuscarServico.Name = "textBox_BuscarServico";
            this.textBox_BuscarServico.Size = new System.Drawing.Size(152, 26);
            this.textBox_BuscarServico.TabIndex = 5;
            // 
            // servicoDataGridView
            // 
            this.servicoDataGridView.AllowUserToAddRows = false;
            this.servicoDataGridView.AllowUserToDeleteRows = false;
            this.servicoDataGridView.AllowUserToOrderColumns = true;
            this.servicoDataGridView.AllowUserToResizeColumns = false;
            this.servicoDataGridView.AllowUserToResizeRows = false;
            this.servicoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicoDataGridView.AutoGenerateColumns = false;
            this.servicoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.servicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.servicoDataGridView.DataSource = this.servicoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.servicoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.servicoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.servicoDataGridView.Location = new System.Drawing.Point(12, 85);
            this.servicoDataGridView.MultiSelect = false;
            this.servicoDataGridView.Name = "servicoDataGridView";
            this.servicoDataGridView.ReadOnly = true;
            this.servicoDataGridView.RowHeadersVisible = false;
            this.servicoDataGridView.RowHeadersWidth = 51;
            this.servicoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.servicoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicoDataGridView.Size = new System.Drawing.Size(841, 418);
            this.servicoDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tempo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tempo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "add-removebg-preview.png");
            this.imageList1.Images.SetKeyName(2, "editar-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "excluir-removebg-preview.png");
            this.imageList1.Images.SetKeyName(4, "fechar-removebg-preview.png");
            // 
            // button_AlterarServico
            // 
            this.button_AlterarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AlterarServico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_AlterarServico.FlatAppearance.BorderSize = 0;
            this.button_AlterarServico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AlterarServico.ForeColor = System.Drawing.Color.Black;
            this.button_AlterarServico.ImageKey = "(none)";
            this.button_AlterarServico.ImageList = this.imageList1;
            this.button_AlterarServico.Location = new System.Drawing.Point(420, 48);
            this.button_AlterarServico.Name = "button_AlterarServico";
            this.button_AlterarServico.Size = new System.Drawing.Size(141, 30);
            this.button_AlterarServico.TabIndex = 8;
            this.button_AlterarServico.Text = "Alterar";
            this.button_AlterarServico.UseVisualStyleBackColor = false;
            this.button_AlterarServico.Click += new System.EventHandler(this.button_AlterarServico_Click);
            // 
            // button_InserirServico
            // 
            this.button_InserirServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_InserirServico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_InserirServico.FlatAppearance.BorderSize = 0;
            this.button_InserirServico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InserirServico.ForeColor = System.Drawing.Color.Black;
            this.button_InserirServico.ImageKey = "(none)";
            this.button_InserirServico.Location = new System.Drawing.Point(567, 48);
            this.button_InserirServico.Name = "button_InserirServico";
            this.button_InserirServico.Size = new System.Drawing.Size(141, 30);
            this.button_InserirServico.TabIndex = 7;
            this.button_InserirServico.Text = "Inserir";
            this.button_InserirServico.UseVisualStyleBackColor = false;
            this.button_InserirServico.Click += new System.EventHandler(this.button_InserirServico_Click);
            // 
            // button_BucarServico
            // 
            this.button_BucarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BucarServico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_BucarServico.FlatAppearance.BorderSize = 0;
            this.button_BucarServico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BucarServico.ForeColor = System.Drawing.Color.Black;
            this.button_BucarServico.ImageKey = "(none)";
            this.button_BucarServico.Location = new System.Drawing.Point(273, 48);
            this.button_BucarServico.Name = "button_BucarServico";
            this.button_BucarServico.Size = new System.Drawing.Size(141, 30);
            this.button_BucarServico.TabIndex = 6;
            this.button_BucarServico.Text = "Buscar";
            this.button_BucarServico.UseVisualStyleBackColor = false;
            this.button_BucarServico.Click += new System.EventHandler(this.button_BucarServico_Click);
            // 
            // button_ExcluirServico
            // 
            this.button_ExcluirServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExcluirServico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_ExcluirServico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExcluirServico.Location = new System.Drawing.Point(713, 48);
            this.button_ExcluirServico.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExcluirServico.Name = "button_ExcluirServico";
            this.button_ExcluirServico.Size = new System.Drawing.Size(141, 30);
            this.button_ExcluirServico.TabIndex = 16;
            this.button_ExcluirServico.Text = "Excluir";
            this.button_ExcluirServico.UseVisualStyleBackColor = false;
            this.button_ExcluirServico.Click += new System.EventHandler(this.button_ExcluirServico_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Digite  (descrição ou o id)";
            // 
            // FormConsultaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ExcluirServico);
            this.Controls.Add(this.servicoDataGridView);
            this.Controls.Add(this.textBox_BuscarServico);
            this.Controls.Add(this.comboBox_EscolhaBuscarServico);
            this.Controls.Add(this.button_AlterarServico);
            this.Controls.Add(this.button_InserirServico);
            this.Controls.Add(this.button_BucarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaServico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR SERVIÇOS";
            this.Load += new System.EventHandler(this.FormConsultaServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_EscolhaBuscarServico;
        private System.Windows.Forms.TextBox textBox_BuscarServico;
        private System.Windows.Forms.Button button_BucarServico;
        private System.Windows.Forms.Button button_InserirServico;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.DataGridView servicoDataGridView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_ExcluirServico;
        private System.Windows.Forms.Button button_AlterarServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}