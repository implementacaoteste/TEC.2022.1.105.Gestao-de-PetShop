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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaAnimal));
            this.labelBuscarPorAnimal = new System.Windows.Forms.Label();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeRacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuscarPorAnimal
            // 
            this.labelBuscarPorAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPorAnimal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBuscarPorAnimal.Location = new System.Drawing.Point(-1, 25);
            this.labelBuscarPorAnimal.Name = "labelBuscarPorAnimal";
            this.labelBuscarPorAnimal.Size = new System.Drawing.Size(860, 55);
            this.labelBuscarPorAnimal.TabIndex = 0;
            this.labelBuscarPorAnimal.Text = "Buscar Por Animal";
            this.labelBuscarPorAnimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBuscarPorAnimal.UseWaitCursor = true;
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
            this.animalDataGridView.AutoGenerateColumns = false;
            this.animalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeRacaDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.agressivoDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.alergiaDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.animalDataGridView.DataSource = this.animalBindingSource;
            this.animalDataGridView.Location = new System.Drawing.Point(8, 171);
            this.animalDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animalDataGridView.Name = "animalDataGridView";
            this.animalDataGridView.ReadOnly = true;
            this.animalDataGridView.RowHeadersVisible = false;
            this.animalDataGridView.RowHeadersWidth = 51;
            this.animalDataGridView.RowTemplate.Height = 24;
            this.animalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.animalDataGridView.Size = new System.Drawing.Size(840, 374);
            this.animalDataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nomeRacaDataGridViewTextBoxColumn
            // 
            this.nomeRacaDataGridViewTextBoxColumn.DataPropertyName = "NomeRaca";
            this.nomeRacaDataGridViewTextBoxColumn.HeaderText = "Raça";
            this.nomeRacaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeRacaDataGridViewTextBoxColumn.Name = "nomeRacaDataGridViewTextBoxColumn";
            this.nomeRacaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeRacaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeClienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 50;
            // 
            // agressivoDataGridViewTextBoxColumn
            // 
            this.agressivoDataGridViewTextBoxColumn.DataPropertyName = "Agressivo";
            this.agressivoDataGridViewTextBoxColumn.HeaderText = "Agressivo";
            this.agressivoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agressivoDataGridViewTextBoxColumn.Name = "agressivoDataGridViewTextBoxColumn";
            this.agressivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.agressivoDataGridViewTextBoxColumn.Width = 80;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            this.corDataGridViewTextBoxColumn.Width = 50;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadeDataGridViewTextBoxColumn.Width = 60;
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
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 50;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(137, 128);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(257, 22);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Id"});
            this.comboBox1.Location = new System.Drawing.Point(8, 128);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscar.Location = new System.Drawing.Point(477, 126);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(88, 30);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAlterar.Location = new System.Drawing.Point(572, 126);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(88, 30);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonIserir
            // 
            this.buttonIserir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonIserir.Location = new System.Drawing.Point(667, 123);
            this.buttonIserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIserir.Name = "buttonIserir";
            this.buttonIserir.Size = new System.Drawing.Size(88, 30);
            this.buttonIserir.TabIndex = 7;
            this.buttonIserir.Text = "&Inserir";
            this.buttonIserir.UseVisualStyleBackColor = false;
            this.buttonIserir.Click += new System.EventHandler(this.buttonIserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluir.Location = new System.Drawing.Point(760, 123);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(88, 30);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSelecionar.Location = new System.Drawing.Point(667, 572);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(88, 31);
            this.buttonSelecionar.TabIndex = 9;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.Location = new System.Drawing.Point(760, 572);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 31);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar Por";
            // 
            // FormConsultaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 614);
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
            this.Controls.Add(this.labelBuscarPorAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(878, 661);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(878, 661);
            this.Name = "FormConsultaAnimal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        protected internal System.Windows.Forms.Label labelBuscarPorAnimal;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
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