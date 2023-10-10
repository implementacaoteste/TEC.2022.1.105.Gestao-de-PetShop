namespace GestaoPetShop
{
    partial class FormConsultaAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaAnimal));
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agressivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonIserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(Models.Animal);
            // 
            // animalDataGridView
            // 
            this.animalDataGridView.AllowUserToAddRows = false;
            this.animalDataGridView.AllowUserToDeleteRows = false;
            this.animalDataGridView.AllowUserToOrderColumns = true;
            this.animalDataGridView.AllowUserToResizeColumns = false;
            this.animalDataGridView.AllowUserToResizeRows = false;
            this.animalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animalDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.animalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.animalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.agressivoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.alergiaDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.animalDataGridView.DataSource = this.animalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.animalDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.animalDataGridView.Location = new System.Drawing.Point(11, 72);
            this.animalDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.animalDataGridView.Name = "animalDataGridView";
            this.animalDataGridView.ReadOnly = true;
            this.animalDataGridView.RowHeadersVisible = false;
            this.animalDataGridView.RowHeadersWidth = 51;
            this.animalDataGridView.RowTemplate.Height = 24;
            this.animalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.animalDataGridView.Size = new System.Drawing.Size(843, 391);
            this.animalDataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 70;
            // 
            // agressivoDataGridViewTextBoxColumn
            // 
            this.agressivoDataGridViewTextBoxColumn.DataPropertyName = "Agressivo";
            this.agressivoDataGridViewTextBoxColumn.HeaderText = "Agressivo";
            this.agressivoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agressivoDataGridViewTextBoxColumn.Name = "agressivoDataGridViewTextBoxColumn";
            this.agressivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.agressivoDataGridViewTextBoxColumn.Width = 125;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            this.corDataGridViewTextBoxColumn.Width = 70;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadeDataGridViewTextBoxColumn.Width = 70;
            // 
            // alergiaDataGridViewTextBoxColumn
            // 
            this.alergiaDataGridViewTextBoxColumn.DataPropertyName = "Alergia";
            this.alergiaDataGridViewTextBoxColumn.HeaderText = "Alergia";
            this.alergiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alergiaDataGridViewTextBoxColumn.Name = "alergiaDataGridViewTextBoxColumn";
            this.alergiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.alergiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 70;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(108, 34);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(154, 26);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Id"});
            this.comboBox1.Location = new System.Drawing.Point(11, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(278, 32);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(141, 30);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAlterar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(423, 32);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(141, 30);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonIserir
            // 
            this.buttonIserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIserir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonIserir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIserir.Location = new System.Drawing.Point(568, 32);
            this.buttonIserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIserir.Name = "buttonIserir";
            this.buttonIserir.Size = new System.Drawing.Size(141, 30);
            this.buttonIserir.TabIndex = 7;
            this.buttonIserir.Text = "&Inserir";
            this.buttonIserir.UseVisualStyleBackColor = false;
            this.buttonIserir.Click += new System.EventHandler(this.buttonIserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(713, 32);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(141, 30);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSelecionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Location = new System.Drawing.Point(568, 474);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(141, 30);
            this.buttonSelecionar.TabIndex = 9;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(713, 474);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(141, 30);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar Por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Digite (nome ou id)";
            // 
            // FormConsultaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonIserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.animalDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaAnimal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR ANIMAL";
            this.Load += new System.EventHandler(this.FormConsultaAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.DataGridView animalDataGridView;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonIserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agressivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}